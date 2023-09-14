using System;
using HealthCarePlus.Pages.Doctor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Pages.Doctor
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateDoctor updateDoctorForm = new UpdateDoctor();
            updateDoctorForm.Show();
        }

        private void AddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctorForm = new AddDoctor();
            addDoctorForm.Show();
        }
    }
}
