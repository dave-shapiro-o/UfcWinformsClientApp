using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace UfcWinformsClientApp
{
    class DbUtility
    {
        internal static MySqlConnection Connect()
        {
            var builder = new MySqlConnectionStringBuilder

            {
                Server = "localhost",
                Port = 3306,
                Database = "ufc-local",
                UserID = "root",
                Password = "password",
                ConnectionTimeout = 30
            };
            MySqlConnection conn = new(builder.ConnectionString);
            try
            {
                if (!conn.State.Equals(ConnectionState.Open))
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
    }
}
