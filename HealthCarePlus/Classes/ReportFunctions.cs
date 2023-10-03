using System;
using System.Data;
using System.Data.SqlClient;

namespace HealthCarePlus.Classes
{
    internal class ReportFunctions
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shima\Documents\HealthCarePlusDB.mdf;Integrated Security=True;Connect Timeout=30";

        public DataTable GetPatients()
        {
            DataTable patientsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT PatName FROM PatientsTbl";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(patientsTable);
                    }
                }
            }

            return patientsTable;
        }

        public DataTable GetTableNames()
        {
            DataTable tableNames = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT table_name AS TableName FROM information_schema.tables";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(tableNames);
                    }
                }
            }

            return tableNames;
        }

        public DataTable GenerateReport(string selectedCategory)
        {
            DataTable reportData = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // to load the data according to the category
                string query = $"SELECT * FROM {selectedCategory}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(reportData);
                    }
                }
            }

            return reportData;
        }


        public string GetConnectionString()
        {
            return connectionString;
        }
    }
}
