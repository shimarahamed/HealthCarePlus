using System;
using System.Data;
using System.Data.SqlClient;

namespace HealthCarePlus.Classes
{
    internal class ResourcesFunctions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private SqlDataAdapter sda;
        private string Constr;

        public ResourcesFunctions()
        {
            Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shima\Documents\HealthCarePlusDB.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(Constr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable GetResourceData(string Query)
        {
            DataTable dt = new DataTable();
            using (sda = new SqlDataAdapter(Query, Con))
            {
                sda.Fill(dt);
            }
            return dt;
        }

        public int SetResourceData(string Query)
        {
            int Cnt = 0;
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
            Cmd.CommandText = Query;
            Cnt = Cmd.ExecuteNonQuery();
            Con.Close();
            return Cnt;
        }

        public DataTable SearchResources(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Constr))
                {
                    connection.Open();

                    string query = "SELECT * FROM ResourcesTbl " +
                                   "WHERE ResName LIKE @SearchQuery OR ResSN LIKE @SearchQuery";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }

        //adding resource to database with types
        public void AddResource(string ResName, string ResSN, string ResLocation, string ResDate, string ResType)
        {
            string Query = "INSERT INTO ResourcesTbl (ResName, ResSN, ResLocation, ResDate, ResType) VALUES('{0}','{1}','{2}','{3}','{4}')";
            Query = string.Format(Query, ResName, ResSN, ResLocation, ResDate, ResType);
            SetResourceData(Query);
        }

        public void UpdateResource(int ResId, string ResName, string ResSN, string ResLocation, string ResDate, string ResType)
        {
            string Query = "UPDATE ResourcesTbl SET ResName = '{0}', ResSN = '{1}', ResLocation = '{2}', ResDate = '{3}', ResType = '{4}' WHERE ResId = {5}";
            Query = string.Format(Query, ResName, ResSN, ResLocation, ResDate, ResType, ResId);
            SetResourceData(Query);
        }


        public void DeleteResource(int ResId)
        {
            string Query = "DELETE FROM ResourcesTbl WHERE ResId = {0}";
            Query = string.Format(Query, ResId);
            SetResourceData(Query);
        }
    }
}
