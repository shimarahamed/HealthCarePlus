using HealthCarePlus.Pages;
using HealthCarePlus.Pages.Doctor;
using HealthCarePlus.Pages.Appointments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            loadform(new Patients());
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            loadform(new Doctors());
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            loadform(new Appointments());
        }
    }
}
