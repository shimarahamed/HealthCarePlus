using System;
using System.Data;
using System.Data.SqlClient;

namespace HealthCarePlus.Classes
{
    internal class AppointmentFunctions
    {
        private readonly SqlConnection connection;
        private readonly SqlCommand command;
        private readonly string connectionString;

        //database conenction
        public AppointmentFunctions()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shima\Documents\HealthCarePlusDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }
        //get patients details
        public DataTable GetPatients()
        {
            string query = "SELECT PatName, PatDOB FROM PatientsTbl";
            return ExecuteQuery(query);
        }
        //get doctors details
        public DataTable GetSpecializations()
        {
            string query = "SELECT DISTINCT DrSpecialization FROM DoctorsTable";
            return ExecuteQuery(query);
        }

        public DataTable GetDoctorsBySpecialization(string specialization)
        {
            string query = "SELECT DrName FROM DoctorsTable WHERE DrSpecialization = @DrSpecialization";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@DrSpecialization", specialization);
            return ExecuteQuery(query);
        }

        public decimal GetDoctorFee(string doctorName)
        {
            string query = "SELECT DrFee FROM DoctorsTable WHERE DrName = @DrName";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@DrName", doctorName);

            try
            {
                connection.Open();
                command.CommandText = query;
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDecimal(result);
                }
                return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
        //to show appointment details form database
        public DataTable GetAppointments()
        {
            string query = "SELECT * FROM AppointmentsTbl";
            return ExecuteQuery(query);
        }

        public void AddAppointment(string patientName, int patientAge, string doctorName, string drSpecialization, DateTime appointmentDate, string appointmentTime, decimal doctorFee, decimal hospitalFee, decimal totalFee)
        {
            string query = "INSERT INTO AppointmentsTbl (PatName, PatientAge, DrName, DrSpecialization, AppointmentDate, AppointmentTime, DoctorFee, HospitalFee, TotalFee) " +
                           "VALUES (@PatName, @PatientAge, @DrName, @DrSpecialization, @AppointmentDate, @AppointmentTime, @DoctorFee, @HospitalFee, @TotalFee)";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@PatName", patientName);
            command.Parameters.AddWithValue("@PatientAge", patientAge);
            command.Parameters.AddWithValue("@DrName", doctorName);
            command.Parameters.AddWithValue("@DrSpecialization", drSpecialization);
            command.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
            command.Parameters.AddWithValue("@AppointmentTime", appointmentTime);
            command.Parameters.AddWithValue("@DoctorFee", doctorFee);
            command.Parameters.AddWithValue("@HospitalFee", hospitalFee);
            command.Parameters.AddWithValue("@TotalFee", totalFee);

            ExecuteNonQuery(query);
        }

        //search appointment
        public DataTable SearchAppointments(string searchQuery)
        {
            string query = "SELECT * FROM AppointmentsTbl " +
                           "WHERE PatName LIKE @SearchQuery OR DrName LIKE @SearchQuery OR CONVERT(NVARCHAR, AppointmentDate, 101) LIKE @SearchQuery";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");

            return ExecuteQuery(query);
        }

        private DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();
                command.CommandText = query;
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        private void ExecuteNonQuery(string query)
        {
            try
            {
                connection.Open();
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
