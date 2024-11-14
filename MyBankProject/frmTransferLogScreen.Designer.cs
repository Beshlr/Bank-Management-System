namespace MyBankProject
{
    partial class frmTransferLogScreen
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
            this.gbSorting = new System.Windows.Forms.GroupBox();
            this.rbOrderClientListDESC = new System.Windows.Forms.RadioButton();
            this.rbOrderClientListASC = new System.Windows.Forms.RadioButton();
            this.txtAccountNO = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOfTransferLog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransferLogList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbSorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLogList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSorting
            // 
            this.gbSorting.Controls.Add(this.rbOrderClientListDESC);
            this.gbSorting.Controls.Add(this.rbOrderClientListASC);
            this.gbSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gbSorting.Location = new System.Drawing.Point(591, 64);
            this.gbSorting.Name = "gbSorting";
            this.gbSorting.Size = new System.Drawing.Size(200, 100);
            this.gbSorting.TabIndex = 10;
            this.gbSorting.TabStop = false;
            this.gbSorting.Text = "Sort";
            // 
            // rbOrderClientListDESC
            // 
            this.rbOrderClientListDESC.AutoSize = true;
            this.rbOrderClientListDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderClientListDESC.Location = new System.Drawing.Point(115, 68);
            this.rbOrderClientListDESC.Name = "rbOrderClientListDESC";
            this.rbOrderClientListDESC.Size = new System.Drawing.Size(61, 17);
            this.rbOrderClientListDESC.TabIndex = 1;
            this.rbOrderClientListDESC.Text = "Newest";
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
            this.rbOrderClientListASC.Size = new System.Drawing.Size(55, 17);
            this.rbOrderClientListASC.TabIndex = 0;
            this.rbOrderClientListASC.TabStop = true;
            this.rbOrderClientListASC.Text = "Oldest";
            this.rbOrderClientListASC.UseVisualStyleBackColor = true;
            this.rbOrderClientListASC.CheckedChanged += new System.EventHandler(this.rbOrderClientListASC_CheckedChanged);
            // 
            // txtAccountNO
            // 
            this.txtAccountNO.Animated = true;
            this.txtAccountNO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAccountNO.BorderRadius = 10;
            this.txtAccountNO.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtAccountNO.BorderThickness = 0;
            this.txtAccountNO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccountNO.DefaultText = "";
            this.txtAccountNO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccountNO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccountNO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccountNO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNO.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAccountNO.ForeColor = System.Drawing.Color.Black;
            this.txtAccountNO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAccountNO.Location = new System.Drawing.Point(20, 97);
            this.txtAccountNO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNO.Name = "txtAccountNO";
            this.txtAccountNO.PasswordChar = '\0';
            this.txtAccountNO.PlaceholderText = "Enter sAccNO";
            this.txtAccountNO.SelectedText = "";
            this.txtAccountNO.Size = new System.Drawing.Size(273, 23);
            this.txtAccountNO.TabIndex = 11;
            this.txtAccountNO.TextChanged += new System.EventHandler(this.txtAccountNO_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Record (s) Found";
            // 
            // lblNumOfTransferLog
            // 
            this.lblNumOfTransferLog.AutoSize = true;
            this.lblNumOfTransferLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumOfTransferLog.Location = new System.Drawing.Point(14, 143);
            this.lblNumOfTransferLog.Name = "lblNumOfTransferLog";
            this.lblNumOfTransferLog.Size = new System.Drawing.Size(18, 20);
            this.lblNumOfTransferLog.TabIndex = 14;
            this.lblNumOfTransferLog.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Transfer Log";
            // 
            // dgvTransferLogList
            // 
            this.dgvTransferLogList.AllowUserToAddRows = false;
            this.dgvTransferLogList.AllowUserToDeleteRows = false;
            this.dgvTransferLogList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTransferLogList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransferLogList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransferLogList.ColumnHeadersHeight = 15;
            this.dgvTransferLogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransferLogList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransferLogList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransferLogList.Location = new System.Drawing.Point(11, 196);
            this.dgvTransferLogList.Name = "dgvTransferLogList";
            this.dgvTransferLogList.ReadOnly = true;
            this.dgvTransferLogList.RowHeadersVisible = false;
            this.dgvTransferLogList.Size = new System.Drawing.Size(784, 244);
            this.dgvTransferLogList.TabIndex = 17;
            this.dgvTransferLogList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransferLogList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransferLogList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransferLogList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransferLogList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransferLogList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransferLogList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransferLogList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTransferLogList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransferLogList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransferLogList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransferLogList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransferLogList.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvTransferLogList.ThemeStyle.ReadOnly = true;
            this.dgvTransferLogList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransferLogList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransferLogList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransferLogList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransferLogList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTransferLogList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransferLogList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchIcon.Image = global::MyBankProject.Properties.Resources._211817_search_strong_icon;
            this.pbSearchIcon.Location = new System.Drawing.Point(262, 97);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(27, 23);
            this.pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchIcon.TabIndex = 12;
            this.pbSearchIcon.TabStop = false;
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
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MyBankProject.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.pictureBox1.Location = new System.Drawing.Point(173, 137);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmTransferLogScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvTransferLogList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumOfTransferLog);
            this.Controls.Add(this.pbSearchIcon);
            this.Controls.Add(this.txtAccountNO);
            this.Controls.Add(this.gbSorting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferLogScreen";
            this.Text = "frmTransferLogScreen";
            this.Load += new System.EventHandler(this.frmTransferLogScreen_Load);
            this.gbSorting.ResumeLayout(false);
            this.gbSorting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLogList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSorting;
        private System.Windows.Forms.RadioButton rbOrderClientListDESC;
        private System.Windows.Forms.RadioButton rbOrderClientListASC;
        private System.Windows.Forms.PictureBox pbSearchIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOfTransferLog;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransferLogList;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}