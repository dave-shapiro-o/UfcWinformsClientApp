using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace awsDbTest1
{
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
