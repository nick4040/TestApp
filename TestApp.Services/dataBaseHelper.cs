using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TestApp.Services
{
    public class dataBaseHelper
    {
        public DataTable ExecuteStoredProcedure(string procedureName, Dictionary<string, object> parameters)
        {
            // Define your connection string
            string connectionString = "YourConnectionStringHere";

            // Create a new DataTable to hold the results
            DataTable dt = new DataTable();

            // Use 'using' statements to ensure proper disposal of resources
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Create a SqlCommand to execute the stored procedure
                using (SqlCommand cmd = new SqlCommand(procedureName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add the parameters required by the stored procedure
                    foreach (var param in parameters)
                    {
                        // Check if the value is null and set it to DBNull.Value if it is
                        cmd.Parameters.Add(new SqlParameter(param.Key, param.Value ?? DBNull.Value));
                    }

                    // Create a SqlDataAdapter to fill the DataTable
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        // Fill the DataTable with the result set returned by the stored procedure
                        da.Fill(dt);
                    }
                }
            }

            // Return the populated DataTable
            return dt;
        }

        public DataTable ExecuteStoredProcedureNoInput(string procedureName)
        {

            string connectionString = "YourConnectionStringHere";

            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(procedureName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }
    }
}
