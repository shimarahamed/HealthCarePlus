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

namespace HealthCarePlus.Pages.Appointments
{
    public partial class Appointments : Form
    {
        public Appointments()
        {
            InitializeComponent();
        }

        private void NewAppointment_Click(object sender, EventArgs e)
        {
            NewAppointment newAppointmentForm = new NewAppointment();
            
            newAppointmentForm.Show();
        }
    }
}
