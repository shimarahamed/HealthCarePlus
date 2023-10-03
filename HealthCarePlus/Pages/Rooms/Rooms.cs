using HealthCarePlus.Classes;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCarePlus.Pages.Appointments;
using HealthCarePlus.Pages.Rooms;
using HealthCarePlus.Pages.Doctor;

namespace HealthCarePlus.Pages.Rooms
{
    public partial class Rooms : Form
    {
        private RoomFunctions roomFunctions;
        private int selectedRoomId = -1;

        public Rooms()
        {
            InitializeComponent();
            roomFunctions = new RoomFunctions();
            InitializeForm();
            ShowBookings();
        }


        private void ShowBookings()
        {
            DataTable roomBookings = roomFunctions.GetRoomBookings();
            RoomsList.DataSource = roomBookings;
        }
        private void InitializeForm()
        {
            DataTable patients = roomFunctions.GetPatients();
            foreach (DataRow row in patients.Rows)
            {
                string patientName = row["PatName"].ToString();
                PatientID.Items.Add(patientName);
            }

            DataTable rooms = roomFunctions.GetRooms();
            foreach (DataRow row in rooms.Rows)
            {
                string roomsName = row["RoomName"].ToString();
                RoomID.Items.Add(roomsName);
            }
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            string roomId = RoomID.Text;
            string selectedPatient = PatientID.Text;
            DateTime startDate = StartDate.Value;
            DateTime endDate = EndDate.Value;

            if (string.IsNullOrWhiteSpace(roomId) || string.IsNullOrWhiteSpace(selectedPatient))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string selectedRoomName = roomId;
            decimal roomFee = roomFunctions.GetRoomFee(selectedRoomName);

            // Calculate the total fee including the room fee
            decimal totalFee = roomFee;

            roomFunctions.BookRoom(roomId, selectedPatient, startDate, endDate, roomFee);
            MessageBox.Show("Room booked successfully.");
            ShowBookings();

            RoomID.Text = "";
            PatientID.Text = "";
            StartDate.Value = DateTime.Now;
            EndDate.Value = DateTime.Now;
        }

        private void SeachBookings_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchBookings.Text.Trim();
            DataTable dataTable = roomFunctions.SearchRoomBookings(searchQuery);
            RoomsList.DataSource = dataTable;
        }

        private void ModifyRooms_Click(object sender, EventArgs e)
        {
            NewRoom newRoomForm = new NewRoom();
            newRoomForm.ShowDialog();
            ShowBookings();
        }

        private void ModifyBooking_Click(object sender, EventArgs e)
        {
            string roomId = RoomID.Text;
            string selectedPatient = PatientID.Text;
            DateTime startDate = StartDate.Value;
            DateTime endDate = EndDate.Value;

            if (string.IsNullOrWhiteSpace(roomId) || string.IsNullOrWhiteSpace(selectedPatient))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (selectedRoomId != -1)
            {
                roomFunctions.UpdateBooking(selectedRoomId, roomId, selectedPatient, startDate, endDate);
                MessageBox.Show("Booking updated successfully.");

                RoomID.Text = "";
                PatientID.Text = "";
                StartDate.Value = DateTime.Now;
                EndDate.Value = DateTime.Now;
                selectedRoomId = -1;
            }
            else
            {
                MessageBox.Show("Please select a booking to update.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId != -1)
            {
                roomFunctions.DeleteBooking(selectedRoomId);
                ShowBookings();
                MessageBox.Show("Booking deleted successfully.");
                selectedRoomId = -1;
            }
            else
            {
                MessageBox.Show("Please select a booking to delete.");
            }
        }

        private void RoomsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = RoomsList.Rows[e.RowIndex];
                selectedRoomId = Convert.ToInt32(row.Cells["RoomId"].Value);
                RoomID.Text = row.Cells["RoomName"].Value.ToString();
                PatientID.Text = row.Cells["PatientName"].Value.ToString();
                StartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                EndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);

                string selectedRoomName = RoomID.Text;
                decimal roomFee = roomFunctions.GetRoomFee(selectedRoomName);
                RoomFeeLabel.Text = "Room Fee: $" + roomFee.ToString();
            }
            ShowBookings();
        }
    }
}
