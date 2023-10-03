using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Classes
{
    internal class DoctorsFunctions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string Constr;

        public DoctorsFunctions()
        {
            Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shima\Documents\HealthCarePlusDB.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(Constr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Con);
            sda.Fill(dt);
            return dt;

        }
        public int DeleteDoctor(int doctorId)
        {
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                string deleteQuery = $"DELETE FROM DoctorsTable WHERE DoctorId = {doctorId}";
                SqlCommand cmd = new SqlCommand(deleteQuery, Con);
                int rowsDeleted = cmd.ExecuteNonQuery();
                Con.Close();

                return rowsDeleted;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return -1; 
            }
        }
        public int SetData(string Query)
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

        //search docctor
        public DataTable SearchDoctors(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Constr))
                {
                    connection.Open();

                    string query = "SELECT * FROM DoctorsTable " +
                                   "WHERE DrName LIKE @SearchQuery OR DrPhone LIKE @SearchQuery OR DrNIC LIKE @SearchQuery OR DrSpecilization LIKE @SearchQuery";

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
    }
}
