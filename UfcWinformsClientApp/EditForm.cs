using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
    public partial class EditForm : Form
    { 
        public EditForm(string data)
        {
            InitializeComponent();
            setFields(data);
        }

        private void setFields(string data)
        {
            TextBox[] textboxes = {urlTextBox, idTextBox, nameTextBox, nicknameTextBox, heightTextBox, 
                                   weightTextBox, associationTextBox, classTextBox, localityTextBox, countryTextBox};
            string[] rowValues = data.Split("*");
            for (int i = 0; i < textboxes.Length; ++i) 
            {
                textboxes[i].Text = rowValues[i];
            }
        }

        private void saveFighterButton_Click(object sender, EventArgs e)
        {
            // Assign the (possibly edited) text in the textboxes to the variables
            string url = urlTextBox.Text;
            string name = nameTextBox.Text;
            string nickname = nicknameTextBox.Text;
            int height = int.Parse(heightTextBox.Text);
            int weight = int.Parse(weightTextBox.Text);
            string association = associationTextBox.Text;
            string weightClass = classTextBox.Text;
            string locality = localityTextBox.Text; 
            string country = countryTextBox.Text;

            using MySqlConnection conn = DbUtility.Connect();
            try
            {
                // Update table using the variables
                MySqlCommand cmd = new($"UPDATE Fighters SET Url = '{url}', Name = '{name}', Nickname = '{nickname}', Height = {height}, Weight = {weight}, Association = '{association}', Class = '{weightClass}', Locality = '{locality}', Country = '{country}' WHERE Id = {idTextBox.Text}", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show($"Records for {name} have been modified!", "Success", MessageBoxButtons.OK);
            SearchForm.sharedInstance.RefreshGrid();
            Close();
        }

        private void fighterUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
