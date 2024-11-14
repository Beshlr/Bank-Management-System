namespace MyBankProject
{
    partial class frmMainScreen
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptnLoginRegisters = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnCurrencyExchange = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnTransactions = new Guna.UI2.WinForms.Guna2Button();
            this.btnClientList = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(212)))), ((int)(((byte)(254)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lblDate);
            this.guna2Panel1.Controls.Add(this.pictureBox2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.lblDateTime);
            this.guna2Panel1.Controls.Add(this.lblUsername);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(0, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(192, 703);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(8, 321);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MyBankProject.Properties.Resources._3994382_access_close_exit_logout_sign_out_icon1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 604);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MyBankProject.Properties.Resources.accountProfileIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(158, 604);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(12, 342);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(39, 17);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "Time";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Impact", 14F);
            this.lblUsername.ForeColor = System.Drawing.Color.Lime;
            this.lblUsername.Location = new System.Drawing.Point(86, 289);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(59, 23);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Admin";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::MyBankProject.Properties.Resources.Bank_free_vector_icons_designed_by_Freepik_removebg_preview;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(9, 72);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(171, 121);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome\r\nMr :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptnLoginRegisters);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.btnCurrencyExchange);
            this.panel1.Controls.Add(this.btnManageUsers);
            this.panel1.Controls.Add(this.btnTransactions);
            this.panel1.Controls.Add(this.btnClientList);
            this.panel1.Location = new System.Drawing.Point(186, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 639);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ptnLoginRegisters
            // 
            this.ptnLoginRegisters.Animated = true;
            this.ptnLoginRegisters.BorderRadius = 20;
            this.ptnLoginRegisters.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ptnLoginRegisters.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ptnLoginRegisters.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ptnLoginRegisters.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ptnLoginRegisters.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.ptnLoginRegisters.ForeColor = System.Drawing.Color.White;
            this.ptnLoginRegisters.IndicateFocus = true;
            this.ptnLoginRegisters.Location = new System.Drawing.Point(180, 501);
            this.ptnLoginRegisters.Name = "ptnLoginRegisters";
            this.ptnLoginRegisters.Size = new System.Drawing.Size(334, 54);
            this.ptnLoginRegisters.TabIndex = 12;
            this.ptnLoginRegisters.Text = "Login Registers";
            this.ptnLoginRegisters.Click += new System.EventHandler(this.ptnLoginRegisters_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox3.Location = new System.Drawing.Point(691, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // btnCurrencyExchange
            // 
            this.btnCurrencyExchange.Animated = true;
            this.btnCurrencyExchange.BorderRadius = 20;
            this.btnCurrencyExchange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrencyExchange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCurrencyExchange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCurrencyExchange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCurrencyExchange.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.btnCurrencyExchange.ForeColor = System.Drawing.Color.White;
            this.btnCurrencyExchange.IndicateFocus = true;
            this.btnCurrencyExchange.Location = new System.Drawing.Point(180, 395);
            this.btnCurrencyExchange.Name = "btnCurrencyExchange";
            this.btnCurrencyExchange.Size = new System.Drawing.Size(334, 54);
            this.btnCurrencyExchange.TabIndex = 3;
            this.btnCurrencyExchange.Text = "Currency Exchange";
            this.btnCurrencyExchange.Click += new System.EventHandler(this.btnCurrencyExchange_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Animated = true;
            this.btnManageUsers.BorderRadius = 20;
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.btnManageUsers.ForeColor = System.Drawing.Color.White;
            this.btnManageUsers.IndicateFocus = true;
            this.btnManageUsers.Location = new System.Drawing.Point(180, 289);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(334, 54);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Animated = true;
            this.btnTransactions.BorderRadius = 20;
            this.btnTransactions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTransactions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTransactions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTransactions.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.btnTransactions.ForeColor = System.Drawing.Color.White;
            this.btnTransactions.IndicateFocus = true;
            this.btnTransactions.Location = new System.Drawing.Point(180, 183);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(334, 54);
            this.btnTransactions.TabIndex = 1;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnClientList
            // 
            this.btnClientList.Animated = true;
            this.btnClientList.BorderRadius = 20;
            this.btnClientList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClientList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClientList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClientList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClientList.Font = new System.Drawing.Font("Elephant", 14.25F);
            this.btnClientList.ForeColor = System.Drawing.Color.White;
            this.btnClientList.IndicateFocus = true;
            this.btnClientList.Location = new System.Drawing.Point(180, 77);
            this.btnClientList.Name = "btnClientList";
            this.btnClientList.Size = new System.Drawing.Size(334, 54);
            this.btnClientList.TabIndex = 0;
            this.btnClientList.Text = "Client List";
            this.btnClientList.Click += new System.EventHandler(this.btnClientList_Click);
            // 
            // frmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyBankProject.Properties.Resources.Bank;
            this.ClientSize = new System.Drawing.Size(921, 634);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMainScreen";
            this.Text = "MainScreen";
            this.Load += new System.EventHandler(this.frmShowClientList_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClientList;
        private Guna.UI2.WinForms.Guna2Button btnCurrencyExchange;
        private Guna.UI2.WinForms.Guna2Button btnManageUsers;
        private Guna.UI2.WinForms.Guna2Button btnTransactions;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Guna.UI2.WinForms.Guna2Button ptnLoginRegisters;
    }
}