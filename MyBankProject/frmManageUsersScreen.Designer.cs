namespace MyBankProject
{
    partial class frmManageUsersScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsersList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOfUsers = new System.Windows.Forms.Label();
            this.gbFindBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbAddress = new System.Windows.Forms.RadioButton();
            this.rbUsername = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOrderUsersListDESC = new System.Windows.Forms.RadioButton();
            this.rbOrderUsersListASC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pbFindClientSettings = new System.Windows.Forms.PictureBox();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbFindBy.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindClientSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsersList
            // 
            this.dgvUsersList.AllowUserToAddRows = false;
            this.dgvUsersList.AllowUserToDeleteRows = false;
            this.dgvUsersList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsersList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsersList.ColumnHeadersHeight = 4;
            this.dgvUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsersList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsersList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsersList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.Location = new System.Drawing.Point(15, 154);
            this.dgvUsersList.Name = "dgvUsersList";
            this.dgvUsersList.ReadOnly = true;
            this.dgvUsersList.RowHeadersVisible = false;
            this.dgvUsersList.Size = new System.Drawing.Size(769, 257);
            this.dgvUsersList.TabIndex = 0;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvUsersList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsersList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsersList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvUsersList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvUsersList.ThemeStyle.ReadOnly = true;
            this.dgvUsersList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsersList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUsersList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvUsersList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsersList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvUsersList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvUsersList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvUsersList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersList_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 70);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.addNewClientToolStripMenuItem.Text = "Add New User";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(31, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "User (s) Found";
            // 
            // lblNumOfUsers
            // 
            this.lblNumOfUsers.AutoSize = true;
            this.lblNumOfUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumOfUsers.Location = new System.Drawing.Point(16, 125);
            this.lblNumOfUsers.Name = "lblNumOfUsers";
            this.lblNumOfUsers.Size = new System.Drawing.Size(18, 20);
            this.lblNumOfUsers.TabIndex = 20;
            this.lblNumOfUsers.Text = "0";
            this.lblNumOfUsers.Click += new System.EventHandler(this.lblNumOfUsers_Click);
            // 
            // gbFindBy
            // 
            this.gbFindBy.Controls.Add(this.rbName);
            this.gbFindBy.Controls.Add(this.rbAddress);
            this.gbFindBy.Controls.Add(this.rbUsername);
            this.gbFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFindBy.Location = new System.Drawing.Point(294, 25);
            this.gbFindBy.Name = "gbFindBy";
            this.gbFindBy.Size = new System.Drawing.Size(231, 100);
            this.gbFindBy.TabIndex = 19;
            this.gbFindBy.Text = "Find By";
            this.gbFindBy.Visible = false;
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbName.Location = new System.Drawing.Point(20, 76);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(54, 17);
            this.rbName.TabIndex = 2;
            this.rbName.Text = "Name";
            this.rbName.UseVisualStyleBackColor = true;
            this.rbName.CheckedChanged += new System.EventHandler(this.rbName_CheckedChanged);
            // 
            // rbAddress
            // 
            this.rbAddress.AutoSize = true;
            this.rbAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbAddress.Location = new System.Drawing.Point(135, 50);
            this.rbAddress.Name = "rbAddress";
            this.rbAddress.Size = new System.Drawing.Size(66, 17);
            this.rbAddress.TabIndex = 1;
            this.rbAddress.Text = "Address";
            this.rbAddress.UseVisualStyleBackColor = true;
            this.rbAddress.CheckedChanged += new System.EventHandler(this.rbAddress_CheckedChanged);
            // 
            // rbUsername
            // 
            this.rbUsername.AutoSize = true;
            this.rbUsername.Checked = true;
            this.rbUsername.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbUsername.Location = new System.Drawing.Point(18, 50);
            this.rbUsername.Name = "rbUsername";
            this.rbUsername.Size = new System.Drawing.Size(76, 17);
            this.rbUsername.TabIndex = 0;
            this.rbUsername.TabStop = true;
            this.rbUsername.Text = "Username";
            this.rbUsername.UseVisualStyleBackColor = true;
            this.rbUsername.CheckedChanged += new System.EventHandler(this.rbUsername_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrderUsersListDESC);
            this.groupBox1.Controls.Add(this.rbOrderUsersListASC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(593, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // rbOrderUsersListDESC
            // 
            this.rbOrderUsersListDESC.AutoSize = true;
            this.rbOrderUsersListDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderUsersListDESC.Location = new System.Drawing.Point(103, 68);
            this.rbOrderUsersListDESC.Name = "rbOrderUsersListDESC";
            this.rbOrderUsersListDESC.Size = new System.Drawing.Size(54, 17);
            this.rbOrderUsersListDESC.TabIndex = 1;
            this.rbOrderUsersListDESC.Text = "DESC";
            this.rbOrderUsersListDESC.UseVisualStyleBackColor = true;
            this.rbOrderUsersListDESC.CheckedChanged += new System.EventHandler(this.rbOrderUsersListDESC_CheckedChanged);
            // 
            // rbOrderUsersListASC
            // 
            this.rbOrderUsersListASC.AutoSize = true;
            this.rbOrderUsersListASC.Checked = true;
            this.rbOrderUsersListASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderUsersListASC.Location = new System.Drawing.Point(26, 68);
            this.rbOrderUsersListASC.Name = "rbOrderUsersListASC";
            this.rbOrderUsersListASC.Size = new System.Drawing.Size(46, 17);
            this.rbOrderUsersListASC.TabIndex = 0;
            this.rbOrderUsersListASC.TabStop = true;
            this.rbOrderUsersListASC.Text = "ASC";
            this.rbOrderUsersListASC.UseVisualStyleBackColor = true;
            this.rbOrderUsersListASC.CheckedChanged += new System.EventHandler(this.rbOrderUsersListASC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Find User";
            // 
            // txtFindUser
            // 
            this.txtFindUser.BorderRadius = 10;
            this.txtFindUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindUser.DefaultText = "";
            this.txtFindUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFindUser.ForeColor = System.Drawing.Color.Black;
            this.txtFindUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindUser.Location = new System.Drawing.Point(9, 59);
            this.txtFindUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindUser.Name = "txtFindUser";
            this.txtFindUser.PasswordChar = '\0';
            this.txtFindUser.PlaceholderText = "Enter Username";
            this.txtFindUser.SelectedText = "";
            this.txtFindUser.Size = new System.Drawing.Size(242, 29);
            this.txtFindUser.TabIndex = 14;
            this.txtFindUser.TextChanged += new System.EventHandler(this.txtFindUser_TextChanged);
            this.txtFindUser.Click += new System.EventHandler(this.txtFindUser_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox1.Location = new System.Drawing.Point(761, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::MyBankProject.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.pbRefresh.Location = new System.Drawing.Point(152, 119);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(35, 29);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 23;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pbFindClientSettings
            // 
            this.pbFindClientSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFindClientSettings.Image = global::MyBankProject.Properties.Resources._4781833_filter_filters_funnel_list_navigation_icon;
            this.pbFindClientSettings.Location = new System.Drawing.Point(256, 61);
            this.pbFindClientSettings.Name = "pbFindClientSettings";
            this.pbFindClientSettings.Size = new System.Drawing.Size(19, 25);
            this.pbFindClientSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFindClientSettings.TabIndex = 18;
            this.pbFindClientSettings.TabStop = false;
            this.pbFindClientSettings.Click += new System.EventHandler(this.pbFindClientSettings_Click);
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchIcon.Image = global::MyBankProject.Properties.Resources._211817_search_strong_icon;
            this.pbSearchIcon.Location = new System.Drawing.Point(216, 61);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(27, 25);
            this.pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchIcon.TabIndex = 16;
            this.pbSearchIcon.TabStop = false;
            this.pbSearchIcon.Click += new System.EventHandler(this.pbSearchIcon_Click);
            // 
            // frmManageUsersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumOfUsers);
            this.Controls.Add(this.gbFindBy);
            this.Controls.Add(this.pbFindClientSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbSearchIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindUser);
            this.Controls.Add(this.dgvUsersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageUsersScreen";
            this.Text = "frmManageUsersScreen";
            this.Load += new System.EventHandler(this.frmManageUsersScreen_Load);
            this.Click += new System.EventHandler(this.frmManageUsersScreen_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbFindBy.ResumeLayout(false);
            this.gbFindBy.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindClientSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvUsersList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOfUsers;
        private Guna.UI2.WinForms.Guna2GroupBox gbFindBy;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbAddress;
        private System.Windows.Forms.RadioButton rbUsername;
        private System.Windows.Forms.PictureBox pbFindClientSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOrderUsersListDESC;
        private System.Windows.Forms.RadioButton rbOrderUsersListASC;
        private System.Windows.Forms.PictureBox pbSearchIcon;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFindUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pbRefresh;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}