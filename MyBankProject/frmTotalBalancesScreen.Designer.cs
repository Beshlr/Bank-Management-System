namespace MyBankProject
{
    partial class frmTotalBalancesScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.dgvClientsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtAccountNO = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbSorting = new System.Windows.Forms.GroupBox();
            this.rbOrderClientListDESC = new System.Windows.Forms.RadioButton();
            this.rbOrderClientListASC = new System.Windows.Forms.RadioButton();
            this.lblNumOfClients = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).BeginInit();
            this.gbSorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(41, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Balances Of Clients Is :";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Olive;
            this.lblTotalAmount.Location = new System.Drawing.Point(386, 21);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(39, 29);
            this.lblTotalAmount.TabIndex = 2;
            this.lblTotalAmount.Text = "0$";
            // 
            // dgvClientsList
            // 
            this.dgvClientsList.AllowUserToAddRows = false;
            this.dgvClientsList.AllowUserToDeleteRows = false;
            this.dgvClientsList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClientsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientsList.ColumnHeadersHeight = 15;
            this.dgvClientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientsList.Location = new System.Drawing.Point(20, 162);
            this.dgvClientsList.Name = "dgvClientsList";
            this.dgvClientsList.ReadOnly = true;
            this.dgvClientsList.RowHeadersVisible = false;
            this.dgvClientsList.Size = new System.Drawing.Size(754, 276);
            this.dgvClientsList.TabIndex = 3;
            this.dgvClientsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientsList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClientsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClientsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClientsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClientsList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvClientsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClientsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClientsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClientsList.ThemeStyle.HeaderStyle.Height = 15;
            this.dgvClientsList.ThemeStyle.ReadOnly = true;
            this.dgvClientsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClientsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClientsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClientsList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClientsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClientsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.txtAccountNO.Location = new System.Drawing.Point(46, 73);
            this.txtAccountNO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAccountNO.Name = "txtAccountNO";
            this.txtAccountNO.PasswordChar = '\0';
            this.txtAccountNO.PlaceholderText = "Enter Account Number";
            this.txtAccountNO.SelectedText = "";
            this.txtAccountNO.Size = new System.Drawing.Size(273, 23);
            this.txtAccountNO.TabIndex = 4;
            this.txtAccountNO.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // gbSorting
            // 
            this.gbSorting.Controls.Add(this.rbOrderClientListDESC);
            this.gbSorting.Controls.Add(this.rbOrderClientListASC);
            this.gbSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gbSorting.Location = new System.Drawing.Point(562, 45);
            this.gbSorting.Name = "gbSorting";
            this.gbSorting.Size = new System.Drawing.Size(200, 100);
            this.gbSorting.TabIndex = 9;
            this.gbSorting.TabStop = false;
            this.gbSorting.Text = "Sort";
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
            // lblNumOfClients
            // 
            this.lblNumOfClients.AutoSize = true;
            this.lblNumOfClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumOfClients.Location = new System.Drawing.Point(49, 129);
            this.lblNumOfClients.Name = "lblNumOfClients";
            this.lblNumOfClients.Size = new System.Drawing.Size(18, 20);
            this.lblNumOfClients.TabIndex = 10;
            this.lblNumOfClients.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(70, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Client (s) Found";
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::MyBankProject.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.pbRefresh.Location = new System.Drawing.Point(200, 125);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(35, 29);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 24;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchIcon.Image = global::MyBankProject.Properties.Resources._211817_search_strong_icon;
            this.pbSearchIcon.Location = new System.Drawing.Point(288, 75);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(27, 23);
            this.pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchIcon.TabIndex = 5;
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
            // frmTotalBalancesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumOfClients);
            this.Controls.Add(this.gbSorting);
            this.Controls.Add(this.pbSearchIcon);
            this.Controls.Add(this.txtAccountNO);
            this.Controls.Add(this.dgvClientsList);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTotalBalancesScreen";
            this.Text = "frmTotalBalancesScreen";
            this.Load += new System.EventHandler(this.frmTotalBalancesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsList)).EndInit();
            this.gbSorting.ResumeLayout(false);
            this.gbSorting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalAmount;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClientsList;
        private Guna.UI2.WinForms.Guna2TextBox txtAccountNO;
        private System.Windows.Forms.PictureBox pbSearchIcon;
        private System.Windows.Forms.GroupBox gbSorting;
        private System.Windows.Forms.RadioButton rbOrderClientListDESC;
        private System.Windows.Forms.RadioButton rbOrderClientListASC;
        private System.Windows.Forms.Label lblNumOfClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbRefresh;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}