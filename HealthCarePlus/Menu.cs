using HealthCarePlus.Pages;
using HealthCarePlus.Pages.Doctor;
using HealthCarePlus.Pages.Rooms;
using HealthCarePlus.Pages.Menu;
using HealthCarePlus.Pages.Appointments;
using HealthCarePlus.Pages.Resources;
using HealthCarePlus.Pages.Billing;
using HealthCarePlus.Pages.Staffs;
using HealthCarePlus.Pages.Report;
using HealthCarePlus.Pages.Users;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HealthCarePlus.Pages.Rooms;

namespace HealthCarePlus
{
    public partial class Menu : Form
    {
        private bool isDragging = false;
        private Point lastMouseDownLocation; 
        
        public Menu()
        {
            InitializeComponent();
            DashboardButton_Click(this, EventArgs.Empty);
        }

        //to load another form in the same form
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

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            loadform(new Dashboard());
        }

        private void RoomsButton_Click(object sender, EventArgs e)
        {
            loadform(new Rooms());
        }
        private void ResourcesButton_Click(object sender, EventArgs e)
        {
            loadform(new Resources());
        }

        private void StaffsButton_Click(object sender, EventArgs e)
        {
            loadform(new Staffs());
        }
        private void BillingButton_Click(object sender, EventArgs e)
        {
            loadform(new Billing());
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            loadform(new Users());
        }
        private void ReportButton_Click(object sender, EventArgs e)
        {
            loadform(new Report());
        }
        private void Menu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMouseDownLocation = e.Location;
            }
        }


        //move the system
        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentMouseLocation = e.Location;
                int deltaX = currentMouseLocation.X - lastMouseDownLocation.X;
                int deltaY = currentMouseLocation.Y - lastMouseDownLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void Menu_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Close();

            login Login = new login();
            Login.Show();
        }

        
    }
}
