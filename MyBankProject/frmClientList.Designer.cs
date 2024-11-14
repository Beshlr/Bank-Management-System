namespace MyBankProject
{
    partial class frmClientList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientList));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFindClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbOrderClientListDESC = new System.Windows.Forms.RadioButton();
            this.rbOrderClientListASC = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbAccountNO = new System.Windows.Forms.RadioButton();
            this.rbBalance = new System.Windows.Forms.RadioButton();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.gbFindBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOfClients = new System.Windows.Forms.Label();
            this.dgvClientList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pbFindClientSettings = new System.Windows.Forms.PictureBox();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFindBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindClientSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClientToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 70);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // txtFindClient
            // 
            this.txtFindClient.BorderRadius = 10;
            this.txtFindClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindClient.DefaultText = "";
            this.txtFindClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindClient.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFindClient.ForeColor = System.Drawing.Color.Black;
            this.txtFindClient.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindClient.Location = new System.Drawing.Point(12, 59);
            this.txtFindClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindClient.Name = "txtFindClient";
            this.txtFindClient.PasswordChar = '\0';
            this.txtFindClient.PlaceholderText = "Enter AccNO";
            this.txtFindClient.SelectedText = "";
            this.txtFindClient.Size = new System.Drawing.Size(242, 29);
            this.txtFindClient.TabIndex = 2;
            this.txtFindClient.TextChanged += new System.EventHandler(this.txtFindClient_TextChanged);
            this.txtFindClient.Enter += new System.EventHandler(this.txtFindClient_Enter);
            this.txtFindClient.MouseEnter += new System.EventHandler(this.txtFindClient_MouseEnter);
            this.txtFindClient.MouseLeave += new System.EventHandler(this.txtFindClient_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrderClientListDESC);
            this.groupBox1.Controls.Add(this.rbOrderClientListASC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(587, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // rbOrderClientListDESC
            // 
            this.rbOrderClientListDESC.AutoSize = true;
            this.rbOrderClientListDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderClientListDESC.Location = new System.Drawing.Point(103, 68);
            this.rbOrderClientListDESC.Name = "rbOrderClientListDESC";
            this.rbOrderClientListDESC.Size = new System.Drawing.Size(54, 17);
            this.rbOrderClientListDESC.TabIndex = 1;
            this.rbOrderClientListDESC.Text = "DESC";
            this.rbOrderClientListDESC.UseVisualStyleBackColor = true;
            this.rbOrderClientListDESC.CheckedChanged += new System.EventHandler(this.rbOrderClientListDESC_CheckedChanged);
            // 
            // rbOrderClientListASC
            // 
            this.rbOrderClientListASC.AutoSize = true;
            this.rbOrderClientListASC.Checked = true;
            this.rbOrderClientListASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderClientListASC.Location = new System.Drawing.Point(26, 68);
            this.rbOrderClientListASC.Name = "rbOrderClientListASC";
            this.rbOrderClientListASC.Size = new System.Drawing.Size(46, 17);
            this.rbOrderClientListASC.TabIndex = 0;
            this.rbOrderClientListASC.TabStop = true;
            this.rbOrderClientListASC.Text = "ASC";
            this.rbOrderClientListASC.UseVisualStyleBackColor = true;
            this.rbOrderClientListASC.CheckedChanged += new System.EventHandler(this.rbOrderClientListASC_CheckedChanged);
            // 
            // rbAccountNO
            // 
            this.rbAccountNO.AutoSize = true;
            this.rbAccountNO.Checked = true;
            this.rbAccountNO.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbAccountNO.Location = new System.Drawing.Point(18, 50);
            this.rbAccountNO.Name = "rbAccountNO";
            this.rbAccountNO.Size = new System.Drawing.Size(84, 17);
            this.rbAccountNO.TabIndex = 0;
            this.rbAccountNO.TabStop = true;
            this.rbAccountNO.Text = "AccountNO";
            this.rbAccountNO.UseVisualStyleBackColor = true;
            this.rbAccountNO.CheckedChanged += new System.EventHandler(this.rbAccountNO_CheckedChanged);
            // 
            // rbBalance
            // 
            this.rbBalance.AutoSize = true;
            this.rbBalance.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbBalance.Location = new System.Drawing.Point(135, 50);
            this.rbBalance.Name = "rbBalance";
            this.rbBalance.Size = new System.Drawing.Size(64, 17);
            this.rbBalance.TabIndex = 1;
            this.rbBalance.Text = "Balance";
            this.rbBalance.UseVisualStyleBackColor = true;
            this.rbBalance.CheckedChanged += new System.EventHandler(this.rbBalance_CheckedChanged);
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
            // gbFindBy
            // 
            this.gbFindBy.Controls.Add(this.rbName);
            this.gbFindBy.Controls.Add(this.rbBalance);
            this.gbFindBy.Controls.Add(this.rbAccountNO);
            this.gbFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFindBy.Location = new System.Drawing.Point(297, 25);
            this.gbFindBy.Name = "gbFindBy";
            this.gbFindBy.Size = new System.Drawing.Size(231, 100);
            this.gbFindBy.TabIndex = 8;
            this.gbFindBy.Text = "Find By";
            this.gbFindBy.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(34, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Client (s) Found";
            // 
            // lblNumOfClients
            // 
            this.lblNumOfClients.AutoSize = true;
            this.lblNumOfClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumOfClients.Location = new System.Drawing.Point(19, 132);
            this.lblNumOfClients.Name = "lblNumOfClients";
            this.lblNumOfClients.Size = new System.Drawing.Size(18, 20);
            this.lblNumOfClients.TabIndex = 12;
            this.lblNumOfClients.Text = "0";
            // 
            // dgvClientList
            // 
            this.dgvClientList.AllowUserToAddRows = false;
            this.dgvClientList.AllowUserToDeleteRows = false;
            this.dgvClientList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientList.ColumnHeadersHeight = 4;
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClientList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientList.Location = new System.Drawing.Point(0, 161);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.ReadOnly = true;
            this.dgvClientList.RowHeadersVisible = false;
            this.dgvClientList.Size = new System.Drawing.Size(800, 289);
            this.dgvClientList.TabIndex = 14;
            this.dgvClientList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClientList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClientList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClientList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClientList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvClientList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClientList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvClientList.ThemeStyle.ReadOnly = true;
            this.dgvClientList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClientList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClientList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClientList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvClientList_MouseDoubleClick);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::MyBankProject.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.pbRefresh.Location = new System.Drawing.Point(159, 127);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(35, 29);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 25;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pbFindClientSettings
            // 
            this.pbFindClientSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFindClientSettings.Image = global::MyBankProject.Properties.Resources._4781833_filter_filters_funnel_list_navigation_icon;
            this.pbFindClientSettings.Location = new System.Drawing.Point(259, 61);
            this.pbFindClientSettings.Name = "pbFindClientSettings";
            this.pbFindClientSettings.Size = new System.Drawing.Size(19, 25);
            this.pbFindClientSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFindClientSettings.TabIndex = 6;
            this.pbFindClientSettings.TabStop = false;
            this.pbFindClientSettings.Click += new System.EventHandler(this.pbFindClientSettings_Click);
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchIcon.Image = global::MyBankProject.Properties.Resources._211817_search_strong_icon;
            this.pbSearchIcon.Location = new System.Drawing.Point(219, 61);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(27, 25);
            this.pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchIcon.TabIndex = 4;
            this.pbSearchIcon.TabStop = false;
            this.pbSearchIcon.Click += new System.EventHandler(this.pbSearchIcon_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(760, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.dgvClientList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumOfClients);
            this.Controls.Add(this.gbFindBy);
            this.Controls.Add(this.pbFindClientSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbSearchIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClientList";
            this.Text = "Client List";
            this.Load += new System.EventHandler(this.frmClientList_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFindBy.ResumeLayout(false);
            this.gbFindBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindClientSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2TextBox txtFindClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSearchIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOrderClientListDESC;
        private System.Windows.Forms.RadioButton rbOrderClientListASC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pbFindClientSettings;
        private System.Windows.Forms.RadioButton rbAccountNO;
        private System.Windows.Forms.RadioButton rbBalance;
        private System.Windows.Forms.RadioButton rbName;
        private Guna.UI2.WinForms.Guna2GroupBox gbFindBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOfClients;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientList;
        private System.Windows.Forms.PictureBox pbRefresh;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}