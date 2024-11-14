namespace MyBankProject
{
    partial class frmAddNewClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewClient));
            this.lblMode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbClientPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPINCode = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtAccNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProgressBar = new System.Windows.Forms.Panel();
            this.pbHideIcon = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientPicture)).BeginInit();
            this.pnlProgressBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideIcon)).BeginInit();
            this.progressBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F);
            this.lblMode.Location = new System.Drawing.Point(25, 31);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(187, 29);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Add New Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "AccountNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(12, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "PINCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(12, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Balance";
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 10;
            this.btnSave.DefaultAutoSize = true;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(108, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Button2.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(209, 429);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(84, 34);
            this.guna2Button2.TabIndex = 16;
            this.guna2Button2.Text = "Close";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MyBankProject.Properties.Resources._9055423_bxs_edit_icon;
            this.pictureBox2.Location = new System.Drawing.Point(513, 167);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbClientPicture
            // 
            this.pbClientPicture.Image = global::MyBankProject.Properties.Resources._3669480_account_circle_ic_icon;
            this.pbClientPicture.ImageRotate = 0F;
            this.pbClientPicture.Location = new System.Drawing.Point(360, 18);
            this.pbClientPicture.Name = "pbClientPicture";
            this.pbClientPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbClientPicture.Size = new System.Drawing.Size(188, 179);
            this.pbClientPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClientPicture.TabIndex = 23;
            this.pbClientPicture.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtName.Location = new System.Drawing.Point(108, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 23);
            this.txtName.TabIndex = 27;
            this.txtName.TextChanged += new System.EventHandler(this.Field_TextChanged);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPhone.Location = new System.Drawing.Point(108, 223);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 23);
            this.txtPhone.TabIndex = 28;
            this.txtPhone.TextChanged += new System.EventHandler(this.Field_TextChanged);
            this.txtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.mtbPhone_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtEmail.Location = new System.Drawing.Point(108, 271);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 23);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.TextChanged += new System.EventHandler(this.Field_TextChanged);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPINCode
            // 
            this.txtPINCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtPINCode.Location = new System.Drawing.Point(108, 311);
            this.txtPINCode.MaxLength = 4;
            this.txtPINCode.Name = "txtPINCode";
            this.txtPINCode.PasswordChar = '*';
            this.txtPINCode.Size = new System.Drawing.Size(114, 23);
            this.txtPINCode.TabIndex = 30;
            this.txtPINCode.TextChanged += new System.EventHandler(this.Field_TextChanged);
            this.txtPINCode.Validating += new System.ComponentModel.CancelEventHandler(this.mtbPINCode_Validating);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtBalance.Location = new System.Drawing.Point(108, 363);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(185, 23);
            this.txtBalance.TabIndex = 31;
            this.txtBalance.TextChanged += new System.EventHandler(this.Field_TextChanged);
            this.txtBalance.Validating += new System.ComponentModel.CancelEventHandler(this.mtbBalance_Validating);
            // 
            // txtAccNO
            // 
            this.txtAccNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtAccNO.Location = new System.Drawing.Point(108, 126);
            this.txtAccNO.Name = "txtAccNO";
            this.txtAccNO.Size = new System.Drawing.Size(104, 23);
            this.txtAccNO.TabIndex = 26;
            this.txtAccNO.TextChanged += new System.EventHandler(this.Field_TextChanged);
            this.txtAccNO.Validating += new System.ComponentModel.CancelEventHandler(this.mtbAccNO_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(294, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "$";
            // 
            // pnlProgressBar
            // 
            this.pnlProgressBar.Controls.Add(this.progressBar1);
            this.pnlProgressBar.Location = new System.Drawing.Point(369, 208);
            this.pnlProgressBar.Name = "pnlProgressBar";
            this.pnlProgressBar.Size = new System.Drawing.Size(192, 191);
            this.pnlProgressBar.TabIndex = 34;
            // 
            // pbHideIcon
            // 
            this.pbHideIcon.Image = global::MyBankProject.Properties.Resources._6351930_eye_password_see_view_icon;
            this.pbHideIcon.Location = new System.Drawing.Point(228, 308);
            this.pbHideIcon.Name = "pbHideIcon";
            this.pbHideIcon.Size = new System.Drawing.Size(27, 26);
            this.pbHideIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideIcon.TabIndex = 35;
            this.pbHideIcon.TabStop = false;
            this.pbHideIcon.Click += new System.EventHandler(this.pbHideIcon_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Controls.Add(this.lblProgress);
            this.progressBar1.FillColor = System.Drawing.Color.White;
            this.progressBar1.FillOffset = 5;
            this.progressBar1.FillThickness = 15;
            this.progressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.progressBar1.ForeColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(12, 10);
            this.progressBar1.Minimum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.progressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.progressBar1.ProgressThickness = 20;
            this.progressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.progressBar1.Size = new System.Drawing.Size(169, 169);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Text = "guna2CircleProgressBar1";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Impact", 17.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.Color.Olive;
            this.lblProgress.Location = new System.Drawing.Point(61, 71);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(43, 29);
            this.lblProgress.TabIndex = 0;
            this.lblProgress.Text = "0%";
            // 
            // frmAddNewClient
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 517);
            this.Controls.Add(this.pbHideIcon);
            this.Controls.Add(this.pnlProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPINCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAccNO);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbClientPicture);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddNewClient";
            this.Text = "Add New Client";
            this.Load += new System.EventHandler(this.frmAddNewClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClientPicture)).EndInit();
            this.pnlProgressBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHideIcon)).EndInit();
            this.progressBar1.ResumeLayout(false);
            this.progressBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbClientPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtPINCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAccNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProgressBar;
        private System.Windows.Forms.PictureBox pbHideIcon;
        private Guna.UI2.WinForms.Guna2CircleProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
    }
}