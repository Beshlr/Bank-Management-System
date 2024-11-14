namespace MyBankProject
{
    partial class frmLoginRegisters
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtFindUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.rbOrderUsersListASC = new System.Windows.Forms.RadioButton();
            this.rbOrderUsersListDESC = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOfRecords = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLoginLogsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginLogsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Find Login Record";
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
            this.txtFindUser.Location = new System.Drawing.Point(8, 78);
            this.txtFindUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFindUser.Name = "txtFindUser";
            this.txtFindUser.PasswordChar = '\0';
            this.txtFindUser.PlaceholderText = "Enter Username";
            this.txtFindUser.SelectedText = "";
            this.txtFindUser.Size = new System.Drawing.Size(242, 29);
            this.txtFindUser.TabIndex = 26;
            this.txtFindUser.TextChanged += new System.EventHandler(this.txtFindUser_TextChanged);
            // 
            // rbOrderUsersListASC
            // 
            this.rbOrderUsersListASC.AutoSize = true;
            this.rbOrderUsersListASC.Checked = true;
            this.rbOrderUsersListASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderUsersListASC.Location = new System.Drawing.Point(26, 68);
            this.rbOrderUsersListASC.Name = "rbOrderUsersListASC";
            this.rbOrderUsersListASC.Size = new System.Drawing.Size(55, 17);
            this.rbOrderUsersListASC.TabIndex = 0;
            this.rbOrderUsersListASC.TabStop = true;
            this.rbOrderUsersListASC.Text = "Oldest";
            this.rbOrderUsersListASC.UseVisualStyleBackColor = true;
            this.rbOrderUsersListASC.CheckedChanged += new System.EventHandler(this.rbOrderUsersListASC_CheckedChanged);
            this.rbOrderUsersListASC.Click += new System.EventHandler(this.rbOrderUsersListASC_CheckedChanged);
            // 
            // rbOrderUsersListDESC
            // 
            this.rbOrderUsersListDESC.AutoSize = true;
            this.rbOrderUsersListDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderUsersListDESC.Location = new System.Drawing.Point(103, 68);
            this.rbOrderUsersListDESC.Name = "rbOrderUsersListDESC";
            this.rbOrderUsersListDESC.Size = new System.Drawing.Size(61, 17);
            this.rbOrderUsersListDESC.TabIndex = 1;
            this.rbOrderUsersListDESC.Text = "Newest";
            this.rbOrderUsersListDESC.UseVisualStyleBackColor = true;
            this.rbOrderUsersListDESC.CheckedChanged += new System.EventHandler(this.rbOrderUsersListDESC_CheckedChanged);
            this.rbOrderUsersListDESC.Click += new System.EventHandler(this.rbOrderUsersListDESC_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(40, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Login Record (s) Found";
            // 
            // lblNumOfRecords
            // 
            this.lblNumOfRecords.AutoSize = true;
            this.lblNumOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumOfRecords.Location = new System.Drawing.Point(5, 144);
            this.lblNumOfRecords.Name = "lblNumOfRecords";
            this.lblNumOfRecords.Size = new System.Drawing.Size(18, 20);
            this.lblNumOfRecords.TabIndex = 32;
            this.lblNumOfRecords.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOrderUsersListDESC);
            this.groupBox1.Controls.Add(this.rbOrderUsersListASC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(592, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // dgvLoginLogsList
            // 
            this.dgvLoginLogsList.AllowUserToAddRows = false;
            this.dgvLoginLogsList.AllowUserToDeleteRows = false;
            this.dgvLoginLogsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLoginLogsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoginLogsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoginLogsList.ColumnHeadersHeight = 4;
            this.dgvLoginLogsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoginLogsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLoginLogsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoginLogsList.Location = new System.Drawing.Point(14, 173);
            this.dgvLoginLogsList.Name = "dgvLoginLogsList";
            this.dgvLoginLogsList.ReadOnly = true;
            this.dgvLoginLogsList.RowHeadersVisible = false;
            this.dgvLoginLogsList.Size = new System.Drawing.Size(769, 257);
            this.dgvLoginLogsList.TabIndex = 25;
            this.dgvLoginLogsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoginLogsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLoginLogsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLoginLogsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLoginLogsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLoginLogsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoginLogsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoginLogsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLoginLogsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLoginLogsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLoginLogsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLoginLogsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLoginLogsList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvLoginLogsList.ThemeStyle.ReadOnly = true;
            this.dgvLoginLogsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLoginLogsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLoginLogsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLoginLogsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLoginLogsList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLoginLogsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLoginLogsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox1.Location = new System.Drawing.Point(760, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::MyBankProject.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.pbRefresh.Location = new System.Drawing.Point(232, 138);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(35, 29);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 34;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchIcon.Image = global::MyBankProject.Properties.Resources._211817_search_strong_icon;
            this.pbSearchIcon.Location = new System.Drawing.Point(215, 80);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(27, 25);
            this.pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchIcon.TabIndex = 28;
            this.pbSearchIcon.TabStop = false;
            // 
            // frmLoginRegisters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.pbSearchIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumOfRecords);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvLoginLogsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoginRegisters";
            this.Text = "frmLoginRegisters";
            this.Load += new System.EventHandler(this.frmLoginRegisters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoginLogsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.PictureBox pbSearchIcon;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFindUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOfRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOrderUsersListDESC;
        private System.Windows.Forms.RadioButton rbOrderUsersListASC;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLoginLogsList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}