using HealthCarePlus.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace HealthCarePlus.Pages.Doctor
{
    public partial class UpdateDoctor : Form
    {
        private DoctorsFunctions Con;
        private DataRow selectedDoctor; 

        public UpdateDoctor(DataRow doctor)
        {
            InitializeComponent();
            Con = new DoctorsFunctions();
            selectedDoctor = doctor; 
            InitializeForm();
        }

        private void InitializeForm()
        {
            DrName.Text = selectedDoctor["DrName"].ToString();
            DrNIC.Text = selectedDoctor["DrNIC"].ToString();
            DrPhone.Text = selectedDoctor["DrPhone"].ToString();
            DrEmail.Text = selectedDoctor["DrEmail"].ToString();
            DrGender.SelectedItem = selectedDoctor["DrGender"].ToString();
            DrDOB.Value = DateTime.Parse(selectedDoctor["DrDOB"].ToString());
            DrQualification.SelectedItem = selectedDoctor["DrQualification"].ToString();
            DrAddress.Text = selectedDoctor["DrAddress"].ToString();
            DrSpecialization.SelectedItem = selectedDoctor["DrSpecialization"].ToString();
            DrTime.SelectedItem = selectedDoctor["DrTime"].ToString();
        }

        private void UpdateRecord_Click(object sender, EventArgs e)
        {
            if (DrName.Text == "" || DrNIC.Text == "" || DrPhone.Text == "" || DrEmail.Text == "" || DrGender.SelectedIndex == -1 || DrQualification.SelectedIndex == -1 || DrAddress.Text == "" || DrSpecialization.SelectedIndex == -1 || DrTime.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all data!");
            }
            else
            {
                string Doctor = DrName.Text;
                string NIC = DrNIC.Text;
                string Phone = DrPhone.Text;
                string EMail = DrEmail.Text;
                string Gender = DrGender.SelectedItem.ToString();
                string DOB = DrDOB.Value.Date.ToString("yyyy-MM-dd");
                string Qualification = DrQualification.SelectedItem.ToString();
                string Address = DrAddress.Text;
                string Specialization = DrSpecialization.SelectedItem.ToString();
                string Time = DrTime.SelectedItem.ToString();

                string Query = $"UPDATE DoctorsTable SET DrName = '{Doctor}', DrNIC = '{NIC}', DrPhone = '{Phone}', DrEmail = '{EMail}', DrGender = '{Gender}', DrDOB = '{DOB}', DrQualification = '{Qualification}', DrAddress = '{Address}', DrSpecialization = '{Specialization}', DrTime = '{Time}' WHERE DoctorId = {selectedDoctor["DoctorId"]}";
                int rowsUpdated = Con.SetData(Query);
                if (rowsUpdated > 0)
                {
                    MessageBox.Show("Doctor Details Updated");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update doctor details.");
                }
            }
        }
    }
}
