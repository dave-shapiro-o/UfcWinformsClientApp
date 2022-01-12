using System;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
    // I used this User Control yoke to try to have all the textboxes grouped, to reuse them for Add, Edit, Delete
    // But it made it awkward to access the variables from other classes - more research needed!
    public partial class FighterUserControl : UserControl
    {
        internal static string url, id, name, nickname, height, weight, association, weightClass, locality, country = string.Empty;

        private void associationTextBox_TextChanged(object sender, EventArgs e)
        {
            association = associationTextBox.Text;
        }

        private void localityTextBox_TextChanged(object sender, EventArgs e)
        {
            locality = localityTextBox.Text;
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            weight = weightTextBox.Text;
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            country = countryTextBox.Text;
        }

        private void classTextBox_TextChanged(object sender, EventArgs e)
        {
            weightClass = classTextBox.Text;
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            height = heightTextBox.Text;
        }

        private void nicknameTextBox_TextChanged(object sender, EventArgs e)
        {
            nickname = nicknameTextBox.Text;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
        }

        public FighterUserControl()
        {
            InitializeComponent();
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            url = urlTextBox.Text;
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            id = idTextBox.Text;
        }
    }
}
