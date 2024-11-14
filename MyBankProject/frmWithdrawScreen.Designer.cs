namespace MyBankProject
{
    partial class frmWithdrawScreen
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
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudWithdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAccountsNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.Blue;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnWithdraw.ForeColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Location = new System.Drawing.Point(91, 380);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(198, 43);
            this.btnWithdraw.TabIndex = 14;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Impact", 13.25F);
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.Olive;
            this.lblBalanceAmount.Location = new System.Drawing.Point(291, 220);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(30, 22);
            this.lblBalanceAmount.TabIndex = 13;
            this.lblBalanceAmount.Text = "0$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(253, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(22, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter Amount To Withdraw";
            // 
            // nudWithdrawAmount
            // 
            this.nudWithdrawAmount.Location = new System.Drawing.Point(28, 308);
            this.nudWithdrawAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudWithdrawAmount.Name = "nudWithdrawAmount";
            this.nudWithdrawAmount.Size = new System.Drawing.Size(120, 20);
            this.nudWithdrawAmount.TabIndex = 10;
            this.nudWithdrawAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudWithdrawAmount.ValueChanged += new System.EventHandler(this.nudWithdrawAmount_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(24, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose Account Number";
            // 
            // cbAccountsNumber
            // 
            this.cbAccountsNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccountsNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccountsNumber.FormattingEnabled = true;
            this.cbAccountsNumber.Location = new System.Drawing.Point(30, 148);
            this.cbAccountsNumber.Name = "cbAccountsNumber";
            this.cbAccountsNumber.Size = new System.Drawing.Size(164, 21);
            this.cbAccountsNumber.TabIndex = 8;
            this.cbAccountsNumber.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbAccountsNumber.Leave += new System.EventHandler(this.cbAccountsNumber_Leave);
            this.cbAccountsNumber.Validating += new System.ComponentModel.CancelEventHandler(this.cbAccountsNumber_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(91, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Withdraw Screen";
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
            // pbRefresh
            // 
            this.pbRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRefresh.Image = global::MyBankProject.Properties.Resources._2849811_refresh_arrows_multimedia_media_icon;
            this.pbRefresh.Location = new System.Drawing.Point(327, 380);
            this.pbRefresh.Name = "pbRefresh";
            this.pbRefresh.Size = new System.Drawing.Size(35, 29);
            this.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRefresh.TabIndex = 24;
            this.pbRefresh.TabStop = false;
            this.pbRefresh.Click += new System.EventHandler(this.pbRefresh_Click);
            // 
            // frmWithdrawScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 540);
            this.Controls.Add(this.pbRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudWithdrawAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccountsNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWithdrawScreen";
            this.Text = "frmWithdrawScreen";
            this.Load += new System.EventHandler(this.frmWithdrawScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdrawAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudWithdrawAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAccountsNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.PictureBox pbRefresh;
    }
}