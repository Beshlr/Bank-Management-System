namespace MyBankProject
{
    partial class frmAddEditUser
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
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxLoginRegistersPer = new System.Windows.Forms.CheckBox();
            this.cbxAllPer = new System.Windows.Forms.CheckBox();
            this.cbxManageUsersPer = new System.Windows.Forms.CheckBox();
            this.cbxTransactionsPer = new System.Windows.Forms.CheckBox();
            this.cbxClientListPer = new System.Windows.Forms.CheckBox();
            this.btnAddEditUser = new Guna.UI2.WinForms.Guna2Button();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbUserPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pbHideIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 10;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(30, 306);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "Enter Your Name";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(200, 41);
            this.txtName.TabIndex = 2;
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(30, 386);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "ex@example.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(200, 41);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(32, 461);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Enter Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 41);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(27, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(408, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(27, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(408, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(27, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(408, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 538);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 83);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(240, 41);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(119, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Manage Users";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(126, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(109, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Transactions";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Client List";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(411, 389);
            this.mtxtPhone.Mask = "+0000000000000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(199, 20);
            this.mtxtPhone.TabIndex = 18;
            this.mtxtPhone.Validating += new System.ComponentModel.CancelEventHandler(this.mtxtPhone_Validating);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxLoginRegistersPer);
            this.groupBox2.Controls.Add(this.cbxAllPer);
            this.groupBox2.Controls.Add(this.cbxManageUsersPer);
            this.groupBox2.Controls.Add(this.cbxTransactionsPer);
            this.groupBox2.Controls.Add(this.cbxClientListPer);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 540);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 105);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permissions";
            // 
            // cbxLoginRegistersPer
            // 
            this.cbxLoginRegistersPer.AutoSize = true;
            this.cbxLoginRegistersPer.Location = new System.Drawing.Point(19, 75);
            this.cbxLoginRegistersPer.Name = "cbxLoginRegistersPer";
            this.cbxLoginRegistersPer.Size = new System.Drawing.Size(126, 21);
            this.cbxLoginRegistersPer.TabIndex = 4;
            this.cbxLoginRegistersPer.Tag = "8";
            this.cbxLoginRegistersPer.Text = "Login Registers";
            this.cbxLoginRegistersPer.UseVisualStyleBackColor = true;
            this.cbxLoginRegistersPer.CheckedChanged += new System.EventHandler(this.cbxClientListPer_CheckedChanged);
            // 
            // cbxAllPer
            // 
            this.cbxAllPer.AutoSize = true;
            this.cbxAllPer.Location = new System.Drawing.Point(240, 78);
            this.cbxAllPer.Name = "cbxAllPer";
            this.cbxAllPer.Size = new System.Drawing.Size(42, 21);
            this.cbxAllPer.TabIndex = 3;
            this.cbxAllPer.Tag = "-1";
            this.cbxAllPer.Text = "All";
            this.cbxAllPer.UseVisualStyleBackColor = true;
            this.cbxAllPer.CheckedChanged += new System.EventHandler(this.cbxAllPer_CheckedChanged);
            // 
            // cbxManageUsersPer
            // 
            this.cbxManageUsersPer.AutoSize = true;
            this.cbxManageUsersPer.Location = new System.Drawing.Point(240, 41);
            this.cbxManageUsersPer.Name = "cbxManageUsersPer";
            this.cbxManageUsersPer.Size = new System.Drawing.Size(119, 21);
            this.cbxManageUsersPer.TabIndex = 2;
            this.cbxManageUsersPer.Tag = "4";
            this.cbxManageUsersPer.Text = "Manage Users";
            this.cbxManageUsersPer.UseVisualStyleBackColor = true;
            this.cbxManageUsersPer.CheckedChanged += new System.EventHandler(this.cbxClientListPer_CheckedChanged);
            // 
            // cbxTransactionsPer
            // 
            this.cbxTransactionsPer.AutoSize = true;
            this.cbxTransactionsPer.Location = new System.Drawing.Point(126, 41);
            this.cbxTransactionsPer.Name = "cbxTransactionsPer";
            this.cbxTransactionsPer.Size = new System.Drawing.Size(109, 21);
            this.cbxTransactionsPer.TabIndex = 1;
            this.cbxTransactionsPer.Tag = "2";
            this.cbxTransactionsPer.Text = "Transactions";
            this.cbxTransactionsPer.UseVisualStyleBackColor = true;
            this.cbxTransactionsPer.CheckedChanged += new System.EventHandler(this.cbxClientListPer_CheckedChanged);
            // 
            // cbxClientListPer
            // 
            this.cbxClientListPer.AutoSize = true;
            this.cbxClientListPer.Location = new System.Drawing.Point(19, 41);
            this.cbxClientListPer.Name = "cbxClientListPer";
            this.cbxClientListPer.Size = new System.Drawing.Size(88, 21);
            this.cbxClientListPer.TabIndex = 0;
            this.cbxClientListPer.Tag = "1";
            this.cbxClientListPer.Text = "Client List";
            this.cbxClientListPer.UseVisualStyleBackColor = true;
            this.cbxClientListPer.CheckedChanged += new System.EventHandler(this.cbxClientListPer_CheckedChanged);
            // 
            // btnAddEditUser
            // 
            this.btnAddEditUser.BorderRadius = 20;
            this.btnAddEditUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEditUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEditUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEditUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEditUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(219)))));
            this.btnAddEditUser.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditUser.ForeColor = System.Drawing.Color.White;
            this.btnAddEditUser.Location = new System.Drawing.Point(416, 563);
            this.btnAddEditUser.Name = "btnAddEditUser";
            this.btnAddEditUser.Size = new System.Drawing.Size(192, 39);
            this.btnAddEditUser.TabIndex = 17;
            this.btnAddEditUser.Text = "Add";
            this.btnAddEditUser.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 10;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(411, 306);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Enter Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(200, 41);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(26, 35);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(197, 31);
            this.lblMode.TabIndex = 19;
            this.lblMode.Text = "Add New User";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(410, 461);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Enter You Address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(200, 41);
            this.txtAddress.TabIndex = 20;
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MyBankProject.Properties.Resources._9055423_bxs_edit_icon;
            this.pictureBox2.Location = new System.Drawing.Point(378, 233);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pbUserPicture
            // 
            this.pbUserPicture.Image = global::MyBankProject.Properties.Resources._3669480_account_circle_ic_icon;
            this.pbUserPicture.ImageRotate = 0F;
            this.pbUserPicture.Location = new System.Drawing.Point(225, 84);
            this.pbUserPicture.Name = "pbUserPicture";
            this.pbUserPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserPicture.Size = new System.Drawing.Size(188, 179);
            this.pbUserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserPicture.TabIndex = 0;
            this.pbUserPicture.TabStop = false;
            this.pbUserPicture.Click += new System.EventHandler(this.pbUserPicture_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyBankProject.Properties.Resources._9055423_bxs_edit_icon;
            this.pictureBox1.Location = new System.Drawing.Point(379, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox3.Location = new System.Drawing.Point(598, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbHideIcon
            // 
            this.pbHideIcon.Image = global::MyBankProject.Properties.Resources._6351930_eye_password_see_view_icon;
            this.pbHideIcon.Location = new System.Drawing.Point(238, 471);
            this.pbHideIcon.Name = "pbHideIcon";
            this.pbHideIcon.Size = new System.Drawing.Size(27, 26);
            this.pbHideIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHideIcon.TabIndex = 22;
            this.pbHideIcon.TabStop = false;
            this.pbHideIcon.Click += new System.EventHandler(this.pbHideIcon_Click);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 670);
            this.Controls.Add(this.pbHideIcon);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.btnAddEditUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pbUserPicture);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditUser";
            this.Text = "frmAddNewUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserPicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxManageUsersPer;
        private System.Windows.Forms.CheckBox cbxTransactionsPer;
        private System.Windows.Forms.CheckBox cbxClientListPer;
        private Guna.UI2.WinForms.Guna2Button btnAddEditUser;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label lblMode;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.CheckBox cbxAllPer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox cbxLoginRegistersPer;
        private System.Windows.Forms.PictureBox pbHideIcon;
    }
}