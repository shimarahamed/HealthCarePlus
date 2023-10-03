using HealthCarePlus.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace HealthCarePlus.Pages.Resources
{
    public partial class Resources : Form
    {
        private ResourcesFunctions Con;
        private int Key = 0;

        public Resources()
        {
            InitializeComponent();
            Con = new ResourcesFunctions();
            ShowResources();
        }

        private void ShowResources()
        {
            string Query = "SELECT * FROM ResourcesTbl";
            ResourcesList.DataSource = Con.GetResourceData(Query);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ResourceNameBox.Text == "" || SN.Text == "" || Location.Text == "" || Type.Text == "")
            {
                MessageBox.Show("Please fill all data!");
            }
            else
            {
                string ResourceName = ResourceNameBox.Text;
                string SerialNumber = SN.Text;
                string LocationText = Location.Text;
                string DateText = Date.Value.Date.ToString("yyyy-MM-dd");
                string TypeText = Type.Text;

                Con.AddResource(ResourceName, SerialNumber, LocationText, DateText, TypeText);
                ShowResources();
                MessageBox.Show("Resource Details Added");
            }
        }

        

        private void Update_Click_1(object sender, EventArgs e)
        {
            if (ResourceNameBox.Text == "" || SN.Text == "" || Location.Text == "" || Type.Text == "")
            {
                MessageBox.Show("Please fill all data!");
            }
            else
            {
                string ResourceName = ResourceNameBox.Text;
                string SerialNumber = SN.Text;
                string LocationText = Location.Text;
                string DateText = Date.Value.Date.ToString("yyyy-MM-dd");
                string TypeText = Type.Text;

                if (int.TryParse(Key.ToString(), out int resourceId)) // Parse Key to int
                {
                    Con.UpdateResource(resourceId, ResourceName, SerialNumber, LocationText, DateText, TypeText);
                    ShowResources();
                    MessageBox.Show("Resource Details Updated");
                }
                else
                {
                    MessageBox.Show("Invalid resource ID.");
                }
            }
        }


        private void Delete_Click_1(object sender, EventArgs e)
        {
            Con.DeleteResource(Key);
            ShowResources();
            MessageBox.Show("Resource Details Deleted");
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = Search.Text.Trim();
            DataTable dataTable = Con.SearchResources(searchQuery);
            ResourcesList.DataSource = dataTable;
        }

        private void ResourcesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ResourceNameBox.Text = ResourcesList.SelectedRows[0].Cells[1].Value.ToString();
            SN.Text = ResourcesList.SelectedRows[0].Cells[2].Value.ToString();
            Location.Text = ResourcesList.SelectedRows[0].Cells[3].Value.ToString();
            Date.Value = Convert.ToDateTime(ResourcesList.SelectedRows[0].Cells[4].Value);
            Type.Text = ResourcesList.SelectedRows[0].Cells[5].Value.ToString();

            if (ResourceNameBox.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ResourcesList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
