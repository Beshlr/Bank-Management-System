namespace MyBankProject
{
    partial class frmTransferScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbAccountsNumber1 = new System.Windows.Forms.ComboBox();
            this.cbAccountsNumber2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAmountToTransfer = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClient1Balance = new System.Windows.Forms.Label();
            this.lblClient2Balance = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbSwitch = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(88, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer Screen";
            // 
            // cbAccountsNumber1
            // 
            this.cbAccountsNumber1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccountsNumber1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccountsNumber1.FormattingEnabled = true;
            this.cbAccountsNumber1.Location = new System.Drawing.Point(12, 145);
            this.cbAccountsNumber1.Name = "cbAccountsNumber1";
            this.cbAccountsNumber1.Size = new System.Drawing.Size(121, 21);
            this.cbAccountsNumber1.TabIndex = 1;
            this.cbAccountsNumber1.SelectedIndexChanged += new System.EventHandler(this.cbAccountsNumber1_SelectedIndexChanged);
            // 
            // cbAccountsNumber2
            // 
            this.cbAccountsNumber2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccountsNumber2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccountsNumber2.FormattingEnabled = true;
            this.cbAccountsNumber2.Location = new System.Drawing.Point(217, 145);
            this.cbAccountsNumber2.Name = "cbAccountsNumber2";
            this.cbAccountsNumber2.Size = new System.Drawing.Size(121, 21);
            this.cbAccountsNumber2.TabIndex = 2;
            this.cbAccountsNumber2.SelectedIndexChanged += new System.EventHandler(this.cbAccountsNumber2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(215, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // nudAmountToTransfer
            // 
            this.nudAmountToTransfer.Location = new System.Drawing.Point(120, 289);
            this.nudAmountToTransfer.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAmountToTransfer.Name = "nudAmountToTransfer";
            this.nudAmountToTransfer.Size = new System.Drawing.Size(120, 20);
            this.nudAmountToTransfer.TabIndex = 5;
            this.nudAmountToTransfer.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAmountToTransfer.ValueChanged += new System.EventHandler(this.nudAmountToTransfer_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(117, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            // 
            // lblClient1Balance
            // 
            this.lblClient1Balance.AutoSize = true;
            this.lblClient1Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblClient1Balance.ForeColor = System.Drawing.Color.Green;
            this.lblClient1Balance.Location = new System.Drawing.Point(12, 207);
            this.lblClient1Balance.Name = "lblClient1Balance";
            this.lblClient1Balance.Size = new System.Drawing.Size(27, 20);
            this.lblClient1Balance.TabIndex = 7;
            this.lblClient1Balance.Text = "0$";
            // 
            // lblClient2Balance
            // 
            this.lblClient2Balance.AutoSize = true;
            this.lblClient2Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblClient2Balance.ForeColor = System.Drawing.Color.Green;
            this.lblClient2Balance.Location = new System.Drawing.Point(312, 207);
            this.lblClient2Balance.Name = "lblClient2Balance";
            this.lblClient2Balance.Size = new System.Drawing.Size(27, 20);
            this.lblClient2Balance.TabIndex = 8;
            this.lblClient2Balance.Text = "0$";
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.Blue;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(81, 370);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(201, 31);
            this.btnTransfer.TabIndex = 9;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(280, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Balance";
            // 
            // pbSwitch
            // 
            this.pbSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSwitch.Image = global::MyBankProject.Properties.Resources._7124162_switch_horizontal_icon;
            this.pbSwitch.Location = new System.Drawing.Point(161, 143);
            this.pbSwitch.Name = "pbSwitch";
            this.pbSwitch.Size = new System.Drawing.Size(28, 25);
            this.pbSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSwitch.TabIndex = 10;
            this.pbSwitch.TabStop = false;
            this.pbSwitch.Click += new System.EventHandler(this.pbSwitch_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::MyBankProject.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.pbRefresh.Location = new System.Drawing.Point(316, 370);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(35, 29);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 24;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // frmTransferScreen
            // 
            this.AcceptButton = this.btnTransfer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 497);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbSwitch);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblClient2Balance);
            this.Controls.Add(this.lblClient1Balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudAmountToTransfer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccountsNumber2);
            this.Controls.Add(this.cbAccountsNumber1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferScreen";
            this.Text = "frmTransferScreen";
            this.Load += new System.EventHandler(this.frmTransferScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountToTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAccountsNumber1;
        private System.Windows.Forms.ComboBox cbAccountsNumber2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAmountToTransfer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClient1Balance;
        private System.Windows.Forms.Label lblClient2Balance;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.PictureBox pbSwitch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pbRefresh;
    }
}