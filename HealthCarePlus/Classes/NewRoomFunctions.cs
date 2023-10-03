using System;
using System.Data;
using System.Data.SqlClient;

namespace HealthCarePlus.Classes
{
    internal class NewRoomFunctions
    {
        private readonly SqlConnection connection;
        private readonly SqlCommand command;
        private readonly string connectionString;

        public NewRoomFunctions()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shima\Documents\HealthCarePlusDB.mdf;Integrated Security=True;Connect Timeout=30";
            connection = new SqlConnection(connectionString);
            command = new SqlCommand();
            command.Connection = connection;
        }

        public DataTable GetRooms()
        {
            string query = "SELECT * FROM RoomsTbl";
            return ExecuteQuery(query);
        }
        //add rooms to the database from addRoom form
        public void AddRoom(string roomName, string roomType, string roomFee, string roomLocation)
        {
            string query = "INSERT INTO RoomsTbl (RoomName, RoomType, RoomFee, RoomLocation) VALUES (@RoomName, @RoomType, @RoomFee, @RoomLocation)";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@RoomName", roomName);
            command.Parameters.AddWithValue("@RoomType", roomType);
            command.Parameters.AddWithValue("@RoomFee", roomFee);
            command.Parameters.AddWithValue("@RoomLocation", roomLocation);

            ExecuteNonQuery(query);
        }
        // update room details
        public void UpdateRoom(int roomId, string roomName, string roomType, string roomFee, string roomLocation)
        {
            string query = "UPDATE RoomsTbl SET RoomName = @RoomName, RoomType = @RoomType, RoomFee = @RoomFee, RoomLocation = @RoomLocation WHERE RoomId = @RoomId";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@RoomName", roomName);
            command.Parameters.AddWithValue("@RoomType", roomType);
            command.Parameters.AddWithValue("@RoomFee", roomFee);
            command.Parameters.AddWithValue("@RoomLocation", roomLocation);
            command.Parameters.AddWithValue("@RoomId", roomId);

            ExecuteNonQuery(query);
        }

        public void DeleteRoom(int roomId)
        {
            string query = "DELETE FROM RoomsTbl WHERE RoomId = @RoomId";

            command.Parameters.Clear();
            command.Parameters.AddWithValue("@RoomId", roomId);

            ExecuteNonQuery(query);
        }

        public DataTable SearchRooms(string searchQuery)
        {
            string query = "SELECT * FROM RoomsTbl WHERE RoomName LIKE @SearchQuery OR RoomType LIKE @SearchQuery OR RoomLocation LIKE @SearchQuery";

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
