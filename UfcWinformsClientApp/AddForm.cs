using System;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void addFighterButton_Click(object sender, EventArgs e) 
        {
            string url = FighterUserControl.url;
            string id = FighterUserControl.id;
            string name = FighterUserControl.name;
            string nickname = FighterUserControl.nickname;
            string height = FighterUserControl.height;
            string weight = FighterUserControl.weight;
            string association = FighterUserControl.association; 
            string weightClass = FighterUserControl.weightClass; 
            string locality = FighterUserControl.locality;
            string country = FighterUserControl.country;

            string command = $"INSERT INTO Fighters (Url, Id, Name, Nickname, Height, Weight, Association, Class, Locality, Country)"
                                 + $"VALUES('{url}', {id}, '{name}', '{nickname}', {height}, {weight}, '{association}', '{weightClass}', '{locality}', '{country}')";
            
            DbUtility.ExecuteQuery(command, name, "added");            
            SearchForm.sharedInstance.RefreshGrid();
            Close();
        }
    }
}
