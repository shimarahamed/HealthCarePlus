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

namespace HealthCarePlus.Pages.Doctor
{
    public partial class AddDoctor : Form
    {
        DoctorsFunctions Con;
        public AddDoctor()
        {
            InitializeComponent();
            Con = new DoctorsFunctions();
            
        }

        //add doctor details to the database
        private void AddRecord_Click(object sender, EventArgs e)
        {
            if (DrName.Text == "" || DrNIC.Text == "" || DrPhone.Text == "" || DrEmail.Text == "" || DrGender.SelectedIndex == -1 || DrQualification.SelectedIndex == -1 || DrAddress.Text == "" || DrSpecialization.SelectedIndex == -1 || DrTime.SelectedIndex == -1 || DrFee.Text == "")
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
                string DOB = DrDOB.Value.Date.ToString();
                string Qualification = DrQualification.SelectedItem.ToString();
                string Address = DrAddress.Text;
                string Specialization = DrSpecialization.SelectedItem.ToString();
                string Time = DrTime.SelectedItem.ToString();
                string Fee = DrFee.Text;
                
                string Query = "Insert into DoctorsTable values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')";
                Query = string.Format(Query, Doctor, NIC, Phone, EMail, Gender, DOB, Qualification, Address, Specialization, Time, Fee);
                Con.SetData(Query);
                MessageBox.Show("Doctor Details Added");
                this.Close();
            }
        }
    

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void backbuttondoctor_Click(object sender, EventArgs e)
        {

        }

        
    }
}
