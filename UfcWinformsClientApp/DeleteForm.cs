using MySqlConnector;
using System;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
    public partial class DeleteForm : Form
    {
        public DeleteForm(string data)
        {
            InitializeComponent();
            setFields(data);
        }
        private void setFields(string data)
        {
            Label[] labels = {delUrlLabel, delIdLabel, delNameLabel, delNicknameLabel, delHeightLabel, 
                              delWeightLabel, delAssociationLabel, delClassLabel, delLocalityLabel, delCountryLabel};
            string[] rowValues = data.Split("*");
            for (int i = 0; i < labels.Length; ++i)
            {
                labels[i].Text = rowValues[i];
            }
        }

        private void deleteFighterButton_Click(object sender, EventArgs e)
        {
            using MySqlConnection conn = DbUtility.Connect();
            try
            {
                // Display an "Are you sure?" dialog before executing the delete
                string id = delIdLabel.Text;
                MySqlCommand cmd = new($"DELETE FROM Fighters WHERE Id = {id}", conn);
                DialogResult result = MessageBox.Show($"You are about to delete all records for I.D. number {id}.\n Continue?", "Beware!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"Records for Fighter I.D. {id} have been deleted!", "Success", MessageBoxButtons.OK);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SearchForm.sharedInstance.RefreshGrid();
            Close();
        }
    }
}
