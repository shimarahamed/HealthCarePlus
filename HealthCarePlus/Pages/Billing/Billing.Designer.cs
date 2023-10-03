namespace HealthCarePlus.Pages.Billing
{
    partial class Billing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.label5 = new System.Windows.Forms.Label();
            this.PatientSelect = new Guna.UI2.WinForms.Guna2ComboBox();
            this.patientname = new System.Windows.Forms.Label();
            this.AppointmentsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.Print = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.RoomsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.InvoiceTextBox = new System.Windows.Forms.RichTextBox();
            this.Total = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(392, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Billing";
            // 
            // PatientSelect
            // 
            this.PatientSelect.BackColor = System.Drawing.Color.Transparent;
            this.PatientSelect.CustomizableEdges = customizableEdges1;
            this.PatientSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PatientSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PatientSelect.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientSelect.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatientSelect.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatientSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PatientSelect.ItemHeight = 30;
            this.PatientSelect.Location = new System.Drawing.Point(40, 109);
            this.PatientSelect.Name = "PatientSelect";
            this.PatientSelect.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.PatientSelect.Size = new System.Drawing.Size(233, 36);
            this.PatientSelect.TabIndex = 70;
            this.PatientSelect.SelectedIndexChanged += new System.EventHandler(this.PatientSelect_SelectedIndexChanged);
            // 
            // patientname
            // 
            this.patientname.AutoSize = true;
            this.patientname.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.patientname.Location = new System.Drawing.Point(40, 76);
            this.patientname.Name = "patientname";
            this.patientname.Size = new System.Drawing.Size(117, 25);
            this.patientname.TabIndex = 69;
            this.patientname.Text = "Patient Name";
            this.patientname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AppointmentsList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AppointmentsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AppointmentsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AppointmentsList.ColumnHeadersHeight = 30;
            this.AppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AppointmentsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.AppointmentsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AppointmentsList.Location = new System.Drawing.Point(40, 205);
            this.AppointmentsList.Name = "AppointmentsList";
            this.AppointmentsList.RowHeadersVisible = false;
            this.AppointmentsList.RowHeadersWidth = 62;
            this.AppointmentsList.RowTemplate.Height = 33;
            this.AppointmentsList.Size = new System.Drawing.Size(353, 87);
            this.AppointmentsList.TabIndex = 71;
            this.AppointmentsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AppointmentsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AppointmentsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AppointmentsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AppointmentsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AppointmentsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AppointmentsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AppointmentsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AppointmentsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AppointmentsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppointmentsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AppointmentsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AppointmentsList.ThemeStyle.HeaderStyle.Height = 30;
            this.AppointmentsList.ThemeStyle.ReadOnly = false;
            this.AppointmentsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AppointmentsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AppointmentsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppointmentsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AppointmentsList.ThemeStyle.RowsStyle.Height = 33;
            this.AppointmentsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AppointmentsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(40, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Select Appointment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GenerateInvoice
            // 
            this.GenerateInvoice.BorderRadius = 10;
            this.GenerateInvoice.CustomizableEdges = customizableEdges3;
            this.GenerateInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GenerateInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GenerateInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GenerateInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GenerateInvoice.FillColor = System.Drawing.Color.DodgerBlue;
            this.GenerateInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateInvoice.ForeColor = System.Drawing.Color.White;
            this.GenerateInvoice.Location = new System.Drawing.Point(483, 541);
            this.GenerateInvoice.Name = "GenerateInvoice";
            this.GenerateInvoice.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.GenerateInvoice.Size = new System.Drawing.Size(164, 37);
            this.GenerateInvoice.TabIndex = 74;
            this.GenerateInvoice.Text = "Generate Invoice";
            this.GenerateInvoice.Click += new System.EventHandler(this.GenerateInvoice_Click);
            // 
            // Print
            // 
            this.Print.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.Image = global::HealthCarePlus.Properties.Resources.printer;
            this.Print.ImageOffset = new System.Drawing.Point(0, 0);
            this.Print.ImageRotate = 0F;
            this.Print.ImageSize = new System.Drawing.Size(40, 40);
            this.Print.Location = new System.Drawing.Point(425, 539);
            this.Print.Name = "Print";
            this.Print.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.ShadowDecoration.CustomizableEdges = customizableEdges5;
            this.Print.Size = new System.Drawing.Size(46, 41);
            this.Print.TabIndex = 75;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(40, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearInvoice
            // 
            this.ClearInvoice.BorderRadius = 10;
            this.ClearInvoice.CustomizableEdges = customizableEdges6;
            this.ClearInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearInvoice.FillColor = System.Drawing.Color.Red;
            this.ClearInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearInvoice.ForeColor = System.Drawing.Color.White;
            this.ClearInvoice.Location = new System.Drawing.Point(658, 541);
            this.ClearInvoice.Name = "ClearInvoice";
            this.ClearInvoice.ShadowDecoration.CustomizableEdges = customizableEdges7;
            this.ClearInvoice.Size = new System.Drawing.Size(144, 37);
            this.ClearInvoice.TabIndex = 78;
            this.ClearInvoice.Text = "Clear Invoice";
            this.ClearInvoice.Click += new System.EventHandler(this.ClearInvoice_Click);
            // 
            // RoomsList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.RoomsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.RoomsList.ColumnHeadersHeight = 30;
            this.RoomsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RoomsList.DefaultCellStyle = dataGridViewCellStyle6;
            this.RoomsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.RoomsList.Location = new System.Drawing.Point(40, 351);
            this.RoomsList.Name = "RoomsList";
            this.RoomsList.RowHeadersVisible = false;
            this.RoomsList.RowHeadersWidth = 62;
            this.RoomsList.RowTemplate.Height = 33;
            this.RoomsList.Size = new System.Drawing.Size(353, 87);
            this.RoomsList.TabIndex = 71;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomsList.ThemeStyle.BackColor = System.Drawing.Color.White;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(40, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Select Room";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InvoiceTextBox
            // 
            this.InvoiceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvoiceTextBox.Location = new System.Drawing.Point(426, 76);
            this.InvoiceTextBox.Name = "InvoiceTextBox";
            this.InvoiceTextBox.Size = new System.Drawing.Size(377, 442);
            this.InvoiceTextBox.TabIndex = 79;
            this.InvoiceTextBox.Text = "";
            // 
            // Total
            // 
            this.Total.CustomizableEdges = customizableEdges8;
            this.Total.DefaultText = "";
            this.Total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Total.Location = new System.Drawing.Point(40, 510);
            this.Total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Total.Name = "Total";
            this.Total.PasswordChar = '\0';
            this.Total.PlaceholderText = "Total Amount";
            this.Total.SelectedText = "";
            this.Total.ShadowDecoration.CustomizableEdges = customizableEdges9;
            this.Total.Size = new System.Drawing.Size(233, 34);
            this.Total.TabIndex = 80;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(840, 600);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.InvoiceTextBox);
            this.Controls.Add(this.ClearInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.GenerateInvoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomsList);
            this.Controls.Add(this.AppointmentsList);
            this.Controls.Add(this.PatientSelect);
            this.Controls.Add(this.patientname);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoomsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox PatientSelect;
        private Label patientname;
        private Guna.UI2.WinForms.Guna2DataGridView AppointmentsList;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button GenerateInvoice;
        private Guna.UI2.WinForms.Guna2ImageButton Print;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button ClearInvoice;
        private Guna.UI2.WinForms.Guna2DataGridView RoomsList;
        private Label label3;
        private RichTextBox InvoiceTextBox;
        private Guna.UI2.WinForms.Guna2TextBox Total;
    }
}