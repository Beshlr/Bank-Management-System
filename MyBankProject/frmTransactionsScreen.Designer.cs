namespace MyBankProject
{
    partial class frmTransactionsScreen
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabTransactions = new System.Windows.Forms.TabControl();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.tabWthdraw = new System.Windows.Forms.TabPage();
            this.tabTBalances = new System.Windows.Forms.TabPage();
            this.tabTransfer = new System.Windows.Forms.TabPage();
            this.tabTransferLog = new System.Windows.Forms.TabPage();
            this.pnlDeposit = new System.Windows.Forms.Panel();
            this.pnlWithdraw = new System.Windows.Forms.Panel();
            this.pnlTotalBalances = new System.Windows.Forms.Panel();
            this.pnlTransfer = new System.Windows.Forms.Panel();
            this.pnlTransferLog = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabTransactions.SuspendLayout();
            this.tabDeposit.SuspendLayout();
            this.tabWthdraw.SuspendLayout();
            this.tabTBalances.SuspendLayout();
            this.tabTransfer.SuspendLayout();
            this.tabTransferLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(212)))), ((int)(((byte)(254)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.pictureBox3);
            this.guna2Panel1.Controls.Add(this.pictureBox4);
            this.guna2Panel1.Controls.Add(this.lblDate);
            this.guna2Panel1.Controls.Add(this.lblDateTime);
            this.guna2Panel1.Controls.Add(this.lblUsername);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(192, 651);
            this.guna2Panel1.TabIndex = 3;
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
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::MyBankProject.Properties.Resources.Bank_free_vector_icons_designed_by_Freepik_removebg_preview;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, 81);
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
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::MyBankProject.Properties.Resources._3994382_access_close_exit_logout_sign_out_icon1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 619);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::MyBankProject.Properties.Resources.accountProfileIcon1;
            this.pictureBox4.Location = new System.Drawing.Point(158, 619);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.tabDeposit);
            this.tabTransactions.Controls.Add(this.tabWthdraw);
            this.tabTransactions.Controls.Add(this.tabTBalances);
            this.tabTransactions.Controls.Add(this.tabTransfer);
            this.tabTransactions.Controls.Add(this.tabTransferLog);
            this.tabTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tabTransactions.Location = new System.Drawing.Point(196, 4);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.SelectedIndex = 0;
            this.tabTransactions.Size = new System.Drawing.Size(930, 651);
            this.tabTransactions.TabIndex = 4;
            // 
            // tabDeposit
            // 
            this.tabDeposit.Controls.Add(this.pictureBox5);
            this.tabDeposit.Controls.Add(this.pnlDeposit);
            this.tabDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tabDeposit.Location = new System.Drawing.Point(4, 26);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposit.Size = new System.Drawing.Size(922, 621);
            this.tabDeposit.TabIndex = 0;
            this.tabDeposit.Text = "Deposit";
            this.tabDeposit.UseVisualStyleBackColor = true;
            // 
            // tabWthdraw
            // 
            this.tabWthdraw.Controls.Add(this.pictureBox6);
            this.tabWthdraw.Controls.Add(this.pnlWithdraw);
            this.tabWthdraw.Location = new System.Drawing.Point(4, 26);
            this.tabWthdraw.Name = "tabWthdraw";
            this.tabWthdraw.Padding = new System.Windows.Forms.Padding(3);
            this.tabWthdraw.Size = new System.Drawing.Size(922, 621);
            this.tabWthdraw.TabIndex = 1;
            this.tabWthdraw.Text = "Withdraw";
            this.tabWthdraw.UseVisualStyleBackColor = true;
            // 
            // tabTBalances
            // 
            this.tabTBalances.Controls.Add(this.pictureBox7);
            this.tabTBalances.Controls.Add(this.pnlTotalBalances);
            this.tabTBalances.Location = new System.Drawing.Point(4, 26);
            this.tabTBalances.Name = "tabTBalances";
            this.tabTBalances.Size = new System.Drawing.Size(922, 621);
            this.tabTBalances.TabIndex = 2;
            this.tabTBalances.Text = "Total Balances";
            this.tabTBalances.UseVisualStyleBackColor = true;
            // 
            // tabTransfer
            // 
            this.tabTransfer.Controls.Add(this.pictureBox8);
            this.tabTransfer.Controls.Add(this.pnlTransfer);
            this.tabTransfer.Location = new System.Drawing.Point(4, 26);
            this.tabTransfer.Name = "tabTransfer";
            this.tabTransfer.Size = new System.Drawing.Size(922, 621);
            this.tabTransfer.TabIndex = 3;
            this.tabTransfer.Text = "Transfer";
            this.tabTransfer.UseVisualStyleBackColor = true;
            // 
            // tabTransferLog
            // 
            this.tabTransferLog.Controls.Add(this.pictureBox9);
            this.tabTransferLog.Controls.Add(this.pnlTransferLog);
            this.tabTransferLog.Location = new System.Drawing.Point(4, 26);
            this.tabTransferLog.Name = "tabTransferLog";
            this.tabTransferLog.Size = new System.Drawing.Size(922, 621);
            this.tabTransferLog.TabIndex = 4;
            this.tabTransferLog.Text = "Transfer Log";
            this.tabTransferLog.UseVisualStyleBackColor = true;
            // 
            // pnlDeposit
            // 
            this.pnlDeposit.Location = new System.Drawing.Point(162, 6);
            this.pnlDeposit.Name = "pnlDeposit";
            this.pnlDeposit.Size = new System.Drawing.Size(506, 602);
            this.pnlDeposit.TabIndex = 0;
            // 
            // pnlWithdraw
            // 
            this.pnlWithdraw.Location = new System.Drawing.Point(183, 10);
            this.pnlWithdraw.Name = "pnlWithdraw";
            this.pnlWithdraw.Size = new System.Drawing.Size(483, 598);
            this.pnlWithdraw.TabIndex = 1;
            // 
            // pnlTotalBalances
            // 
            this.pnlTotalBalances.Location = new System.Drawing.Point(6, 10);
            this.pnlTotalBalances.Name = "pnlTotalBalances";
            this.pnlTotalBalances.Size = new System.Drawing.Size(875, 598);
            this.pnlTotalBalances.TabIndex = 1;
            // 
            // pnlTransfer
            // 
            this.pnlTransfer.Location = new System.Drawing.Point(183, 10);
            this.pnlTransfer.Name = "pnlTransfer";
            this.pnlTransfer.Size = new System.Drawing.Size(517, 598);
            this.pnlTransfer.TabIndex = 1;
            // 
            // pnlTransferLog
            // 
            this.pnlTransferLog.Location = new System.Drawing.Point(3, 51);
            this.pnlTransferLog.Name = "pnlTransferLog";
            this.pnlTransferLog.Size = new System.Drawing.Size(906, 557);
            this.pnlTransferLog.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox5.Location = new System.Drawing.Point(877, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 33);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox6.Location = new System.Drawing.Point(877, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(32, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox7.Location = new System.Drawing.Point(879, 12);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 33);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox8.Location = new System.Drawing.Point(877, 12);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(32, 33);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 13;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox9.Location = new System.Drawing.Point(877, 12);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 33);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // frmTransactionsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 650);
            this.Controls.Add(this.tabTransactions);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactionsScreen";
            this.Text = "frmTransactionsScreen";
            this.Load += new System.EventHandler(this.frmTransactionsScreen_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabTransactions.ResumeLayout(false);
            this.tabDeposit.ResumeLayout(false);
            this.tabWthdraw.ResumeLayout(false);
            this.tabTBalances.ResumeLayout(false);
            this.tabTransfer.ResumeLayout(false);
            this.tabTransferLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabTransactions;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.TabPage tabWthdraw;
        private System.Windows.Forms.TabPage tabTBalances;
        private System.Windows.Forms.TabPage tabTransfer;
        private System.Windows.Forms.TabPage tabTransferLog;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnlDeposit;
        private System.Windows.Forms.Panel pnlWithdraw;
        private System.Windows.Forms.Panel pnlTotalBalances;
        private System.Windows.Forms.Panel pnlTransfer;
        private System.Windows.Forms.Panel pnlTransferLog;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}