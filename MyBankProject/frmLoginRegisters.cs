using BankBussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyBankProject
{
    public partial class frmLoginRegisters : Form
    {
        public frmLoginRegisters(clsUser user)
        {
            InitializeComponent();
            _User = user;
        }

        clsUser _User = new clsUser();

        private void frmLoginRegisters_Load(object sender, EventArgs e)
        {
            _RefreshLoginLogsList();
        }

        private void _RefreshLoginLogsList(bool FindUser = false, bool SortedASC = true, string OrderBy = "",string Username = "")
        {
            dgvLoginLogsList.DataSource = clsUser.GetAllLoginLogs(FindUser, SortedASC, OrderBy, Username);

            dgvLoginLogsList.ColumnHeadersHeight = 25;
            lblNumOfRecords.Text = dgvLoginLogsList.RowCount.ToString();
        }
        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow DataRow = dgvLoginLogsList.SelectedRows[0];

            string Username = DataRow.Cells[2].Value.ToString();

            Form frm = new frmUserProfile(_User, Username);
            frm.ShowDialog();
        }
        private void txtFindUser_TextChanged(object sender, EventArgs e)
        {
            if (txtFindUser.Text.Length > 0)
            {
                if (rbOrderUsersListASC.Checked)
                {
                        _RefreshLoginLogsList(true, true, "Username", txtFindUser.Text);
                    
                }
                else
                {
                        _RefreshLoginLogsList(true, false, "Username", txtFindUser.Text);
                   

                }
            }
            else
            {
                _RefreshLoginLogsList();
            }
        }
        private void pbFindClientSettings_Click(object sender, EventArgs e)
        {
           
        }
        private void rbOrderUsersListDESC_CheckedChanged(object sender, EventArgs e)
        {
            _RefreshLoginLogsList(false, false);



        }

        private void rbOrderUsersListASC_CheckedChanged(object sender, EventArgs e)
        {
            _RefreshLoginLogsList(false, true);


        }
        private void pbSearchIcon_Click(object sender, EventArgs e)
        {
            if (txtFindUser.Text.Length == 0)
            {
                txtFindUser.Focus();
                errorProvider1.SetError(txtFindUser, "Please Enter Text");
            }
            else
            {
                errorProvider1.SetError(txtFindUser, "");
            }
        }
        private void txtFindUser_Click(object sender, EventArgs e)
        {
        }

        private void frmManageUsersScreen_Click(object sender, EventArgs e)
        {

        }
        private void pbRefresh_Click(object sender, EventArgs e)
        {
            _RefreshLoginLogsList();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
