using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace awsDbTest1
{
    class DbUtility
    {
        internal static MySqlConnection Connect()
        {
            var builder = new MySqlConnectionStringBuilder

            {
                Server = "ec2-18-203-4-191.eu-west-1.compute.amazonaws.com",
                Port = 3306,
                Database = "ufc",
                UserID = "dave",
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
