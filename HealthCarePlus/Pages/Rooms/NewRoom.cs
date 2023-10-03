using HealthCarePlus.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Pages.Rooms
{
    public partial class NewRoom : Form
    {
        private NewRoomFunctions roomFunctions;
        private int selectedRoomId = -1; 

        public NewRoom()
        {
            InitializeComponent();
            roomFunctions = new NewRoomFunctions();
            ShowBookings(); 
        }

        
        private void ShowBookings()
        {
            DataTable rooms = roomFunctions.GetRooms();
            RoomsLists.DataSource = rooms;
        }

       
        private void AddRoom_Click_1(object sender, EventArgs e)
        {
            string roomName = RoomName.Text;
            string roomType = Type.Text;
            string roomFee = RoomFee.Text;
            string roomLocation = Location.Text;

            if (!string.IsNullOrWhiteSpace(roomName) && !string.IsNullOrWhiteSpace(roomType) && !string.IsNullOrWhiteSpace(roomFee) && !string.IsNullOrWhiteSpace(roomLocation))
            {
                roomFunctions.AddRoom(roomName, roomType, roomFee, roomLocation);
                ShowBookings(); 
                MessageBox.Show("Room added successfully.");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }
        }

        
        private void Update_Click(object sender, EventArgs e)
        {
            string roomName = RoomName.Text;
            string roomType = Type.Text;
            string roomFee = RoomFee.Text;
            string roomLocation = Location.Text;

            if (selectedRoomId != -1)
            {
                if (!string.IsNullOrWhiteSpace(roomName) && !string.IsNullOrWhiteSpace(roomType) && !string.IsNullOrWhiteSpace(roomFee) && !string.IsNullOrWhiteSpace(roomLocation))
                {
                    roomFunctions.UpdateRoom(selectedRoomId, roomName, roomType, roomFee, roomLocation);
                    ShowBookings(); 
                    MessageBox.Show("Room updated successfully.");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields.");
                }
            }
            else
            {
                MessageBox.Show("Please select a room to update.");
            }
        }

        
        private void ClearForm()
        {
            selectedRoomId = -1;
            RoomName.Clear();
            Type.Text = "";
            RoomFee.Clear();
            Location.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId != -1)
            {
                roomFunctions.DeleteRoom(selectedRoomId);
                ShowBookings();
                MessageBox.Show("Room deleted successfully.");
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please select a room to delete.");
            }
        }

        private void RoomsLists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = RoomsLists.Rows[e.RowIndex];
                selectedRoomId = Convert.ToInt32(row.Cells["RoomId"].Value);
                RoomName.Text = row.Cells["RoomName"].Value.ToString();
                Type.Text = row.Cells["RoomType"].Value.ToString();
                RoomFee.Text = row.Cells["RoomFee"].Value.ToString();
                Location.Text = row.Cells["RoomLocation"].Value.ToString();
            }
        }

        private void Seach_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = Search.Text.Trim();
            DataTable rooms = roomFunctions.SearchRooms(searchQuery);
            RoomsLists.DataSource = rooms;
        }

        
    }
}
