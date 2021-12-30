//using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace awsDbTest1
{
    public partial class SearchForm : Form
    {
        bool selectAllFighters;
        internal static bool passwordIsAccepted;
        public SearchForm()
        {
            InitializeComponent();
        }
        public enum Function
        {
            Search,
            ShowAll,
            Add,
            Edit,
            Delete
        };

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            selectAllFighters = false;
            GetData(searchText, dataGridView1);
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text;
            selectAllFighters = true;
            GetData(searchText, dataGridView1);
        }

        void GetData(string searchText, DataGridView view)
        {
            using MySqlConnection conn = DbUtility.Connect();
           
            try
            {
                MySqlCommand cmd = new();
                cmd.Connection = conn;
                cmd.CommandText = selectAllFighters? 
                    "SELECT * FROM Fighters" :
                    SearchSelect(cmd, searchText);
                
                MySqlDataAdapter adapter = new();
                adapter.SelectCommand = cmd;
                
                DataTable table = new();
                adapter.Fill(table);
                view.DataSource = table;
                table.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string SearchSelect(MySqlCommand cmd, string searchText)
        {
            
            switch ((string)comboBox1.SelectedItem)
            {
                case "Nickname":
                    return $"SELECT * FROM Fighters WHERE Nickname LIKE '%{searchText}%'";
                case "Country":
                    return $"SELECT * FROM Fighters WHERE Country LIKE '%{searchText}%'";
                case "Weight":
                    int min = trackBar1.Value * 3;
                    int max = trackBar2.Value * 3;
                    return searchText.Equals("") ? 
                        $"SELECT * FROM Fighters WHERE Weight BETWEEN {min} AND {max}" :
                        $"SELECT * FROM Fighters WHERE Weight = {int.Parse(searchText)}";
                case "Height":
                    min = trackBar1.Value;
                    max = trackBar2.Value;
                    return searchText.Equals("") ?
                        $"SELECT * FROM Fighters WHERE Height BETWEEN {min} AND {max}" :
                        $"SELECT * FROM Fighters WHERE Height = {int.Parse(searchText)}";
                case "Name":
                default:
                    return $"SELECT * FROM Fighters WHERE Name LIKE '%{searchText}%'";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar1.Value = trackBar1.Maximum / 2;
            trackBar2.Value = trackBar2.Maximum / 2;
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
            textBox1.Text = "";
            SetMinTrackBar((string)comboBox1.SelectedItem == "Weight" ? 3 : 1);
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            textBox1.Text = "";
            SetMaxTrackBar((string)comboBox1.SelectedItem == "Weight" ? 3 : 1);
        }

        private void SetMinTrackBar(int scaleFactor)
        {
            minValueLabel.Text = (trackBar1.Value * scaleFactor).ToString();
        }
        private void SetMaxTrackBar(int scaleFactor)
        {
            maxValueLabel.Text = (trackBar2.Value * scaleFactor).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addFighterButton_Click(object sender, EventArgs e)
        {
            if (!passwordIsAccepted)
            {
                PasswordForm passwordForm = new(Function.Add);
                passwordForm.Show();
            }
            else
            {
                AddForm addForm = new();
                addForm.Show();
            }
        }

        private void editFighterButton_Click(object sender, EventArgs e)
        {
            if (!passwordIsAccepted)
            {
                PasswordForm passwordForm = new(Function.Edit);
                passwordForm.Show();
            }
            else
            {
                EditForm editForm = new();
                editForm.Show();
            }
        }

        private void deleteFighterButton_Click(object sender, EventArgs e)
        {
            if (!passwordIsAccepted)
            {
                PasswordForm passwordForm = new(Function.Delete);
                passwordForm.Show();
            }
            else
            {
                DeleteForm deleteForm = new();
                deleteForm.Show();
            }
            
        }
    }
    
}
