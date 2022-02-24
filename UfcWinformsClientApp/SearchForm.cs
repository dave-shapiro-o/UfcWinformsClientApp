using System;
using System.Data;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
    public partial class SearchForm : Form
    {
        private const string showAllFighters = "SELECT * FROM Fighters ORDER BY Id DESC";
        private static bool selectAllFighters;
        internal static bool passwordIsAccepted;
        private string fighterUrl;
        private string lastQuery;
        private AutoCompleteStringCollection countries;
        private AutoCompleteStringCollection names;
        private AutoCompleteStringCollection nicknames;

        public static SearchForm sharedInstance;
        public SearchForm()
        {
            if (sharedInstance == null)
            {
                sharedInstance = this;
            }
            InitializeComponent();
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
            if (dataGridView1.Rows.Count == 1)
            {
                MessageUtility.NoResults();
            }
        }
        private void searchAllButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            selectAllFighters = true;
            GetData(searchText);
        }
 
        private void GetData(string searchText)
        {
            string query = SearchSelect(searchText);
            DataTable table = DbUtility.Fetch(query);
            dataGridView1.DataSource = table;
            table.AcceptChanges();
            lastQuery = searchText;
        }

        private string SearchSelect(string searchText)
        {
            if (selectAllFighters)
            {
                return showAllFighters;
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
       //using a Lambdas
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTextBox.AutoCompleteCustomSource = (string)comboBox1.SelectedItem switch
            {
                "Name" => names,
                "Nickname" => nicknames,
                "Country" => countries,
                _ => new AutoCompleteStringCollection()
            };          
            
            // Resets trackbars to centre, displays them if Weight or Height are selected
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
            minTrackBar.Value = minTrackBar.Maximum / 2;
            minValueLabel.Text = (minTrackBar.Value * scaleFactor).ToString();
        }
        private void SetMaxTrackBar(int scaleFactor)
        {
            maxTrackBar.Value = maxTrackBar.Maximum / 2;
            maxValueLabel.Text = (maxTrackBar.Value * scaleFactor).ToString();
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

        private void SearchForm_Load(object sender, EventArgs e)
        {
            countries = new();
            names = new();
            nicknames = new();

            DataTable allFightersTable = DbUtility.Fetch("SELECT * FROM Fighters;");
            foreach(DataRow row in allFightersTable.Rows)
            {
                names.Add(Convert.ToString(row["Name"]));
                nicknames.Add(Convert.ToString(row["Nickname"]));
                countries.Add(Convert.ToString(row["Country"]));
            }
        }

        private void maxValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void minValueLabel_Click(object sender, EventArgs e)
        {

        }

        private void minLabel_Click(object sender, EventArgs e)
        {

        }

        private void maxLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchQueryLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }   
}
