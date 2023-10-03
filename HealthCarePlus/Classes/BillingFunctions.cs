using HealthCarePlus.Pages.Rooms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace HealthCarePlus.Classes
{
    internal class BillingFunctions
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

        // get appointment details
        public DataTable GetAppointments(string patientName)
        {
            DataTable appointmentsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT AppointmentId, DrName, DoctorFee, HospitalFee FROM AppointmentsTbl WHERE PatName = '{patientName}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(appointmentsTable);
                    }
                }
            }

            return appointmentsTable;
        }

        //get recorded rooms details
        public DataTable GetRooms(string patientName)
        {
            DataTable roomsTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"SELECT RoomId, RoomName, RoomFee FROM RoomBookingTbl WHERE PatientName = '{patientName}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(roomsTable);
                    }
                }
            }

            return roomsTable;
        }

        public void SaveInvoice(string patientName, string drName, string appointmentId, string RoomId, string drFee, string hospitalFee, string totalFee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO InvoicesTbl (PatientName, DrName, AppointmentId, RoomId, DoctorFee, RoomFee, HospitalFee, TotalFee) VALUES (@PatientName, @DrName, @AppointmentId, @RoomId, @DoctorFee, @RoomFee, @HospitalFee, @TotalFee)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PatientName", patientName);
                    command.Parameters.AddWithValue("@DrName", drName);
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId);
                    command.Parameters.AddWithValue("@RoomId", RoomId);
                    command.Parameters.AddWithValue("@DoctorFee", drFee);
                    command.Parameters.AddWithValue("@HospitalFee", hospitalFee);
                    command.Parameters.AddWithValue("@TotalFee", totalFee);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
