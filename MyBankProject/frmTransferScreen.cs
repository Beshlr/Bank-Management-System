using BankBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBussinessLayer;

namespace MyBankProject
{
    public partial class frmTransferScreen : Form
    {
        public string _Username = "";

        public frmTransferScreen(string Username)
        {
            InitializeComponent();
            _Username = Username;
            user = clsUser.FindByUsername(Username);
        }

        clsUser user = new clsUser();

        clsClient Client1 = new clsClient();
        clsClient Client2 = new clsClient();

        private void _FillAccountNumbersComboBox()
        {
            cbAccountsNumber1.Items.Clear();
            cbAccountsNumber2.Items.Clear();


            DataTable dt = clsClient.GetAllClients();
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToDouble(row["Balance"]) > 0)
                {
                    cbAccountsNumber1.Items.Add(row["AccountNO"]);
                }
                cbAccountsNumber2.Items.Add(row["AccountNO"]);

            }

        }

        private bool _SwitchAccNo = false;

        private void frmTransferScreen_Load(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();
        }

        private void cbAccountsNumber2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountsNumber2.Text == cbAccountsNumber1.Text && !_SwitchAccNo)
            {
                MessageBox.Show("Please choose an AccNO other than the one you are transferring from","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAccountsNumber2.SelectedItem = null;
                lblClient2Balance.Text = "0$";

            }
            else if(cbAccountsNumber2.SelectedItem!=null)
            {
                Client2 = clsClient.GetClientInfo(cbAccountsNumber2.Text);
                lblClient2Balance.Text = Client2.Balance.ToString() + "$";
                _SwitchAccNo = false;

            }

        }

        private void _FormatPage()
        {
            cbAccountsNumber2.SelectedItem = null;
            cbAccountsNumber1.SelectedItem = null;
            nudAmountToTransfer.Value = 50;
            lblClient1Balance.Text = "0$";
            lblClient2Balance.Text = "0$";
        }

        private void _ReloadScreen()
        {
            Client1 = clsClient.GetClientInfo(cbAccountsNumber1.Text);
            Client2 = clsClient.GetClientInfo(cbAccountsNumber2.Text);
            lblClient1Balance.Text = Client1.Balance.ToString() + "$";
            lblClient2Balance.Text = Client2.Balance.ToString() + "$";
            _FillAccountNumbersComboBox();
            nudAmountToTransfer.Value = 50;

        }

        private void cbAccountsNumber1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccountsNumber2.Text == cbAccountsNumber1.Text && !_SwitchAccNo)
            {
                MessageBox.Show("Please choose an AccNO other than the one you are transferring To", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAccountsNumber1.SelectedItem = null;
                lblClient1Balance.Text = "0$";
            }
            else if (cbAccountsNumber1.SelectedItem != null)
            {
                Client1 = clsClient.GetClientInfo(cbAccountsNumber1.Text);
                lblClient1Balance.Text = Client1.Balance.ToString() + "$";
                _SwitchAccNo = false;

            }
        }

        private void nudAmountToTransfer_ValueChanged(object sender, EventArgs e)
        {
            if(nudAmountToTransfer.Value > Client1.Balance)
            {
                nudAmountToTransfer.Value = Client1.Balance;
            }
        }



        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if(nudAmountToTransfer.Value == 0)
            {
                MessageBox.Show("Please Enter Amount More Than 0","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Client1.AccNO != Client2.AccNO)
            {
                if (MessageBox.Show(@"Are You Sure You Want To Transfer [" + nudAmountToTransfer.Value.ToString() + "] From [" + Client1.AccNO +
                                    "] To [" + Client2.AccNO + "] ?", "Congirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if ((Client1.WithdrawOp((double)nudAmountToTransfer.Value)) && (Client2.DepositOp((double)nudAmountToTransfer.Value)))
                    {
                        clsUser.SaveRecordTransferLogToTable(DateTime.Now, _Username, Client1.AccNO, Client2.AccNO, (double)nudAmountToTransfer.Value, Client1.Balance, Client2.Balance);
                        MessageBox.Show("Transfer Completed Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _ReloadScreen();

                    }
                    else
                    {
                        MessageBox.Show("Transfer Operation Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _FormatPage();
                    }

                }
            }
            else
            {
                MessageBox.Show("The account number to which the client is transferred and the recipient are the same. Please change one of them"
                                , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }

        private void pbSwitch_Click(object sender, EventArgs e)
        {
            string tempAccNo = "";

            tempAccNo = cbAccountsNumber1.Text;
            _SwitchAccNo = true;
            cbAccountsNumber1.Text = cbAccountsNumber2.Text;
            cbAccountsNumber2.Text = tempAccNo;

            _ReloadScreen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();
            _FormatPage();
        }
    }
}
