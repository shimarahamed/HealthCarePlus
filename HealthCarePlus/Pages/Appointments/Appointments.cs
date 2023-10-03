using HealthCarePlus.Pages.Doctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCarePlus.Classes;
using HealthCarePlus.Pages.Appointments;

namespace HealthCarePlus.Pages.Appointments
{
    public partial class Appointments : Form
    {
        private readonly AppointmentFunctions appointmentFunctions;

        public Appointments()
        {
            InitializeComponent();
            appointmentFunctions = new AppointmentFunctions();
            ShowAppointments();
        }

        //to show appointments in the DataGridView
        private void ShowAppointments()
        {
            DataTable appointmentsTable = appointmentFunctions.GetAppointments();
            AppointmentsList.DataSource = appointmentsTable;
        }

        private void NewAppointment_Click(object sender, EventArgs e)
        {
            NewAppointment newAppointmentForm = new NewAppointment();
            newAppointmentForm.ShowDialog();
            ShowAppointments();
        }

        private void DeleteAppointment_Click(object sender, EventArgs e)
        {
            if (AppointmentsList.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }
        private void Appointments_Load(object sender, EventArgs e)
        {

        }
        private void SearchAppointment_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = SearchAppointment.Text.Trim();
            DataTable dataTable = appointmentFunctions.SearchAppointments(searchQuery);
            AppointmentsList.DataSource = dataTable;
        }

        //to show the appointment data
        private void GenerateInvoice_Click(object sender, EventArgs e)
        {
            if (AppointmentsList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = AppointmentsList.SelectedRows[0];
                string patientName = selectedRow.Cells["PatName"].Value.ToString();
                string appointmentDate = selectedRow.Cells["AppointmentDate"].Value.ToString();
                decimal totalAmount = Convert.ToDecimal(selectedRow.Cells["TotalFee"].Value);
                string patientAge = selectedRow.Cells["PatientAge"].Value.ToString();
                string doctorName = selectedRow.Cells["DrName"].Value.ToString();
                string drSpecialization = selectedRow.Cells["DrSpecialization"].Value.ToString();
                string appointmentTime = selectedRow.Cells["AppointmentTime"].Value.ToString();
                decimal doctorFee = Convert.ToDecimal(selectedRow.Cells["DoctorFee"].Value);
                decimal hospitalFee = Convert.ToDecimal(selectedRow.Cells["HospitalFee"].Value);

                Invoice invoice = new Invoice();

                string invoiceContent = GenerateInvoiceContent(
                    patientName,
                    appointmentDate,
                    totalAmount,
                    patientAge,
                    doctorName,
                    drSpecialization,
                    appointmentTime,
                    doctorFee,
                    hospitalFee);

                invoice.DisplayInvoice(invoiceContent);

                invoice.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an appointment to generate an invoice.");
            }
        }

        //Invoice content adn printing structure
        private string GenerateInvoiceContent(string patientName, string appointmentDate, decimal totalAmount, string patientAge, string doctorName, string drSpecialization, string appointmentTime, decimal doctorFee, decimal hospitalFee)
        {
            string invoiceContent = "----------------------------------------------------\n";
            invoiceContent += "                       Health Care Plus              \n";
            invoiceContent += "                           INVOICE                   \n";
            invoiceContent += "-----------------------------------------------------\n";
            invoiceContent += $"Patient Name: {patientName}\n";
            invoiceContent += $"Patient Age: {patientAge}\n";
            invoiceContent += $"Doctor Name: {doctorName}\n";
            invoiceContent += $"Specialization: {drSpecialization}\n";
            invoiceContent += $"Appointment Date: {appointmentDate}\n";
            invoiceContent += $"Appointment Time: {appointmentTime}\n";
            invoiceContent += "----------------------------------------------------\n";
            invoiceContent += $"Doctor Fee: Rs. {doctorFee.ToString("0.00")}\n";
            invoiceContent += $"Hospital Fee: Rs. {hospitalFee.ToString("0.00")}\n";
            invoiceContent += "----------------------------------------------------\n";
            invoiceContent += $"Total Amount: Rs. {totalAmount.ToString("0.00")}\n";
            invoiceContent += "----------------------------------------------------\n";
            invoiceContent += "                   THANKS FOR VISITING              \n";
            invoiceContent += "----------------------------------------------------\n";


            return invoiceContent;
        }

    }
}
