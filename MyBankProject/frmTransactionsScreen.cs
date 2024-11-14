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
    public partial class frmTransactionsScreen : Form
    {

        private string _Username;
        private clsUser _User;

        public frmTransactionsScreen(clsUser User,string Username)
        {
            InitializeComponent();
            _Username = Username;
            _User = User;
        }

        private void frmTransactionsScreen_Load(object sender, EventArgs e)
        {


            Form frm1 = new frmDepositScreen();
            frm1.TopLevel = false;
            frm1.AutoScroll = true;
            frm1.Dock = DockStyle.Fill;
            pnlDeposit.Controls.Clear();
            pnlDeposit.Controls.Add(frm1);
            frm1.Show();

            Form frm2 = new frmWithdrawScreen();
            frm2.TopLevel = false;
            frm2.AutoScroll = true;
            frm2.Dock = DockStyle.Fill;
            pnlWithdraw.Controls.Clear();
            pnlWithdraw.Controls.Add(frm2);
            frm2.Show();

            Form frm3 = new frmTotalBalancesScreen();
            frm3.TopLevel = false;
            frm3.AutoScroll = true;
            frm3.Dock = DockStyle.Fill;
            pnlTotalBalances.Controls.Clear();
            pnlTotalBalances.Controls.Add(frm3);
            frm3.Show();

            Form frm4 = new frmTransferScreen(_Username);
            frm4.TopLevel = false;
            frm4.AutoScroll = true;
            frm4.Dock = DockStyle.Fill;
            pnlTransfer.Controls.Clear();
            pnlTransfer.Controls.Add(frm4);
            frm4.Show();

            Form frm5 = new frmTransferLogScreen();
            frm5.TopLevel = false;
            frm5.AutoScroll = true;
            frm5.Dock = DockStyle.Fill;
            pnlTransferLog.Controls.Clear();
            pnlTransferLog.Controls.Add(frm5);
            frm5.Show();

            lblUsername.Text = _Username;
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblDateTime.Text = DateTime.Now.ToShortDateString();

            timer1.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (form.Name != "BankProject")
                    form.Close();
            }

            Form mainForm = Application.OpenForms["BankProject"];
            if (mainForm == null)
            {
                mainForm = new BankProject();
                mainForm.Show();
            }
            else
            {
                mainForm.BringToFront();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserProfile(_User, _Username);
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
