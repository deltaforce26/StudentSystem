using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.DAL.Services
{
    internal class DBcontext
    {
     

        
            private string _connectionString { get; init; }

            public DBcontext(string conn)
            {
                if (string.IsNullOrEmpty(conn))
                    throw new ArgumentNullException(nameof(conn));
                _connectionString = conn;

            }

            private void CheckConnection()
            {
                // Try to connect to the database and execute a simple query
                DataTable result = MakeQuery("SELECT 1+1 AS test");
                if (Convert.ToInt32(result.Rows[0][0]) != 2)
                    throw new Exception("Failed to connect to the database.");
            }

            public void CheckConnectionToDefaultDB(string dbName)
            {
                CheckConnection();
                // Construct the query to check for the existence of the database by name in the system catalog
                string query = $"SELECT db_id('{SqlEscape(dbName)}');";

                DataTable result = MakeQuery(query);
                if (result == null || result.Rows.Count == 0 || result.Rows[0][0] == DBNull.Value)
                    throw new Exception($"Database {dbName} is not defined.");
            }







            public DataTable MakeQuery(string query, SqlParameter[] parameters = null!)
            {
                DataTable output = new DataTable();
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        try
                        {
                            connection.Open();
                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                adapter.Fill(output);
                            }
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine("An Error occurred: " + ex.Message);
                        }
                    }


                }
                return output;
            }







            public int ExecuteNonQuery(string query, SqlParameter[] parameters = null!)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        try
                        {
                            connection.Open();
                            return cmd.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            Debug.WriteLine("An error occurred: " + ex.Message);
                            return -1;
                        }

                    }
                }
            }

            public object ExecuteScalar(string query, SqlParameter[] parameters = null!)
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        try
                        {
                            connection.Open();
                            return cmd.ExecuteScalar();
                        }
                        catch (SqlException ex)
                        {
                            Debug.WriteLine("SqlError: " + ex.Message);

                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"General Error: {ex.Message}");
                        }

                        return null!;

                    }
                }
            }

            private string SqlEscape(string input)
            {
                // Simple SQL escape method to avoid basic SQL injection
                return input.Replace("'", "''");
            }

    }
}




