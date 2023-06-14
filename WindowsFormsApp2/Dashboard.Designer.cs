namespace WindowsFormsApp2
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butLogout = new System.Windows.Forms.Button();
            this.butContactus = new System.Windows.Forms.Button();
            this.butOurservice = new System.Windows.Forms.Button();
            this.butMoneytra = new System.Windows.Forms.Button();
            this.butProfile = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butLogout);
            this.panel1.Controls.Add(this.butContactus);
            this.panel1.Controls.Add(this.butOurservice);
            this.panel1.Controls.Add(this.butMoneytra);
            this.panel1.Controls.Add(this.butProfile);
            this.panel1.Controls.Add(this.butHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 418);
            this.panel1.TabIndex = 0;
            // 
            // butLogout
            // 
            this.butLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butLogout.FlatAppearance.BorderSize = 0;
            this.butLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogout.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogout.Location = new System.Drawing.Point(8, 372);
            this.butLogout.Margin = new System.Windows.Forms.Padding(2);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(177, 31);
            this.butLogout.TabIndex = 5;
            this.butLogout.Text = "LOGOUT";
            this.butLogout.UseVisualStyleBackColor = false;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            // 
            // butContactus
            // 
            this.butContactus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butContactus.FlatAppearance.BorderSize = 0;
            this.butContactus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butContactus.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butContactus.Location = new System.Drawing.Point(8, 181);
            this.butContactus.Margin = new System.Windows.Forms.Padding(2);
            this.butContactus.Name = "butContactus";
            this.butContactus.Size = new System.Drawing.Size(177, 31);
            this.butContactus.TabIndex = 4;
            this.butContactus.Text = "CONTACT US";
            this.butContactus.UseVisualStyleBackColor = false;
            this.butContactus.Click += new System.EventHandler(this.butContactus_Click);
            // 
            // butOurservice
            // 
            this.butOurservice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butOurservice.FlatAppearance.BorderSize = 0;
            this.butOurservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOurservice.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butOurservice.Location = new System.Drawing.Point(8, 140);
            this.butOurservice.Margin = new System.Windows.Forms.Padding(2);
            this.butOurservice.Name = "butOurservice";
            this.butOurservice.Size = new System.Drawing.Size(177, 31);
            this.butOurservice.TabIndex = 3;
            this.butOurservice.Text = "OUR SERVICE";
            this.butOurservice.UseVisualStyleBackColor = false;
            this.butOurservice.Click += new System.EventHandler(this.butOurservice_Click);
            // 
            // butMoneytra
            // 
            this.butMoneytra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butMoneytra.FlatAppearance.BorderSize = 0;
            this.butMoneytra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMoneytra.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMoneytra.Location = new System.Drawing.Point(8, 98);
            this.butMoneytra.Margin = new System.Windows.Forms.Padding(2);
            this.butMoneytra.Name = "butMoneytra";
            this.butMoneytra.Size = new System.Drawing.Size(177, 31);
            this.butMoneytra.TabIndex = 2;
            this.butMoneytra.Text = "MONEY TRANESFER";
            this.butMoneytra.UseVisualStyleBackColor = false;
            this.butMoneytra.Click += new System.EventHandler(this.butMoneytra_Click);
            // 
            // butProfile
            // 
            this.butProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butProfile.FlatAppearance.BorderSize = 0;
            this.butProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butProfile.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.butProfile.Location = new System.Drawing.Point(8, 57);
            this.butProfile.Margin = new System.Windows.Forms.Padding(2);
            this.butProfile.Name = "butProfile";
            this.butProfile.Size = new System.Drawing.Size(177, 31);
            this.butProfile.TabIndex = 1;
            this.butProfile.Text = "PROFILE";
            this.butProfile.UseVisualStyleBackColor = false;
            this.butProfile.Click += new System.EventHandler(this.butProfile_Click);
            // 
            // butHome
            // 
            this.butHome.BackColor = System.Drawing.Color.White;
            this.butHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butHome.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.butHome.Location = new System.Drawing.Point(8, 14);
            this.butHome.Margin = new System.Windows.Forms.Padding(2);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(177, 31);
            this.butHome.TabIndex = 0;
            this.butHome.Text = "HOME";
            this.butHome.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.textBox1.Location = new System.Drawing.Point(291, 151);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 150);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Welcome to your Dashboard\r\n        What do you want!";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Desktop___2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 418);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butHome;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Button butContactus;
        private System.Windows.Forms.Button butOurservice;
        private System.Windows.Forms.Button butMoneytra;
        private System.Windows.Forms.Button butProfile;
        private System.Windows.Forms.TextBox textBox1;
    }
}