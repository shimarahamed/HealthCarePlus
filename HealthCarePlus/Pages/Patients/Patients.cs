using System;
using System.Data;
using System.Windows.Forms;
using HealthCarePlus.Classes;

namespace HealthCarePlus.Pages
{
    public partial class Patients : Form
    {
        PatientsFunctions Con;
        int Key = 0;

        public Patients()
        {
            InitializeComponent();
            Con = new PatientsFunctions();
            ShowPatients();
        }

        //to show patients data
        private void ShowPatients()
        {
            string Query = "SELECT * FROM PatientsTbl";
            PatientsList.DataSource = Con.GetData(Query);
        }
        

        // to add patient details to table
        private void PatientsAdd_Click(object sender, EventArgs e)
        {
            if (PatientNameBox.Text == "" || PatientPhone.Text == "" || PatientAddress.Text == "" || PatientGender.SelectedIndex == -1 || PatientBlood.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all data!");
            }
            else
            {
                string Patient = PatientNameBox.Text;
                string Phone = PatientPhone.Text;
                string Address = PatientAddress.Text;
                string Gender = PatientGender.SelectedItem.ToString();
                string Blood = PatientBlood.SelectedItem.ToString();
                string DOB = PatientDOB.Value.Date.ToString();
                Con.AddPatient(Patient, Phone, Address, Gender, Blood, DOB);
                ShowPatients();
                MessageBox.Show("Patient Details Added");
            }
        }
        //to populate data to the textbox
        private void PatientsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientNameBox.Text = PatientsList.SelectedRows[0].Cells[1].Value.ToString();
            PatientPhone.Text = PatientsList.SelectedRows[0].Cells[2].Value.ToString();
            PatientAddress.Text = PatientsList.SelectedRows[0].Cells[3].Value.ToString();
            PatientGender.Text = PatientsList.SelectedRows[0].Cells[4].Value.ToString();
            PatientBlood.Text = PatientsList.SelectedRows[0].Cells[5].Value.ToString();
            PatientDOB.Text = PatientsList.SelectedRows[0].Cells[6].Value.ToString();
            if (PatientNameBox.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatientsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }


        //update table
        private void PatientsUpdate_Click(object sender, EventArgs e)
        {
            if (PatientNameBox.Text == "" || PatientPhone.Text == "" || PatientAddress.Text == "" || PatientGender.SelectedIndex == -1 || PatientBlood.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all data!");
            }
            else
            {
                string Patient = PatientNameBox.Text;
                string Phone = PatientPhone.Text;
                string Address = PatientAddress.Text;
                string Gender = PatientGender.SelectedItem.ToString();
                string Blood = PatientBlood.SelectedItem.ToString();
                string DOB = PatientDOB.Value.Date.ToString();
                Con.UpdatePatient(Patient, Phone, Address, Gender, Blood, DOB, Key);
                ShowPatients();
                MessageBox.Show("Patient Details Updated");
            }
        }

        private void PatientsDel_Click(object sender, EventArgs e)
        {
            Con.DeletePatient(Key);
            ShowPatients();
            MessageBox.Show("Patient Details Deleted");
        }

        private void PatientsSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = PatientsSearch.Text.Trim();
            DataTable dataTable = Con.SearchPatients(searchQuery);
            PatientsList.DataSource = dataTable;
        }

        private void Patients_Load(object sender, EventArgs e)
        {

        }
    }
}
