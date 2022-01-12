using System;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
    // Here we are at Fort Knox
    // This validates the password that a user must enter to access Add, Edit, Delete
    // In SearchForm.cs there is an enum called Function
    // Button_Click methods for Add, Edit, Delete call a method named EnterRestrictedZone
    // This checks whether the user has successfully entered their password:
    // If so, it opens the correct form based on the Function passed in to it
    // Otherwise it sends them here
    public partial class PasswordForm : Form
    {
        internal readonly SearchForm.Function function;
        public PasswordForm(SearchForm.Function func)
        {
            function = func;
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new();
            searchForm.Show();
            passwordPanel.Visible = false;
        }

        private void editDatabaseButton_Click(object sender, EventArgs e)
        {
            passwordPanel.Visible = true;

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // !!!!!!!!PASSWORD HERE!!!!!!!!!!!!!!!!!!!! lol
            string password = "Fight!";
            if (passwordTextBox.Text.Equals(password))
            {
                SearchForm.passwordIsAccepted = true;
                this.Hide();

                Form form = function switch
                {
                    SearchForm.Function.Edit => new EditForm(),
                    SearchForm.Function.Delete => new DeleteForm(),
                    SearchForm.Function.Add => new AddForm(),
                    _ => throw new NotImplementedException()
                };

                form.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

    }

}

    

