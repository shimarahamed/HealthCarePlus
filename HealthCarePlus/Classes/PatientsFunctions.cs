using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace HealthCarePlus.Classes
{
    internal class PatientsFunctions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private SqlDataAdapter sda;
        private string Constr;

        public PatientsFunctions()
        {
            Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shima\Documents\HealthCarePlusDB.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(Constr);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable GetData(string Query)
        {
            DataTable dt = new DataTable();
            using (sda = new SqlDataAdapter(Query, Con))
            {
                sda.Fill(dt);
            }
            return dt;
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

        public DataTable SearchPatients(string searchQuery)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Constr))
                {
                    connection.Open();

                    string query = "SELECT * FROM PatientsTbl " +
                                   "WHERE PatName LIKE @SearchQuery OR PatPhone LIKE @SearchQuery";

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
        //add patient to the database
        public void AddPatient(string Patient, string Phone, string Address, string Gender, string Blood, string DOB)
        {
            string Query = "INSERT INTO PatientsTbl VALUES('{0}','{1}','{2}','{3}','{4}','{5}')";
            Query = string.Format(Query, Patient, Phone, Address, Gender, Blood, DOB);
            SetData(Query);
        }

        public void UpdatePatient(string Patient, string Phone, string Address, string Gender, string Blood, string DOB, int Key)
        {
            string Query = "UPDATE PatientsTbl SET PatName = '{0}', PatPhone = '{1}', PatAddress = '{2}', PatGender = '{3}', PatBlood = '{4}', PatDOB = '{5}' WHERE PatId = {6}";
            Query = string.Format(Query, Patient, Phone, Address, Gender, Blood, DOB, Key);
            SetData(Query);
        }

        public void DeletePatient(int Key)
        {
            string Query = "DELETE FROM PatientsTbl WHERE PatId = {0}";
            Query = string.Format(Query, Key);
            SetData(Query);
        }
    }
}
