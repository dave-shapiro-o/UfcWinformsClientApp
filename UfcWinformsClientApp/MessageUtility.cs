using System;
using System.Windows.Forms;

namespace UfcWinformsClientApp
{
    class MessageUtility
    {
        internal static void Success(string name, string function)
        {
            MessageBox.Show($"Records for {name} have been {function}!", "Success", MessageBoxButtons.OK);
        }

        internal static void Failure(string name, string function)
        {
            MessageBox.Show("Database Error!", $"Records for {name} have not been {function}.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static DialogResult Warning(string id)
        {
            return MessageBox.Show($"You are about to delete all records for I.D. number {id}.\n Continue?",
                                   "Beware!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        internal static void DatabaseError(Exception ex)
        {
            MessageBox.Show(ex.Message, "Database error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void NoResults()
        {
            MessageBox.Show("No results found", "Please try another search", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
