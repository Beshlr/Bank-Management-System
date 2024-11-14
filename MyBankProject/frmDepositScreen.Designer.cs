namespace MyBankProject
{
    partial class frmDepositScreen
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
            this.cbAccountsNumber = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDepositAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(94, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposit Screen";
            // 
            // cbAccountsNumber
            // 
            this.cbAccountsNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccountsNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccountsNumber.FormattingEnabled = true;
            this.cbAccountsNumber.Location = new System.Drawing.Point(18, 140);
            this.cbAccountsNumber.Name = "cbAccountsNumber";
            this.cbAccountsNumber.Size = new System.Drawing.Size(164, 21);
            this.cbAccountsNumber.TabIndex = 1;
            this.cbAccountsNumber.SelectedIndexChanged += new System.EventHandler(this.cbAccountsNumber_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose Account Number";
            // 
            // nudDepositAmount
            // 
            this.nudDepositAmount.Location = new System.Drawing.Point(16, 300);
            this.nudDepositAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDepositAmount.Name = "nudDepositAmount";
            this.nudDepositAmount.Size = new System.Drawing.Size(120, 20);
            this.nudDepositAmount.TabIndex = 3;
            this.nudDepositAmount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(10, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Amount To Deposit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(241, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Balance";
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Impact", 13.25F);
            this.lblBalanceAmount.ForeColor = System.Drawing.Color.Olive;
            this.lblBalanceAmount.Location = new System.Drawing.Point(284, 212);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(30, 22);
            this.lblBalanceAmount.TabIndex = 6;
            this.lblBalanceAmount.Text = "0$";
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.Blue;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.btnDeposit.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeposit.Location = new System.Drawing.Point(87, 372);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(198, 43);
            this.btnDeposit.TabIndex = 7;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 20;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // frmDepositScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 448);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblBalanceAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudDepositAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccountsNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepositScreen";
            this.Text = "frmDepositScreen";
            this.Load += new System.EventHandler(this.frmDepositScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDepositAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAccountsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDepositAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Button btnDeposit;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}