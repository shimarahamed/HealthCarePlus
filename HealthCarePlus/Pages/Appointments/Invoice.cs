using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace HealthCarePlus.Pages.Appointments
{
    public partial class Invoice : Form
    {

        private PrintDocument printDocument;
        public Invoice()
        {
            InitializeComponent();
            printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }

        //to show invoice content from appointments table
        public void DisplayInvoice(string invoiceContent)
        {
            InvoiceTextBox.Text = invoiceContent;
        }


        //to initiate print document
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


        private void ClearInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
