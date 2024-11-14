namespace MyBankProject
{
    partial class frmCurrencyExchange
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEnterNewRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbFindBy = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.rbCode = new System.Windows.Forms.RadioButton();
            this.pbFindClientSettings = new System.Windows.Forms.PictureBox();
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumOfCurrencies = new System.Windows.Forms.Label();
            this.gbSorting = new System.Windows.Forms.GroupBox();
            this.rbOrderCurrenciesListDESC = new System.Windows.Forms.RadioButton();
            this.rbOrderCurrenciesListASC = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            this.txtSearchBarCurrency = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvCurrenciesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbCurrency1Code = new System.Windows.Forms.ComboBox();
            this.cbCurrency2Code = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbSwitch = new System.Windows.Forms.PictureBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblCurrency2Rate = new System.Windows.Forms.Label();
            this.lblCurrency1Rate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbFindBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindClientSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.gbSorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrenciesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateRateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // updateRateToolStripMenuItem
            // 
            this.updateRateToolStripMenuItem.Name = "updateRateToolStripMenuItem";
            this.updateRateToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.updateRateToolStripMenuItem.Text = "Update Rate";
            this.updateRateToolStripMenuItem.Click += new System.EventHandler(this.updateRateToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Cairo Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(189, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 631);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtEnterNewRate);
            this.tabPage1.Controls.Add(this.gbFindBy);
            this.tabPage1.Controls.Add(this.pbFindClientSettings);
            this.tabPage1.Controls.Add(this.pbRefresh);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblNumOfCurrencies);
            this.tabPage1.Controls.Add(this.gbSorting);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.pbSearchIcon);
            this.tabPage1.Controls.Add(this.txtSearchBarCurrency);
            this.tabPage1.Controls.Add(this.dgvCurrenciesList);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 589);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Currencies List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(481, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 45;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEnterNewRate
            // 
            this.txtEnterNewRate.BorderColor = System.Drawing.Color.Black;
            this.txtEnterNewRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnterNewRate.DefaultText = "";
            this.txtEnterNewRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnterNewRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnterNewRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterNewRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnterNewRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterNewRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEnterNewRate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnterNewRate.Location = new System.Drawing.Point(375, 199);
            this.txtEnterNewRate.Name = "txtEnterNewRate";
            this.txtEnterNewRate.PasswordChar = '\0';
            this.txtEnterNewRate.PlaceholderText = "Enter New Rate";
            this.txtEnterNewRate.SelectedText = "";
            this.txtEnterNewRate.Size = new System.Drawing.Size(183, 39);
            this.txtEnterNewRate.TabIndex = 44;
            this.txtEnterNewRate.Visible = false;
            // 
            // gbFindBy
            // 
            this.gbFindBy.Controls.Add(this.rbName);
            this.gbFindBy.Controls.Add(this.rbCountry);
            this.gbFindBy.Controls.Add(this.rbCode);
            this.gbFindBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbFindBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.gbFindBy.Location = new System.Drawing.Point(355, 79);
            this.gbFindBy.Name = "gbFindBy";
            this.gbFindBy.Size = new System.Drawing.Size(231, 100);
            this.gbFindBy.TabIndex = 43;
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
            // rbCountry
            // 
            this.rbCountry.AutoSize = true;
            this.rbCountry.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbCountry.Location = new System.Drawing.Point(135, 50);
            this.rbCountry.Name = "rbCountry";
            this.rbCountry.Size = new System.Drawing.Size(66, 17);
            this.rbCountry.TabIndex = 1;
            this.rbCountry.Text = "Country";
            this.rbCountry.UseVisualStyleBackColor = true;
            this.rbCountry.CheckedChanged += new System.EventHandler(this.rbCountry_CheckedChanged);
            // 
            // rbCode
            // 
            this.rbCode.AutoSize = true;
            this.rbCode.Checked = true;
            this.rbCode.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.rbCode.Location = new System.Drawing.Point(18, 50);
            this.rbCode.Name = "rbCode";
            this.rbCode.Size = new System.Drawing.Size(52, 17);
            this.rbCode.TabIndex = 0;
            this.rbCode.TabStop = true;
            this.rbCode.Text = "Code";
            this.rbCode.UseVisualStyleBackColor = true;
            this.rbCode.Click += new System.EventHandler(this.rbCode_CheckedChanged);
            // 
            // pbFindClientSettings
            // 
            this.pbFindClientSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFindClientSettings.Image = global::MyBankProject.Properties.Resources._4781833_filter_filters_funnel_list_navigation_icon;
            this.pbFindClientSettings.Location = new System.Drawing.Point(317, 115);
            this.pbFindClientSettings.Name = "pbFindClientSettings";
            this.pbFindClientSettings.Size = new System.Drawing.Size(19, 25);
            this.pbFindClientSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFindClientSettings.TabIndex = 42;
            this.pbFindClientSettings.TabStop = false;
            this.pbFindClientSettings.Click += new System.EventHandler(this.pbFindClientSettings_Click);
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::MyBankProject.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.pbRefresh.Location = new System.Drawing.Point(245, 207);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(35, 29);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 41;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(76, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Currency (ies) Found";
            // 
            // lblNumOfCurrencies
            // 
            this.lblNumOfCurrencies.AutoSize = true;
            this.lblNumOfCurrencies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumOfCurrencies.Location = new System.Drawing.Point(35, 212);
            this.lblNumOfCurrencies.Name = "lblNumOfCurrencies";
            this.lblNumOfCurrencies.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNumOfCurrencies.Size = new System.Drawing.Size(18, 20);
            this.lblNumOfCurrencies.TabIndex = 39;
            this.lblNumOfCurrencies.Text = "0";
            // 
            // gbSorting
            // 
            this.gbSorting.Controls.Add(this.rbOrderCurrenciesListDESC);
            this.gbSorting.Controls.Add(this.rbOrderCurrenciesListASC);
            this.gbSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.gbSorting.Location = new System.Drawing.Point(633, 138);
            this.gbSorting.Name = "gbSorting";
            this.gbSorting.Size = new System.Drawing.Size(200, 100);
            this.gbSorting.TabIndex = 38;
            this.gbSorting.TabStop = false;
            this.gbSorting.Text = "Sort";
            // 
            // rbOrderCurrenciesListDESC
            // 
            this.rbOrderCurrenciesListDESC.AutoSize = true;
            this.rbOrderCurrenciesListDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderCurrenciesListDESC.Location = new System.Drawing.Point(115, 68);
            this.rbOrderCurrenciesListDESC.Name = "rbOrderCurrenciesListDESC";
            this.rbOrderCurrenciesListDESC.Size = new System.Drawing.Size(54, 17);
            this.rbOrderCurrenciesListDESC.TabIndex = 1;
            this.rbOrderCurrenciesListDESC.Text = "DESC";
            this.rbOrderCurrenciesListDESC.UseVisualStyleBackColor = true;
            this.rbOrderCurrenciesListDESC.Click += new System.EventHandler(this.rbOrderCurrenciesListDESC_CheckedChanged);
            // 
            // rbOrderCurrenciesListASC
            // 
            this.rbOrderCurrenciesListASC.AutoSize = true;
            this.rbOrderCurrenciesListASC.Checked = true;
            this.rbOrderCurrenciesListASC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rbOrderCurrenciesListASC.Location = new System.Drawing.Point(26, 68);
            this.rbOrderCurrenciesListASC.Name = "rbOrderCurrenciesListASC";
            this.rbOrderCurrenciesListASC.Size = new System.Drawing.Size(46, 17);
            this.rbOrderCurrenciesListASC.TabIndex = 0;
            this.rbOrderCurrenciesListASC.TabStop = true;
            this.rbOrderCurrenciesListASC.Text = "ASC";
            this.rbOrderCurrenciesListASC.UseVisualStyleBackColor = true;
            this.rbOrderCurrenciesListASC.Click += new System.EventHandler(this.rbOrderCurrenciesListASC_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Currencies List";
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchIcon.Image = global::MyBankProject.Properties.Resources._211817_search_strong_icon;
            this.pbSearchIcon.Location = new System.Drawing.Point(280, 115);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(27, 23);
            this.pbSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSearchIcon.TabIndex = 36;
            this.pbSearchIcon.TabStop = false;
            // 
            // txtSearchBarCurrency
            // 
            this.txtSearchBarCurrency.Animated = true;
            this.txtSearchBarCurrency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearchBarCurrency.BorderRadius = 10;
            this.txtSearchBarCurrency.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.txtSearchBarCurrency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBarCurrency.DefaultText = "";
            this.txtSearchBarCurrency.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchBarCurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchBarCurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBarCurrency.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchBarCurrency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBarCurrency.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearchBarCurrency.ForeColor = System.Drawing.Color.Black;
            this.txtSearchBarCurrency.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchBarCurrency.Location = new System.Drawing.Point(38, 113);
            this.txtSearchBarCurrency.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchBarCurrency.Name = "txtSearchBarCurrency";
            this.txtSearchBarCurrency.PasswordChar = '\0';
            this.txtSearchBarCurrency.PlaceholderText = "Enter Currency Code";
            this.txtSearchBarCurrency.SelectedText = "";
            this.txtSearchBarCurrency.Size = new System.Drawing.Size(273, 27);
            this.txtSearchBarCurrency.TabIndex = 35;
            this.txtSearchBarCurrency.TextChanged += new System.EventHandler(this.txtAccountNO_TextChanged);
            this.txtSearchBarCurrency.Enter += new System.EventHandler(this.txtSearchBarCurrency_Enter);
            // 
            // dgvCurrenciesList
            // 
            this.dgvCurrenciesList.AllowUserToAddRows = false;
            this.dgvCurrenciesList.AllowUserToDeleteRows = false;
            this.dgvCurrenciesList.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCurrenciesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrenciesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrenciesList.ColumnHeadersHeight = 4;
            this.dgvCurrenciesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCurrenciesList.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrenciesList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurrenciesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCurrenciesList.Location = new System.Drawing.Point(38, 244);
            this.dgvCurrenciesList.Name = "dgvCurrenciesList";
            this.dgvCurrenciesList.ReadOnly = true;
            this.dgvCurrenciesList.RowHeadersVisible = false;
            this.dgvCurrenciesList.Size = new System.Drawing.Size(795, 314);
            this.dgvCurrenciesList.TabIndex = 34;
            this.dgvCurrenciesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCurrenciesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCurrenciesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCurrenciesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCurrenciesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCurrenciesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCurrenciesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCurrenciesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCurrenciesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCurrenciesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCurrenciesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCurrenciesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCurrenciesList.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvCurrenciesList.ThemeStyle.ReadOnly = true;
            this.dgvCurrenciesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCurrenciesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCurrenciesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCurrenciesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCurrenciesList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCurrenciesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCurrenciesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox1.Location = new System.Drawing.Point(855, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbCurrency1Code);
            this.tabPage2.Controls.Add(this.cbCurrency2Code);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.nudAmount);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.lblResult);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.pbSwitch);
            this.tabPage2.Controls.Add(this.btnConvert);
            this.tabPage2.Controls.Add(this.lblCurrency2Rate);
            this.tabPage2.Controls.Add(this.lblCurrency1Rate);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 589);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Currensy Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbCurrency1Code
            // 
            this.cbCurrency1Code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCurrency1Code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrency1Code.FormattingEnabled = true;
            this.cbCurrency1Code.Location = new System.Drawing.Point(227, 129);
            this.cbCurrency1Code.Name = "cbCurrency1Code";
            this.cbCurrency1Code.Size = new System.Drawing.Size(121, 37);
            this.cbCurrency1Code.TabIndex = 36;
            this.cbCurrency1Code.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            this.cbCurrency1Code.TextChanged += new System.EventHandler(this.cbCurrency1Code_TextChanged);
            // 
            // cbCurrency2Code
            // 
            this.cbCurrency2Code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCurrency2Code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCurrency2Code.FormattingEnabled = true;
            this.cbCurrency2Code.Location = new System.Drawing.Point(526, 129);
            this.cbCurrency2Code.Name = "cbCurrency2Code";
            this.cbCurrency2Code.Size = new System.Drawing.Size(121, 37);
            this.cbCurrency2Code.TabIndex = 35;
            this.cbCurrency2Code.SelectedIndexChanged += new System.EventHandler(this.cbCurrency2Code_SelectedIndexChanged);
            this.cbCurrency2Code.TextChanged += new System.EventHandler(this.cbCurrency2Code_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MyBankProject.Properties.Resources._9004772_cross_delete_cancel_remove_icon;
            this.pictureBox2.Location = new System.Drawing.Point(851, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(459, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(227, 330);
            this.nudAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(122, 36);
            this.nudAmount.TabIndex = 27;
            this.nudAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(33, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(427, 29);
            this.label10.TabIndex = 26;
            this.label10.Text = "Currency Calculator";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Elephant", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Olive;
            this.lblResult.Location = new System.Drawing.Point(580, 336);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(30, 30);
            this.lblResult.TabIndex = 25;
            this.lblResult.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(545, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Result";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(535, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(232, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Rate";
            // 
            // pbSwitch
            // 
            this.pbSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSwitch.Image = global::MyBankProject.Properties.Resources._7124162_switch_horizontal_icon;
            this.pbSwitch.Location = new System.Drawing.Point(432, 140);
            this.pbSwitch.Name = "pbSwitch";
            this.pbSwitch.Size = new System.Drawing.Size(28, 25);
            this.pbSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSwitch.TabIndex = 20;
            this.pbSwitch.TabStop = false;
            this.pbSwitch.Click += new System.EventHandler(this.pbSwitch_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Blue;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnConvert.ForeColor = System.Drawing.Color.White;
            this.btnConvert.Location = new System.Drawing.Point(227, 428);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(203, 44);
            this.btnConvert.TabIndex = 19;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCurrency2Rate
            // 
            this.lblCurrency2Rate.AutoSize = true;
            this.lblCurrency2Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCurrency2Rate.ForeColor = System.Drawing.Color.Green;
            this.lblCurrency2Rate.Location = new System.Drawing.Point(583, 204);
            this.lblCurrency2Rate.Name = "lblCurrency2Rate";
            this.lblCurrency2Rate.Size = new System.Drawing.Size(27, 20);
            this.lblCurrency2Rate.TabIndex = 18;
            this.lblCurrency2Rate.Text = "0$";
            // 
            // lblCurrency1Rate
            // 
            this.lblCurrency1Rate.AutoSize = true;
            this.lblCurrency1Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCurrency1Rate.ForeColor = System.Drawing.Color.Green;
            this.lblCurrency1Rate.Location = new System.Drawing.Point(283, 204);
            this.lblCurrency1Rate.Name = "lblCurrency1Rate";
            this.lblCurrency1Rate.Size = new System.Drawing.Size(27, 20);
            this.lblCurrency1Rate.TabIndex = 17;
            this.lblCurrency1Rate.Text = "0$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label8.Location = new System.Drawing.Point(232, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(522, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(223, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "From";
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
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(-3, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(192, 651);
            this.guna2Panel1.TabIndex = 32;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome\r\nMr :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmCurrencyExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 645);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCurrencyExchange";
            this.Text = "frmCurrencyExchange";
            this.Load += new System.EventHandler(this.frmCurrencyExchange_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbFindBy.ResumeLayout(false);
            this.gbFindBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFindClientSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.gbSorting.ResumeLayout(false);
            this.gbSorting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrenciesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateRateToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2TextBox txtEnterNewRate;
        private Guna.UI2.WinForms.Guna2GroupBox gbFindBy;
        private System.Windows.Forms.RadioButton rbName;
        private System.Windows.Forms.RadioButton rbCountry;
        private System.Windows.Forms.RadioButton rbCode;
        private System.Windows.Forms.PictureBox pbFindClientSettings;
        private System.Windows.Forms.PictureBox pbRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumOfCurrencies;
        private System.Windows.Forms.GroupBox gbSorting;
        private System.Windows.Forms.RadioButton rbOrderCurrenciesListDESC;
        private System.Windows.Forms.RadioButton rbOrderCurrenciesListASC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbSearchIcon;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchBarCurrency;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCurrenciesList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbSwitch;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblCurrency2Rate;
        private System.Windows.Forms.Label lblCurrency1Rate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbCurrency1Code;
        private System.Windows.Forms.ComboBox cbCurrency2Code;
    }
}