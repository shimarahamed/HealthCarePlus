namespace HealthCarePlus.Pages.Report
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.CategoriesDropdown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.patientname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.FromDate = new System.Windows.Forms.Label();
            this.EndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.GenerateReport = new Guna.UI2.WinForms.Guna2Button();
            this.Print = new Guna.UI2.WinForms.Guna2ImageButton();
            this.RoomsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ClearReport = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsList)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriesDropdown
            // 
            this.CategoriesDropdown.BackColor = System.Drawing.Color.Transparent;
            this.CategoriesDropdown.CustomizableEdges = customizableEdges1;
            this.CategoriesDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CategoriesDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesDropdown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoriesDropdown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CategoriesDropdown.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoriesDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CategoriesDropdown.ItemHeight = 30;
            this.CategoriesDropdown.Items.AddRange(new object[] {
            "Patients Report"});
            this.CategoriesDropdown.Location = new System.Drawing.Point(36, 119);
            this.CategoriesDropdown.Name = "CategoriesDropdown";
            this.CategoriesDropdown.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.CategoriesDropdown.Size = new System.Drawing.Size(233, 36);
            this.CategoriesDropdown.TabIndex = 71;
            this.CategoriesDropdown.TabStop = false;
            // 
            // patientname
            // 
            this.patientname.AutoSize = true;
            this.patientname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientname.Location = new System.Drawing.Point(36, 86);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(116, 25);
            this.patientname.TabIndex = 70;
            this.patientname.Text = "Select Details";
            this.patientname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(328, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 28);
            this.label5.TabIndex = 69;
            this.label5.Text = "Generate Report";
            // 
            // StartDate
            // 
            this.StartDate.Checked = true;
            this.StartDate.CustomizableEdges = customizableEdges3;
            this.StartDate.FillColor = System.Drawing.Color.Silver;
            this.StartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(36, 232);
            this.StartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.StartDate.MinDate = new System.DateTime(2023, 9, 10, 0, 0, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.StartDate.Size = new System.Drawing.Size(233, 36);
            this.StartDate.TabIndex = 74;
            this.StartDate.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            // 
            // FromDate
            // 
            this.FromDate.AutoSize = true;
            this.FromDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FromDate.Location = new System.Drawing.Point(36, 198);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(54, 25);
            this.FromDate.TabIndex = 73;
            this.FromDate.Text = "From";
            this.FromDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EndDate
            // 
            this.EndDate.Checked = true;
            this.EndDate.CustomizableEdges = customizableEdges5;
            this.EndDate.FillColor = System.Drawing.Color.Silver;
            this.EndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(36, 363);
            this.EndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EndDate.MinDate = new System.DateTime(2023, 9, 10, 0, 0, 0, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.EndDate.Size = new System.Drawing.Size(233, 36);
            this.EndDate.TabIndex = 76;
            this.EndDate.Value = new System.DateTime(2023, 10, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(36, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 25);
            this.label6.TabIndex = 75;
            this.label6.Text = "To";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenerateReport
            // 
            this.GenerateReport.BorderRadius = 10;
            this.GenerateReport.CustomizableEdges = customizableEdges7;
            this.GenerateReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerateReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerateReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerateReport.FillColor = System.Drawing.Color.DodgerBlue;
            this.GenerateReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateReport.ForeColor = System.Drawing.Color.White;
            this.GenerateReport.Location = new System.Drawing.Point(63, 465);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.GenerateReport.Size = new System.Drawing.Size(164, 37);
            this.GenerateReport.TabIndex = 77;
            this.GenerateReport.Text = "Generate Report";
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // Print
            // 
            this.Print.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.Image = global::HealthCarePlus.Properties.Resources.printer;
            this.Print.ImageOffset = new System.Drawing.Point(0, 0);
            this.Print.ImageRotate = 0F;
            this.Print.ImageSize = new System.Drawing.Size(40, 40);
            this.Print.Location = new System.Drawing.Point(44, 525);
            this.Print.Name = "Print";
            this.Print.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.ShadowDecoration.CustomizableEdges = customizableEdges9;
            this.Print.Size = new System.Drawing.Size(46, 41);
            this.Print.TabIndex = 78;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // RoomsList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.RoomsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RoomsList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RoomsList.ColumnHeadersHeight = 30;
            this.RoomsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.RoomsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomsList.Location = new System.Drawing.Point(301, 86);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.RowHeadersVisible = false;
            this.RoomsList.RowHeadersWidth = 62;
            this.RoomsList.RowTemplate.Height = 33;
            this.RoomsList.Size = new System.Drawing.Size(501, 476);
            this.RoomsList.TabIndex = 79;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomsList.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.RoomsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomsList.ThemeStyle.HeaderStyle.Height = 30;
            this.RoomsList.ThemeStyle.ReadOnly = false;
            this.RoomsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.RoomsList.ThemeStyle.RowsStyle.Height = 33;
            this.RoomsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ClearReport
            // 
            this.ClearReport.BorderRadius = 10;
            this.ClearReport.CustomizableEdges = customizableEdges10;
            this.ClearReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearReport.FillColor = System.Drawing.Color.Red;
            this.ClearReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearReport.ForeColor = System.Drawing.Color.White;
            this.ClearReport.Location = new System.Drawing.Point(112, 525);
            this.ClearReport.Name = "ClearReport";
            this.ClearReport.ShadowDecoration.CustomizableEdges = customizableEdges11;
            this.ClearReport.Size = new System.Drawing.Size(144, 37);
            this.ClearReport.TabIndex = 80;
            this.ClearReport.Text = "Clear Report";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 600);
            this.Controls.Add(this.ClearReport);
            this.Controls.Add(this.RoomsList);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.GenerateReport);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.CategoriesDropdown);
            this.Controls.Add(this.patientname);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            ((System.ComponentModel.ISupportInitialize)(this.RoomsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox CategoriesDropdown;
        private Label patientname;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DateTimePicker StartDate;
        private Label FromDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker EndDate;
        private Label label6;
        private Guna.UI2.WinForms.Guna2Button GenerateReport;
        private Guna.UI2.WinForms.Guna2ImageButton Print;
        private Guna.UI2.WinForms.Guna2DataGridView RoomsList;
        private Guna.UI2.WinForms.Guna2Button ClearReport;
    }
}