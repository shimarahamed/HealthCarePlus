using HealthCarePlus.Pages;
using HealthCarePlus.Pages.Appointments;
using HealthCarePlus.Pages.Billing;
using HealthCarePlus.Pages.Menu;
using HealthCarePlus.Pages.Rooms;
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
    public partial class ReceptionistMenu : Form
    {
        public ReceptionistMenu()
        {
            InitializeComponent();
            DashboardButton_Click(this, EventArgs.Empty);
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
        private void DashboardButton_Click(object sender, EventArgs e)
        {
            loadform(new ReceptionistDashboard());
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            loadform(new Patients());
        }

        private void AppointmentsButton_Click(object sender, EventArgs e)
        {
            loadform(new Appointments());
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            loadform(new Rooms());
        }

        private void BillingButton_Click(object sender, EventArgs e)
        {
            loadform(new Billing());
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();

            login Login = new login();
            Login.Show();
        }
    }
}
