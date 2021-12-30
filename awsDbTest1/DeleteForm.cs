using MySqlConnector;
using System;
using System.Windows.Forms;

namespace awsDbTest1
{
    public partial class DeleteForm : Form
    {
        string searchId;
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void findFighterButton_Click(object sender, EventArgs e)
        {
            using MySqlConnection conn = DbUtility.Connect();
            searchId = delFighterIdTextBox.Text;
            try
            {
                MySqlCommand cmd = new($"SELECT Url, Id, Name, Nickname, Height, Weight, Association, Class, Locality, Country FROM Fighters "
                                    + $"WHERE Id = {int.Parse(searchId)}", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    delUrlLabel.Text = reader.GetString(0);
                    delIdLabel.Text = reader.GetInt32(1).ToString();
                    delNameLabel.Text = reader.GetString(2);
                    delNicknameLabel.Text = reader.GetString(3);
                    delHeightLabel.Text = reader.GetInt32(4).ToString();
                    delWeightLabel.Text = reader.GetInt32(5).ToString();
                    delAssociationLabel.Text = reader.GetString(6);
                    delClassLabel.Text = reader.GetString(7);
                    delLocalityLabel.Text = reader.GetString(8);
                    delCountryLabel.Text = reader.GetString(9);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fighter not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            delStatsPanel.Visible = true;
        }

        private void deleteFighterButton_Click(object sender, EventArgs e)
        {
            using MySqlConnection conn = DbUtility.Connect();
            try
            {
                MySqlCommand cmd = new($"DELETE FROM Fighters WHERE Id = {int.Parse(searchId)}", conn);
                DialogResult result = MessageBox.Show($"You are about to delete all records for I.D. number {searchId}.\n Continue?", "Beware!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Records for Fighter I.D. {searchId} have been deleted!", "Success", MessageBoxButtons.OK);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
