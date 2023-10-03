namespace HealthCarePlus
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.loginpanel = new System.Windows.Forms.Panel();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CreateAccount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.loginpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkViolet;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 623);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(124, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "Health Care Plus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome";
            this.label1.Click += new System.EventHandler(this.Welcome);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(39, 53);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(91, 25);
            this.usernamelabel.TabIndex = 3;
            this.usernamelabel.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(40, 149);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(87, 25);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // UsernameBox
            // 
            this.UsernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameBox.Location = new System.Drawing.Point(39, 86);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(287, 31);
            this.UsernameBox.TabIndex = 5;
            this.UsernameBox.TextChanged += new System.EventHandler(this.UsernameBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Location = new System.Drawing.Point(40, 182);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(287, 31);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Gold;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(92, 250);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(189, 39);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.LoginButton;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(459, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(366, 32);
            this.label12.TabIndex = 14;
            this.label12.Text = "Hospital Management System";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.guna2Panel1.CustomizableEdges = customizableEdges1;
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel1.Location = new System.Drawing.Point(287, 60);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.guna2Panel1.Size = new System.Drawing.Size(866, 10);
            this.guna2Panel1.TabIndex = 18;
            // 
            // loginpanel
            // 
            this.loginpanel.Controls.Add(this.CreateAccount);
            this.loginpanel.Controls.Add(this.LoginButton);
            this.loginpanel.Controls.Add(this.PasswordBox);
            this.loginpanel.Controls.Add(this.UsernameBox);
            this.loginpanel.Controls.Add(this.Password);
            this.loginpanel.Controls.Add(this.usernamelabel);
            this.loginpanel.Location = new System.Drawing.Point(462, 147);
            this.loginpanel.Name = "loginpanel";
            this.loginpanel.Size = new System.Drawing.Size(363, 388);
            this.loginpanel.TabIndex = 19;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 40;
            this.guna2Elipse3.TargetControl = this.loginpanel;
            // 
            // CreateAccount
            // 
            this.CreateAccount.AutoSize = true;
            this.CreateAccount.Location = new System.Drawing.Point(118, 300);
            this.CreateAccount.Name = "CreateAccount";
            this.CreateAccount.Size = new System.Drawing.Size(134, 25);
            this.CreateAccount.TabIndex = 9;
            this.CreateAccount.Text = "Reset Password";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::HealthCarePlus.Properties.Resources.loginblack1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1027, 620);
            this.Controls.Add(this.loginpanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = " Health Care Plus";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginpanel.ResumeLayout(false);
            this.loginpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label usernamelabel;
        private Label Password;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button LoginButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Label label3;
        private Label label7;
        private Label label12;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Panel loginpanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Label CreateAccount;
    }
}