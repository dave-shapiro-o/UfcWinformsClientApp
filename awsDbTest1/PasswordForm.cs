using System;
using System.Windows.Forms;

namespace awsDbTest1
{
    public partial class PasswordForm : Form
    {
        internal readonly string formType;
        public PasswordForm(Enum function)
        {
            formType = function.ToString();
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
                switch (formType)
                {                 
                    case "Edit":
                        EditForm editForm = new();
                        editForm.Show();
                        break;
                    case "Delete":
                        DeleteForm deleteForm = new();
                        deleteForm.Show();
                        break;
                    case "Add":
                    default:
                        AddForm addForm = new();
                        addForm.Show();
                        break;
                }
                
            }
            else
            {
                MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

    }

}

    

