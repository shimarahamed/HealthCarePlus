namespace HealthCarePlus.Pages.Appointments
{
    partial class Invoice
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
            this.InvoiceTextBox = new System.Windows.Forms.RichTextBox();
            this.ClearInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.Print = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // InvoiceTextBox
            // 
            this.InvoiceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InvoiceTextBox.Location = new System.Drawing.Point(12, 12);
            this.InvoiceTextBox.Name = "InvoiceTextBox";
            this.InvoiceTextBox.Size = new System.Drawing.Size(379, 486);
            this.InvoiceTextBox.TabIndex = 80;
            this.InvoiceTextBox.Text = "";
            // 
            // ClearInvoice
            // 
            this.ClearInvoice.BorderRadius = 10;
            this.ClearInvoice.CustomizableEdges = customizableEdges1;
            this.ClearInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClearInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClearInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClearInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClearInvoice.FillColor = System.Drawing.Color.Red;
            this.ClearInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearInvoice.ForeColor = System.Drawing.Color.White;
            this.ClearInvoice.Location = new System.Drawing.Point(247, 509);
            this.ClearInvoice.Name = "ClearInvoice";
            this.ClearInvoice.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.ClearInvoice.Size = new System.Drawing.Size(144, 37);
            this.ClearInvoice.TabIndex = 83;
            this.ClearInvoice.Text = "Clear Invoice";
            this.ClearInvoice.Click += new System.EventHandler(this.ClearInvoice_Click);
            // 
            // Print
            // 
            this.Print.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.Image = global::HealthCarePlus.Properties.Resources.printer;
            this.Print.ImageOffset = new System.Drawing.Point(0, 0);
            this.Print.ImageRotate = 0F;
            this.Print.ImageSize = new System.Drawing.Size(40, 40);
            this.Print.Location = new System.Drawing.Point(195, 507);
            this.Print.Name = "Print";
            this.Print.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Print.ShadowDecoration.CustomizableEdges = customizableEdges3;
            this.Print.Size = new System.Drawing.Size(46, 41);
            this.Print.TabIndex = 82;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 554);
            this.Controls.Add(this.ClearInvoice);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.InvoiceTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox InvoiceTextBox;
        private Guna.UI2.WinForms.Guna2Button ClearInvoice;
        private Guna.UI2.WinForms.Guna2ImageButton Print;
    }
}