using System;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
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

    

