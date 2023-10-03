namespace HealthCarePlus.Pages.Staffs
{
    partial class Staffs
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.AddStaff = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DoctorsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.DeleteDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateDoctor = new Guna.UI2.WinForms.Guna2Button();
            this.Searchbutton = new Guna.UI2.WinForms.Guna2Button();
            this.SeachDoctor = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStaff
            // 
            this.AddStaff.BorderRadius = 10;
            this.AddStaff.CustomizableEdges = customizableEdges1;
            this.AddStaff.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddStaff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddStaff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddStaff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddStaff.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(206)))), ((int)(((byte)(107)))));
            this.AddStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddStaff.ForeColor = System.Drawing.Color.White;
            this.AddStaff.Location = new System.Drawing.Point(475, 84);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.AddStaff.Size = new System.Drawing.Size(102, 37);
            this.AddStaff.TabIndex = 33;
            this.AddStaff.Text = "Add";
            this.AddStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(369, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "Staffs Details";
            // 
            // DoctorsList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DoctorsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorsList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DoctorsList.ColumnHeadersHeight = 30;
            this.DoctorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DoctorsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorsList.Location = new System.Drawing.Point(33, 153);
            this.DoctorsList.Name = "DoctorsList";
            this.DoctorsList.RowHeadersVisible = false;
            this.DoctorsList.RowHeadersWidth = 62;
            this.DoctorsList.RowTemplate.Height = 33;
            this.DoctorsList.Size = new System.Drawing.Size(777, 418);
            this.DoctorsList.TabIndex = 31;
            this.DoctorsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DoctorsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DoctorsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DoctorsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DoctorsList.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.DoctorsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DoctorsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DoctorsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DoctorsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DoctorsList.ThemeStyle.HeaderStyle.Height = 30;
            this.DoctorsList.ThemeStyle.ReadOnly = false;
            this.DoctorsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DoctorsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorsList.ThemeStyle.RowsStyle.Height = 33;
            this.DoctorsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DeleteDoctor
            // 
            this.DeleteDoctor.BorderRadius = 10;
            this.DeleteDoctor.CustomizableEdges = customizableEdges3;
            this.DeleteDoctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteDoctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteDoctor.FillColor = System.Drawing.Color.Red;
            this.DeleteDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteDoctor.ForeColor = System.Drawing.Color.White;
            this.DeleteDoctor.Location = new System.Drawing.Point(708, 84);
            this.DeleteDoctor.Name = "DeleteDoctor";
            this.DeleteDoctor.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.DeleteDoctor.Size = new System.Drawing.Size(102, 37);
            this.DeleteDoctor.TabIndex = 30;
            this.DeleteDoctor.Text = "Delete";
            // 
            // UpdateDoctor
            // 
            this.UpdateDoctor.BorderRadius = 10;
            this.UpdateDoctor.CustomizableEdges = customizableEdges5;
            this.UpdateDoctor.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateDoctor.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateDoctor.FillColor = System.Drawing.Color.DodgerBlue;
            this.UpdateDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateDoctor.ForeColor = System.Drawing.Color.White;
            this.UpdateDoctor.Location = new System.Drawing.Point(592, 84);
            this.UpdateDoctor.Name = "UpdateDoctor";
            this.UpdateDoctor.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.UpdateDoctor.Size = new System.Drawing.Size(102, 37);
            this.UpdateDoctor.TabIndex = 29;
            this.UpdateDoctor.Text = "Update";
            // 
            // Searchbutton
            // 
            this.Searchbutton.BorderRadius = 10;
            this.Searchbutton.CustomizableEdges = customizableEdges7;
            this.Searchbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Searchbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Searchbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Searchbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Searchbutton.FillColor = System.Drawing.Color.BlueViolet;
            this.Searchbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Searchbutton.ForeColor = System.Drawing.Color.White;
            this.Searchbutton.Location = new System.Drawing.Point(306, 84);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.Searchbutton.Size = new System.Drawing.Size(115, 37);
            this.Searchbutton.TabIndex = 28;
            this.Searchbutton.Text = "Search";
            // 
            // SeachDoctor
            // 
            this.SeachDoctor.BorderRadius = 10;
            this.SeachDoctor.CustomizableEdges = customizableEdges9;
            this.SeachDoctor.DefaultText = "";
            this.SeachDoctor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SeachDoctor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SeachDoctor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SeachDoctor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SeachDoctor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SeachDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SeachDoctor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SeachDoctor.Location = new System.Drawing.Point(31, 84);
            this.SeachDoctor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeachDoctor.Name = "SeachDoctor";
            this.SeachDoctor.PasswordChar = '\0';
            this.SeachDoctor.PlaceholderText = "Search";
            this.SeachDoctor.SelectedText = "";
            this.SeachDoctor.ShadowDecoration.CustomizableEdges = customizableEdges10;
            this.SeachDoctor.Size = new System.Drawing.Size(254, 37);
            this.SeachDoctor.TabIndex = 27;
            // 
            // Staffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 600);
            this.Controls.Add(this.AddStaff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DoctorsList);
            this.Controls.Add(this.DeleteDoctor);
            this.Controls.Add(this.UpdateDoctor);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(this.SeachDoctor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staffs";
            this.Text = "Staffs";
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddStaff;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView DoctorsList;
        private Guna.UI2.WinForms.Guna2Button DeleteDoctor;
        private Guna.UI2.WinForms.Guna2Button UpdateDoctor;
        private Guna.UI2.WinForms.Guna2Button Searchbutton;
        private Guna.UI2.WinForms.Guna2TextBox SeachDoctor;
    }
}