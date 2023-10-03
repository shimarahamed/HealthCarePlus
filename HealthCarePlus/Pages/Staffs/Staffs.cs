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

namespace HealthCarePlus.Pages.Staffs
{
    public partial class Staffs : Form
    {
        public Staffs()
        {
            InitializeComponent();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            AddStaffs addStaffsForm = new AddStaffs();
            addStaffsForm.Show();
        }
    }
}
