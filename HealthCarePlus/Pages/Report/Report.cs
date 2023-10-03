using System;
using System.Data;
using System.Text;
using System.Windows.Forms;
using HealthCarePlus.Classes;

namespace HealthCarePlus.Pages.Report
{
    public partial class Report : Form
    {
        private ReportFunctions reportFunctions;

        public Report()
        {
            InitializeComponent();
            reportFunctions = new ReportFunctions(); 
            LoadCategories();
        }

        private void LoadCategories()
        {
            //to Load and Populate the CategoriesDropdown combo box
            DataTable tableNames = reportFunctions.GetTableNames();

            CategoriesDropdown.DataSource = tableNames;
            CategoriesDropdown.DisplayMember = "TableName";
            CategoriesDropdown.ValueMember = "TableName";
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            string selectedCategory = CategoriesDropdown.SelectedValue.ToString();
            DateTime fromDate = StartDate.Value;
            DateTime toDate = EndDate.Value;

            DataTable reportData = reportFunctions.GenerateReport(selectedCategory);
            RoomsList.DataSource = reportData;
        }

        //to get the data from datagridview and print data to excel
        private void Print_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable reportData = (DataTable)RoomsList.DataSource;
                StringBuilder csvContent = new StringBuilder();
                for (int i = 0; i < reportData.Columns.Count; i++)
                {
                    csvContent.Append(reportData.Columns[i].ColumnName);
                    if (i < reportData.Columns.Count - 1)
                    {
                        csvContent.Append(",");
                    }
                }
                csvContent.AppendLine();

                foreach (DataRow row in reportData.Rows)
                {
                    for (int i = 0; i < reportData.Columns.Count; i++)
                    {
                        csvContent.Append(row[i].ToString());
                        if (i < reportData.Columns.Count - 1)
                        {
                            csvContent.Append(",");
                        }
                    }
                    csvContent.AppendLine(); 
                }

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                    FileName = "ReportData.csv"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(saveFileDialog.FileName, csvContent.ToString(), Encoding.UTF8);

                    MessageBox.Show("Report data has been exported to CSV successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while exporting data to CSV: " + ex.Message);
            }
        }


    }
}
