using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Classes
{
    internal class RoomFunctions
    {
        private readonly SqlConnection connection;
        private readonly SqlCommand command;
        private readonly string connectionString;

        public RoomFunctions()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shima\Documents\HealthCarePlusDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        public void UpdateBooking(int bookingId, string roomId, string patientName, DateTime startDate, DateTime endDate)
        {
            string query = "UPDATE RoomBookingTbl SET RoomId = @RoomId, PatientName = @PatientName, StartDate = @StartDate, EndDate = @EndDate WHERE BookingId = @BookingId";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@RoomId", roomId);
            command.Parameters.AddWithValue("@PatientName", patientName);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@BookingId", bookingId);

            ExecuteNonQuery(query);
        }

        public decimal GetRoomFee(string roomName)
        {
            decimal roomFee = 0;

            try
            {
                connection.Open();
                string query = "SELECT RoomFee FROM RoomsTbl WHERE RoomName = @RoomName";
                command.CommandText = query;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@RoomName", roomName);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    roomFee = Convert.ToDecimal(result);
                }
            }
            finally
            {
                connection.Close();
            }

            return roomFee;
        }

        public void DeleteBooking(int roomId)
        {
            try
            {
                connection.Open();
                string query = "DELETE FROM RoomBookingTbl WHERE RoomId = @RoomId";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@RoomId", roomId);
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable GetRooms()
        {
            string query = "SELECT RoomId, RoomName FROM RoomsTbl";
            return ExecuteQuery(query);
        }

        public DataTable GetPatients()
        {
            string query = "SELECT PatName FROM PatientsTbl";
            return ExecuteQuery(query);
        }

        

        public DataTable GetRoomBookings()
        {
            string query = "SELECT * FROM RoomBookingTbl";
            return ExecuteQuery(query);
        }

        public void BookRoom(string roomId, string patientName, DateTime startDate, DateTime endDate, decimal roomFee)
        {
            string query = "INSERT INTO RoomBookingTbl (RoomName, PatientName, StartDate, EndDate, RoomFee) VALUES (@RoomId, @PatientName, @StartDate, @EndDate, @RoomFee)";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@RoomId", roomId);
            command.Parameters.AddWithValue("@PatientName", patientName);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@EndDate", endDate);
            command.Parameters.AddWithValue("@RoomFee", roomFee);

            ExecuteNonQuery(query);
        }


        public DataTable SearchRoomBookings(string searchQuery)
        {
            string query = "SELECT * FROM RoomBookingTbl " +
                           "WHERE RoomId LIKE @SearchQuery OR PatientName LIKE @SearchQuery";

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
