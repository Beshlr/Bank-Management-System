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
    public partial class BankProject : Form
    {
        public BankProject()
        {
            InitializeComponent();
        }

        private void BankProject_Load(object sender, EventArgs e)
        {
            
            //this.Close();
        }

        bool IsOpened = false;

        private void btnStart_Click(object sender, EventArgs e)
        {
                Form frm = new frmMainLoginScreen();
            if(!IsOpened)
            {
                IsOpened = true;
                frm.Show();
                //this.WindowState = FormWindowState.Minimized;
                IsOpened = false;
            }
            //IsOpened = false;
        }
    }
}
