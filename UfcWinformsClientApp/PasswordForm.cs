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
        private readonly SearchForm.Function function;
        private readonly string rowData;
        public PasswordForm(SearchForm.Function func, string data)
        {
            function = func;
            rowData = data;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // !!!!!!!!PASSWORD HERE!!!!!!!!!!!!!!!!!!!! lol
            string password = "Fight!";
            if (passwordTextBox.Text.Equals(password))
            {
                SearchForm.passwordIsAccepted = true;
                Hide();

                Form form = function switch
                {
                    SearchForm.Function.Edit => new EditForm(rowData),
                    SearchForm.Function.Delete => new DeleteForm(rowData),
                    SearchForm.Function.Add => new AddForm(),
                    _ => throw new NotImplementedException()
                };

                form.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }           
        }

    }

}

    

