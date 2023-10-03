using System;
using HealthCarePlus.Pages.Doctor;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HealthCarePlus.Classes;

namespace HealthCarePlus.Pages.Doctor
{
    public partial class Doctors : Form
    {
        DoctorsFunctions Con;
        private DataRow selectedDoctor;
        public Doctors()
        {
            InitializeComponent();
            Con = new DoctorsFunctions();
            ShowDoctors();
        }
        //load doctors data
        private void ShowDoctors()
        {
            string Query = "Select * FROM DoctorsTable";
            DoctorsList.DataSource = Con.GetData(Query);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (DoctorsList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DoctorsList.SelectedRows[0];
                selectedDoctor = ((DataRowView)selectedRow.DataBoundItem).Row;
                UpdateDoctor updateDoctorForm = new UpdateDoctor(selectedDoctor);
                updateDoctorForm.Show();

            }
            else
            {
                MessageBox.Show("Please select a doctor to update.");
            }
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctorForm = new AddDoctor();
            addDoctorForm.Show();
            ShowDoctors();
        }

        private void SeachDoctor_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = DoctorsList.Text.Trim();
            DataTable dataTable = Con.SearchDoctors(searchQuery);
            DoctorsList.DataSource = dataTable;
        }

        private void DoctorsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DeleteDoctor_Click(object sender, EventArgs e)
        {
            if (DoctorsList.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this doctor's details?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int doctorId = Convert.ToInt32(DoctorsList.SelectedRows[0].Cells["DoctorId"].Value);
                    int rowsDeleted = Con.DeleteDoctor(doctorId);

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("Doctor details deleted successfully.");
                        ShowDoctors(); 
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete doctor details.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a doctor to delete.");
            }
        }
    }
}
