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
    public partial class frmMainScreen : Form
    {

        public string _Name;
        public string _Username;
        public int _Permissions;

        private clsUser _User;

        public frmMainScreen(string Username)
        {
            InitializeComponent();
            _Username = Username;
        }



        private void frmShowClientList_Load(object sender, EventArgs e)
        {
            _User = BankBussinessLayer.clsUser.FindByUsername(_Username);
            lblUsername.Text = _Username;
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblDateTime.Text = DateTime.Now.ToLongTimeString().ToString();
            timer1.Enabled = true;
            
            if(!_User.IsUserHasPermissions(clsUser.enPermissions.enClientList))
            {
                btnClientList.Enabled = false;
            }
            if(!_User.IsUserHasPermissions(clsUser.enPermissions.enTransactions))
            {
                btnTransactions.Enabled = false;
            }
            if(!_User.IsUserHasPermissions(clsUser.enPermissions.enManageUsers))
            {
                btnManageUsers.Enabled=false;
            }
            if(!_User.IsUserHasPermissions(clsUser.enPermissions.enLoginRegister))
            {
                ptnLoginRegisters.Enabled = false;
            }

        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsersScreen(_User);
            frm.ShowDialog();

        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserProfile(_User,lblUsername.Text);
            frm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblDateTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabManageUsers_Enter(object sender, EventArgs e)
        {
           
        }

        private void btnClientList_Click(object sender, EventArgs e)
        {
            Form frm = new frmClientList(_Username);
            frm.ShowDialog();

        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            Form frm = new frmTransactionsScreen(_User,_Username);
            frm.ShowDialog();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            Form frm = new frmManageUsersScreen(_User);
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnCurrencyExchange_Click(object sender, EventArgs e)
        {
            Form frm = new frmCurrencyExchange(_User,_Username);
            frm.ShowDialog();
        }

        private void ptnLoginRegisters_Click(object sender, EventArgs e)
        {
            Form frm = new frmLoginRegisters(_User);
            frm.ShowDialog();
        }
    }
}
