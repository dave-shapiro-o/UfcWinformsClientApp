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
            string id = delIdLabel.Text;
            if (MessageUtility.Warning(id).Equals(DialogResult.OK))
            
            {
                string command = $"DELETE FROM Fighters WHERE Id = {id}";
                DbUtility.ExecuteQuery(command, $"I.D. number {id}", "deleted");                
            }
           
            SearchForm.sharedInstance.RefreshGrid();
            Close();
        }
    }
}
