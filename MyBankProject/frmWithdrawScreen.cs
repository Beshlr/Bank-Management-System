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

namespace MyBankProject
{
    public partial class frmWithdrawScreen : Form
    {
        public frmWithdrawScreen()
        {
            InitializeComponent();
            
        }

        clsClient Client = new clsClient();

        private void _FillAccountNumbersComboBox()
        {
            cbAccountsNumber.Items.Clear();

            DataTable dt = clsClient.GetAllClients();
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["Balance"]) > 0)
                cbAccountsNumber.Items.Add(row["AccountNO"]);

            }
            


        }
        public void _ReloadPage()
        {
            Client = clsClient.GetClientInfo(cbAccountsNumber.Text);
            if (Client.Balance == 0)
            {
                MessageBox.Show("This Account Can't Withdraw From Him, Please Choose Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbAccountsNumber.Items.Remove(cbAccountsNumber.SelectedIndex);
                if(cbAccountsNumber.SelectedIndex == (int)cbAccountsNumber.Items.Count-1)
                    cbAccountsNumber.SelectedIndex = cbAccountsNumber.SelectedIndex - 1;
                else if(cbAccountsNumber.SelectedIndex < (int)cbAccountsNumber.Items.Count - 1)
                    cbAccountsNumber.SelectedIndex = cbAccountsNumber.SelectedIndex + 1;
                if(cbAccountsNumber.Items.Count == 0)
                {
                    MessageBox.Show("No Accounts To Withdraw From It","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblBalanceAmount.Text = Client.Balance.ToString() + "$";
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadPage();
        }

        private void frmWithdrawScreen_Load(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();
            cbAccountsNumber.SelectedIndex = 0;
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if(Client.Balance >= nudWithdrawAmount.Value)
            {
                if (MessageBox.Show(@"Are You Sure You Want To Withdraw [" + nudWithdrawAmount.Value + "]$ From Account With Number [" + Client.AccNO + "] ?",
                                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Client.WithdrawOp((double)nudWithdrawAmount.Value))
                    {
                        MessageBox.Show("Withdraw Copleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _ReloadPage();
                        _FillAccountNumbersComboBox();

                    }
                }
            }
            else
            {
                MessageBox.Show("This Account Can't Withdraw From Him, Please Choose Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudWithdrawAmount_ValueChanged(object sender, EventArgs e)
        {
            if(nudWithdrawAmount.Value > Client.Balance)
            {
                nudWithdrawAmount.Value = Client.Balance;
            }
            
        }

        private void cbAccountsNumber_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbAccountsNumber_Validating(object sender, CancelEventArgs e)
        {
            if (clsClient.IsClientExist(cbAccountsNumber.Text) == false || clsClient.GetClientInfo(cbAccountsNumber.Text).Balance <= 0)
            {
                cbAccountsNumber.Focus();
                errorProvider1.SetError(cbAccountsNumber, "Wrong Account Number Enter Another One");
            }
            else
            {
                errorProvider1.SetError(cbAccountsNumber, "");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();
            cbAccountsNumber.SelectedIndex = 0;
            _ReloadPage();
        }
    }
}
