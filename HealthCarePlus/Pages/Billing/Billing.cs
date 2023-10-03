using HealthCarePlus.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Pages.Billing
{
    public partial class Billing : Form
    {
        private BillingFunctions billingFunctions;
        private DataTable roomsTable;
        private DataTable appointmentsTable;
        private PrintDocument printDocument;
        public Billing()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            billingFunctions = new BillingFunctions();
            LoadPatients();
            InitializeAppointmentsList(); 
            InitializeRoomsList();
        }
        // to load thepatients details according to the name
        private void LoadPatients()
        {
            DataTable patientsTable = billingFunctions.GetPatients();
            PatientSelect.DataSource = patientsTable;
            PatientSelect.DisplayMember = "PatName";
            PatientSelect.ValueMember = "PatName";
        }

        private void InitializeAppointmentsList()
        {
            appointmentsTable = new DataTable();
            AppointmentsList.DataSource = appointmentsTable; 
        }

        private void InitializeRoomsList()
        {
            roomsTable = new DataTable();
            RoomsList.DataSource = roomsTable;
        }

        //patient select and load room detais and appointment details
        private void PatientSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPatientName = PatientSelect.SelectedValue.ToString();

            appointmentsTable = billingFunctions.GetAppointments(selectedPatientName);
            AppointmentsList.DataSource = appointmentsTable;

            roomsTable = billingFunctions.GetRooms(selectedPatientName);
            RoomsList.DataSource = roomsTable;
        }

        
        //to generate invoice in the text box with all th egiven details 
        private void GenerateInvoice_Click(object sender, EventArgs e)
{
    if (AppointmentsList.SelectedRows.Count > 0 || RoomsList.SelectedRows.Count > 0)
    {
        StringBuilder invoiceContent = new StringBuilder();

        string patientName = PatientSelect.SelectedValue.ToString();

        invoiceContent.AppendLine("-------------------------------------------------");
        invoiceContent.AppendLine("                    Health Care Plus              ");
        invoiceContent.AppendLine("                        INVOICE                   ");
        invoiceContent.AppendLine("-------------------------------------------------");
        invoiceContent.AppendLine($"  Patient Name: {patientName}");
        invoiceContent.AppendLine("-------------------------------------------------");

        // Check if there are selected rows in the AppointmentsList
        if (AppointmentsList.SelectedRows.Count > 0)
        {
            foreach (DataGridViewRow row in AppointmentsList.SelectedRows)
            {
                string drName = row.Cells["DrName"].Value?.ToString(); // Use ?. to handle null values
                decimal doctorFee = Convert.ToDecimal(row.Cells["DoctorFee"].Value ?? 0); // Use ?? to provide a default value
                decimal hospitalFee = Convert.ToDecimal(row.Cells["HospitalFee"].Value ?? 0);

                invoiceContent.AppendLine($"  Appointment with {drName}");
                invoiceContent.AppendLine($"  Doctor Fee: Rs. {doctorFee.ToString("0.00")}");
                invoiceContent.AppendLine($"  Hospital Fee: Rs. {hospitalFee.ToString("0.00")}");
                invoiceContent.AppendLine("                                             ");
            }
        }

        // Check if there are selected rows in the RoomsList
        if (RoomsList.SelectedRows.Count > 0)
        {
            foreach (DataGridViewRow row in RoomsList.SelectedRows)
            {
                string roomId = row.Cells["RoomName"].Value?.ToString(); // Use ?. to handle null values
                decimal roomFee = Convert.ToDecimal(row.Cells["RoomFee"].Value ?? 0); // Use ?? to provide a default value

                invoiceContent.AppendLine($"  Room: {roomId}");
                invoiceContent.AppendLine($"  Room Fee: Rs. {roomFee.ToString("0.00")}");
                invoiceContent.AppendLine("-------------------------------------------------");
            }
        }

        decimal totalAmount = CalculateTotalAmount();
        invoiceContent.AppendLine($"  Total Amount: Rs. {totalAmount.ToString("0.00")}");
        invoiceContent.AppendLine("-------------------------------------------------");
        invoiceContent.AppendLine("             THANKS FOR VISITING                  ");
        invoiceContent.AppendLine("-------------------------------------------------");

        InvoiceTextBox.Text = invoiceContent.ToString();
        Total.Text = $"Rs. {totalAmount.ToString("0.00")}";
    }
    else
    {
        MessageBox.Show("Please select at least one appointment or room to generate an invoice.");
    }
    
    CalculateTotalAmount();
}


        //to calculate total amount with Doctor fee, hospital fee, Room fee
        private decimal CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in AppointmentsList.SelectedRows)
            {
                decimal doctorFee = Convert.ToDecimal(row.Cells["DoctorFee"].Value);
                decimal hospitalFee = Convert.ToDecimal(row.Cells["HospitalFee"].Value);
                totalAmount += doctorFee + hospitalFee;
            }

            foreach (DataGridViewRow row in RoomsList.SelectedRows)
            {
                decimal roomFee = Convert.ToDecimal(row.Cells["RoomFee"].Value);
                totalAmount += roomFee;
            }

            return totalAmount;
        }

        private void ClearInvoice_Click(object sender, EventArgs e)
        {
            InvoiceTextBox.Clear();
        }

        //Print Invoice as pdf
        private void Print_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrinterSettings = printDialog.PrinterSettings;
                printDocument.Print();
            }
        }

        private int charIndexToPrint = 0;
        private int linesPrinted = 0;

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            string textToPrint = InvoiceTextBox.Text;
            Font printFont = new Font("Courier New", 10);
            SolidBrush printBrush = new SolidBrush(Color.Black);
            RectangleF printArea = new RectangleF(e.MarginBounds.Left, e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);

            int linesPerPage = (int)(e.MarginBounds.Height / printFont.GetHeight(e.Graphics));
            while (linesPrinted < InvoiceTextBox.Lines.Length)
            {
                int startIndex = charIndexToPrint;
                int endIndex = startIndex + textToPrint.Length - 1;

                if (endIndex >= textToPrint.Length)
                {
                    endIndex = textToPrint.Length - 1;
                }

                string pageToPrint = textToPrint.Substring(startIndex, endIndex - startIndex + 1);
                e.Graphics.DrawString(pageToPrint, printFont, printBrush, printArea);
                charIndexToPrint = endIndex + 1;
                linesPrinted++;
                if (charIndexToPrint < textToPrint.Length)
                {
                    e.HasMorePages = true;
                    return;
                }
                else
                {
                    e.HasMorePages = false;
                }
            }
        }
    }
}
