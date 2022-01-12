using MySqlConnector;
using System;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
    public partial class EditForm : Form
    {
        string url;
        int id;
        string name;
        string nickname;
        int height;
        int weight;
        string association;
        string weightClass;
        string locality;
        string country;

        string searchId;

        public EditForm()
        {
            InitializeComponent();
        }

        private void saveFighterButton_Click(object sender, EventArgs e)
        {
            url = urlTextBox.Text;
            name = nameTextBox.Text;
            nickname = nicknameTextBox.Text;
            height = int.Parse(heightTextBox.Text);
            weight = int.Parse(weightTextBox.Text);
            association = associationTextBox.Text;
            weightClass = classTextBox.Text;
            locality = localityTextBox.Text; 
            country = countryTextBox.Text;

            using MySqlConnection conn = DbUtility.Connect();
            try
            {
                MySqlCommand cmd = new($"UPDATE Fighters SET Url = '{url}', Name = '{name}', Nickname = '{nickname}', Height = {height}, Weight = {weight}, Association = '{association}', Class = '{weightClass}', Locality = '{locality}', Country = '{country}' WHERE Id = {id}", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show($"Records for {name} have been modified!", "Success", MessageBoxButtons.OK);
            Close();
        }

        private void findFighterButton_Click(object sender, EventArgs e)
        {
            using MySqlConnection conn = DbUtility.Connect();
            searchId = fighterIdTextBox.Text;
            try
            {
                MySqlCommand cmd = new($"SELECT Url, Id, Name, Nickname, Height, Weight, Association, Class, Locality, Country FROM Fighters "
                                    + $"WHERE Id = {int.Parse(searchId)}", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    url = reader.GetString(0);
                    id = reader.GetInt32(1);
                    name = reader.GetString(2);
                    nickname = reader.GetString(3);
                    height = reader.GetInt32(4);
                    weight = reader.GetInt32(5);
                    association = reader.GetString(6);
                    weightClass = reader.GetString(7);
                    locality = reader.GetString(8);
                    country = reader.GetString(9);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fighter not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            urlTextBox.Text = url;
            idTextBox.Text = id.ToString();
            nameTextBox.Text = name;
            nicknameTextBox.Text = nickname;
            heightTextBox.Text = height.ToString();
            weightTextBox.Text = weight.ToString();
            associationTextBox.Text = association;
            classTextBox.Text = weightClass;
            localityTextBox.Text = locality;
            countryTextBox.Text = country;
        }

        private void fighterUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
