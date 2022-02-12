using System;
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

            string command = $"UPDATE Fighters SET Url = '{url}', Name = '{name}', Nickname = '{nickname}', " 
                + $"Height = {height}, Weight = {weight}, Association = '{association}', Class = '{weightClass}', " 
                + $"Locality = '{locality}', Country = '{country}' WHERE Id = {idTextBox.Text}";
            
            DbUtility.ExecuteQuery(command, name, "edited");
            SearchForm.sharedInstance.RefreshGrid();
            Close();
        }
    }
}
