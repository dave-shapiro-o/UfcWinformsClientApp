using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace UfcWinformsClientApp
{
    public partial class SearchForm : Form
    {
        internal static bool selectAllFighters;
        internal static bool passwordIsAccepted;
        internal string fighterUrl;
        internal string lastQuery;
        public static SearchForm sharedInstance;
        public SearchForm()
        {
            if (sharedInstance == null)
            {
                sharedInstance = this;
            }
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }
        public enum Function
        {
            Add,
            Edit,
            Delete
        };

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            selectAllFighters = false;
            GetData(searchText);
            
        }
        private void searchAllButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            selectAllFighters = true;
            GetData(searchText);
        }
 
        void GetData(string searchText)
        {
            // Connects to database, calls SearchSelect to get the query,
            // Creates a MySqlDataAdapter and a DataTable
            // Adapter fills the table and sets the form's DataGridView's data source to the table
            using MySqlConnection conn = DbUtility.Connect(); 
            try
            {
                MySqlCommand cmd = new();
                cmd.Connection = conn;
                cmd.CommandText = SearchSelect(searchText);
                
                MySqlDataAdapter adapter = new();
                adapter.SelectCommand = cmd;
                
                DataTable table = new();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                table.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lastQuery = searchText;
        }

        private string SearchSelect(string searchText)
        {
            if (selectAllFighters)
            {
                return "SELECT * FROM Fighters";
            }
            switch ((string)comboBox1.SelectedItem)
            {
                case "Name":
                    return $"SELECT * FROM Fighters WHERE Name LIKE '%{searchText}%'";
                case "Nickname":
                    return $"SELECT * FROM Fighters WHERE Nickname LIKE '%{searchText}%'";
                case "Country":
                    return $"SELECT * FROM Fighters WHERE Country LIKE '%{searchText}%'";
                // Trackbars calibrated for weight in lbs
                case "Weight":
                    int min = minTrackBar.Value * 3;
                    int max = maxTrackBar.Value * 3;
                // Only uses trackbars' values if there is no value entered in the textbox
                // (the textbox is cleared if either of the trackbars is used in their trackbar_Scroll methods below
                    return searchText.Equals("") ? 
                        $"SELECT * FROM Fighters WHERE Weight BETWEEN {min} AND {max}" :
                        $"SELECT * FROM Fighters WHERE Weight = {int.Parse(searchText)}";
                case "Height":
                    min = minTrackBar.Value;
                    max = maxTrackBar.Value;
                    return searchText.Equals("") ?
                        $"SELECT * FROM Fighters WHERE Height BETWEEN {min} AND {max}" :
                        $"SELECT * FROM Fighters WHERE Height = {int.Parse(searchText)}";
                default:
                    return $"SELECT * FROM Fighters WHERE Nickname LIKE '%The Frolicking Unicorn%'";
            }
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "Country") 
            {
                searchTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            }
            else
            {
                searchTextBox.AutoCompleteMode = AutoCompleteMode.None;
            }
            // Resets trackbars to centre, displays them if Weight or Height are selected
            minTrackBar.Value = minTrackBar.Maximum / 2;
            maxTrackBar.Value = maxTrackBar.Maximum / 2;
            switch (comboBox1.SelectedItem)
            {
                case "Weight":
                    sliderPanel.Visible = true;             
                    sliderCategoryLabel.Text = "Weight";
                    SetMinTrackBar(3);
                    SetMaxTrackBar(3);
                    break;
                case "Height":
                    sliderPanel.Visible = true;                    
                    sliderCategoryLabel.Text = "Height";
                    SetMinTrackBar(1);
                    SetMaxTrackBar(1);
                    break;
                default:
                    sliderPanel.Visible = false;
                    break;
            }
        }
        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            int scaleFactor = (string)comboBox1.SelectedItem == "Weight" ? 3 : 1;
            minValueLabel.Text = (minTrackBar.Value * scaleFactor).ToString();
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            searchTextBox.Text = "";
            int scaleFactor = (string)comboBox1.SelectedItem == "Weight" ? 3 : 1;
            maxValueLabel.Text = (maxTrackBar.Value * scaleFactor).ToString();
        }
        // Calibrates trackbars according to whether Height or Weight is selected
        private void SetMinTrackBar(int scaleFactor)
        {
            minValueLabel.Text = (minTrackBar.Value * scaleFactor).ToString();
        }
        private void SetMaxTrackBar(int scaleFactor)
        {
            maxValueLabel.Text = (maxTrackBar.Value * scaleFactor).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addFighterButton_Click(object sender, EventArgs e)
        {
            if (!passwordIsAccepted)
            {
                PasswordForm passwordForm = new(Function.Add, string.Empty);
                passwordForm.Show();
            }
            else
            {
                Form form = new AddForm();
                form.Show();
            }
        }

        private void editFighterButton_Click(object sender, EventArgs e)
        {
            EnterRestrictedZone(Function.Edit);
        }

        private void deleteFighterButton_Click(object sender, EventArgs e)
        {
            EnterRestrictedZone(Function.Delete);
        }
         
        // Password check
        private void EnterRestrictedZone(Function function)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                string rowData = string.Empty;
                for (int i = 0; i < row.Cells.Count; ++i) { rowData += Convert.ToString(row.Cells[i].Value) + "*"; }

                if (!passwordIsAccepted)
                {
                    PasswordForm passwordForm = new(function, rowData);
                    passwordForm.Show();
                }
                else
                {
                    Form form = function switch
                    {
                        Function.Edit => new EditForm(rowData),
                        Function.Delete => new DeleteForm(rowData),
                        _ => throw new NotImplementedException()
                    };
                    form.Show();
                }
            }
        }

        public void RefreshGrid()
        {
            GetData(lastQuery);
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[index];
                string subUrl = Convert.ToString(row.Cells["Url"].Value);

                fighterUrl = "http://www.sherdog.com/" + subUrl.Replace(" ", "");
                string goToUrl = $"/c start {fighterUrl.Trim()}";
                System.Diagnostics.Process.Start("cmd", goToUrl);
            }
        }
    }
    
}
