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

namespace HealthCarePlus.Pages.Appointments
{
    public partial class NewAppointment : Form
    {
        private readonly AppointmentFunctions appointmentFunctions;

        public NewAppointment()
        {
            InitializeComponent();
            appointmentFunctions = new AppointmentFunctions();
            LoadPatientsAndSpecializations();
            LoadDoctors();
            NewAppointment_Load();
        }

        //to show the fixed amount as hospital fee
        private void NewAppointment_Load()
        {
            
            HospitalFee.Text = "1000"; 
        }

        //load patient data
        private void LoadPatientsAndSpecializations()
        {
            LoadDoctors();

            DataTable patientsTable = appointmentFunctions.GetPatients();
            foreach (DataRow row in patientsTable.Rows)
            {
                PatientDropdown.Items.Add(row["PatName"].ToString());
            }

            DataTable specializationsTable = appointmentFunctions.GetSpecializations();
            foreach (DataRow row in specializationsTable.Rows)
            {
                SpecializationDropdown.Items.Add(row["DrSpecialization"].ToString());
            }
        }

        //load doctor data
        private void LoadDoctors()
        {
            string selectedSpecialization = SpecializationDropdown.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedSpecialization))
            {
                DataTable doctorsTable = appointmentFunctions.GetDoctorsBySpecialization(selectedSpecialization);
                DoctorDropdown.Items.Clear();
                foreach (DataRow row in doctorsTable.Rows)
                {
                    string doctorName = row["DrName"].ToString();
                    DoctorDropdown.Items.Add(doctorName);
                }

                DoctorDropdown.Enabled = true;
            }
        }

        //to book appointment
        private void MakeAppointment_Click(object sender, EventArgs e)
        {
            string selectedPatient = PatientDropdown.SelectedItem?.ToString();
            string selectedDoctor = DoctorDropdown.SelectedItem?.ToString();
            string drSpecialization = SpecializationDropdown.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(selectedPatient) || string.IsNullOrWhiteSpace(selectedDoctor) || AppointmentDate.Value == null || string.IsNullOrWhiteSpace(drSpecialization))
            {
                MessageBox.Show("Please select a patient, doctor, specialization, and appointment date.");
                return;
            }

            DateTime appointmentDateTime = AppointmentDate.Value;

            int patientAge = 0;
            if (!string.IsNullOrWhiteSpace(PatientAge.Text))
            {
                if (int.TryParse(PatientAge.Text, out patientAge))
                {
                    if (patientAge < 0)
                    {
                        MessageBox.Show("Please enter a valid age.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid age.");
                    return;
                }
            }


            string appointmentTime = AppointmentTime.SelectedItem?.ToString();

            decimal doctorFee = 0;
            if (!string.IsNullOrWhiteSpace(selectedDoctor))
            {
                doctorFee = appointmentFunctions.GetDoctorFee(selectedDoctor);
            }

            decimal hospitalFee = 0;
            if (!string.IsNullOrWhiteSpace(HospitalFee.Text))
            {
                if (!decimal.TryParse(HospitalFee.Text, out hospitalFee))
                {
                    MessageBox.Show("Please enter a valid hospital fee.");
                    return;
                }
            }

            decimal totalFee = doctorFee + hospitalFee;

            appointmentFunctions.AddAppointment(
                selectedPatient,
                patientAge,
                selectedDoctor,
                drSpecialization,
                appointmentDateTime,
                appointmentTime,
                doctorFee,
                hospitalFee,
                totalFee
            );

            MessageBox.Show("Appointment created successfully.");

            PatientDropdown.SelectedIndex = -1;
            SpecializationDropdown.SelectedIndex = -1;
            DoctorDropdown.Items.Clear();
            AppointmentDate.Value = DateTime.Now;

            PatientAge.Clear();
            AppointmentTime.SelectedIndex = -1;
            HospitalFee.Clear();
            TotalFee.Clear(); 
        }
        //patient age caluclation
        private int CalculatePatientAge(DateTime dob)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dob.Year;
            if (currentDate.Month < dob.Month || (currentDate.Month == dob.Month && currentDate.Day < dob.Day))
            {
                age--;
            }
            return age;
        }

        //patient name dropdown and select age
        private void PatientDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPatient = PatientDropdown.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedPatient))
            {
                DataTable patientsTable = appointmentFunctions.GetPatients();
                DataRow[] selectedPatientRows = patientsTable.Select($"PatName = '{selectedPatient}'");

                if (selectedPatientRows.Length > 0)
                {
                    DateTime dob;
                    if (DateTime.TryParse(selectedPatientRows[0]["PatDOB"].ToString(), out dob))
                    {
                        int patientAge = CalculatePatientAge(dob);
                        PatientAge.Text = patientAge.ToString();
                    }
                }
            }
        }
        //doctor dropdown according to the specilization
        private void DoctorDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDoctor = DoctorDropdown.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedDoctor))
            {
                DoctorDropdown.Text = selectedDoctor;
                decimal doctorFee = appointmentFunctions.GetDoctorFee(selectedDoctor);
                DoctorFee.Text = doctorFee.ToString();
                CalculateTotalFee();
            }
        }

        //calculate total fee according to the Hospital fee, doctor fee and room fee
        private void CalculateTotalFee()
        {
            if (decimal.TryParse(HospitalFee.Text, out decimal hospitalFee) &&
                decimal.TryParse(DoctorFee.Text, out decimal doctorFee))
            {
                decimal totalFee = hospitalFee + doctorFee;
                TotalFee.Text = totalFee.ToString();
            }
        }

        private void SpecializationDropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedSpecialization = SpecializationDropdown.SelectedItem?.ToString();
            if (!string.IsNullOrWhiteSpace(selectedSpecialization))
            {
                DataTable doctorsTable = appointmentFunctions.GetDoctorsBySpecialization(selectedSpecialization);
                DoctorDropdown.Items.Clear();
                foreach (DataRow row in doctorsTable.Rows)
                {
                    DoctorDropdown.Items.Add(row["DrName"].ToString());
                }
            }
        }
    }
}
