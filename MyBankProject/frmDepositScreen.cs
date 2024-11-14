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
    public partial class frmDepositScreen : Form
    {
        public frmDepositScreen()
        {
            InitializeComponent();
        }

        clsClient Client = new clsClient();

        private void _FillAccountNumbersComboBox()
        {
            DataTable dt = clsClient.GetAllClients();
            foreach (DataRow row in dt.Rows) 
            {
                cbAccountsNumber.Items.Add(row["AccountNO"]);

            }

            cbAccountsNumber.SelectedIndex = 0;
        }

        private void frmDepositScreen_Load(object sender, EventArgs e)
        {
            _FillAccountNumbersComboBox();
        }

        public void _ReloadPage()
        {
            Client = clsClient.GetClientInfo(cbAccountsNumber.Text);


            lblBalanceAmount.Text = Client.Balance.ToString() + "$";
        }

        private void cbAccountsNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadPage();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are You Sure You Want To Deposit [" + nudDepositAmount.Value + "] To Account With Number [" + cbAccountsNumber.Text + "]?", "Confirm",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if(Client.DepositOp((double)nudDepositAmount.Value))
                {
                    MessageBox.Show("Deposit Completed Successfully","Done",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReloadPage();
                }
                else
                {
                    MessageBox.Show("Deposit Operation Failed","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
