using MySqlConnector;
using System;
using System.Windows.Forms;

namespace awsDbTest1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void fighterUserControl1_Load(object sender, EventArgs e)
        {

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

            using MySqlConnection conn = DbUtility.Connect();
            try
            {
                MySqlCommand cmd = new($"INSERT INTO Fighters (Url, Id, Name, Nickname, Height, Weight, Association, Class, Locality, Country)"
                                 + $"VALUES('{url}', {id}, '{name}', '{nickname}', {height}, {weight}, '{association}', '{weightClass}', '{locality}', '{country}')", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MessageBox.Show("Fighter added to database!", "Success", MessageBoxButtons.OK);
            Close();
        }
    }
}
