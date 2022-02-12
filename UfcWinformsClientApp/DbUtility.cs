using System;
using System.Data;
using MySqlConnector;

namespace UfcWinformsClientApp
{
    class DbUtility
    {
        internal static MySqlConnection Connect()
        {
            var builder = new MySqlConnectionStringBuilder
            // If using these settings, make sure your new schema (database) is named ufc-local
            // and password = password. Knot exactly fort Nox :)
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
                MessageUtility.DatabaseError(ex);
            }
            return conn;
        }
        internal static void ExecuteQuery(string command, string name, string function)
        {
            using MySqlConnection connection = Connect();
            try
            { 
                MySqlCommand cmd = new(command, connection);
                cmd.ExecuteNonQuery();
                MessageUtility.Success(name, function);
            }
            catch (Exception)
            {
                MessageUtility.Failure(name, function);
            }
        }

        internal static DataTable Fetch(string query)
        {
            // Connects to database, creates a MySqlDataAdapter and a DataTable
            // Adapter fills the table and returns it to SearchForm.cs
            using MySqlConnection conn = Connect();
            try
            {
                MySqlCommand cmd = new();
                cmd.Connection = conn;
                cmd.CommandText = query;

                MySqlDataAdapter adapter = new();
                adapter.SelectCommand = cmd;

                DataTable table = new();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageUtility.DatabaseError(ex);
                return new DataTable();
            }
        }
    }
}
