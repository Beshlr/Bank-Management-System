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
    public partial class frmManageUsersScreen : Form
    {
        public frmManageUsersScreen(clsUser User)
        {
            InitializeComponent();
            CurrentUser = User;
        }

        clsUser CurrentUser = new clsUser();

        private void _RefreshUserList(bool FindUser = false,bool SortedASC = true,string OrderBy = "",string SearchText = "")
        {
            dgvUsersList.DataSource = clsUser.GetAllUsers(CurrentUser.Username,FindUser,SortedASC,OrderBy,SearchText);

            dgvUsersList.ColumnHeadersHeight = 25;
            lblNumOfUsers.Text = dgvUsersList.RowCount.ToString();
        }

        private void frmManageUsersScreen_Load(object sender, EventArgs e)
        {
            _RefreshUserList();
        }

        private void dgvUsersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow DataRow = dgvUsersList.SelectedRows[0];

            string Username = DataRow.Cells[1].Value.ToString();

            Form frm = new frmUserProfile(CurrentUser,Username);
            frm.ShowDialog();
        }

        private void txtFindUser_TextChanged(object sender, EventArgs e)
        {
            if (txtFindUser.Text.Length > 0)
            {
                if (rbOrderUsersListASC.Checked)
                {
                    if (rbUsername.Checked)
                        _RefreshUserList(true, true, rbUsername.Text, txtFindUser.Text);
                    else if (rbName.Checked)
                        _RefreshUserList(true, true, rbName.Text, txtFindUser.Text);
                    else if (rbAddress.Checked)
                        _RefreshUserList(true, true, rbAddress.Text, txtFindUser.Text);
                }
                else
                {
                    if (rbUsername.Checked)
                        _RefreshUserList(true, false, rbUsername.Text, txtFindUser.Text);
                    else if (rbName.Checked)
                        _RefreshUserList(true, false, rbName.Text, txtFindUser.Text);
                    else if (rbAddress.Checked)
                        _RefreshUserList(true, false, rbAddress.Text, txtFindUser.Text);

                }
            }
            else
            {
                _RefreshUserList();
            }
        }

        private void pbFindClientSettings_Click(object sender, EventArgs e)
        {
            if (gbFindBy.Visible)
                gbFindBy.Visible = false;
            else
                gbFindBy.Visible = true;
        }

        private void rbOrderUsersListDESC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsername.Checked)
                _RefreshUserList(false, false, rbUsername.Text);
            else if (rbName.Checked)
                _RefreshUserList(false, false, rbName.Text);
            else if (rbAddress.Checked)
                _RefreshUserList(false, false, rbAddress.Text);
        }

        private void rbOrderUsersListASC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUsername.Checked)
                _RefreshUserList(false, true, rbUsername.Text);
            else if (rbName.Checked)
                _RefreshUserList(false, true, rbName.Text);
            else if (rbAddress.Checked)
                _RefreshUserList(false, true, rbAddress.Text);
        }

        private void pbSearchIcon_Click(object sender, EventArgs e)
        {
            if(txtFindUser.Text.Length == 0)
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
            gbFindBy.Visible = false;
        }

        private void frmManageUsersScreen_Click(object sender, EventArgs e)
        {
            gbFindBy.Visible = false;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete User With Username [" + dgvUsersList.CurrentRow.Cells[1].Value + "]?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUser.DeleteUser((string)dgvUsersList.CurrentRow.Cells[1].Value))
                {
                    MessageBox.Show("User Deleted Successfully", "Done");
                }
                else
                {
                    MessageBox.Show("admin Can't be Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            _RefreshUserList();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser();
            frm.ShowDialog();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            _RefreshUserList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        private void lblNumOfUsers_Click(object sender, EventArgs e)
        {

        }

        private void rbAddress_CheckedChanged(object sender, EventArgs e)
        {
            txtFindUser.PlaceholderText = "Enter Address";
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            txtFindUser.PlaceholderText = "Enter Name";

        }

        private void rbUsername_CheckedChanged(object sender, EventArgs e)
        {
            txtFindUser.PlaceholderText = "Enter Username";

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser(dgvUsersList.CurrentRow.Cells[1].Value.ToString());
            frm.ShowDialog();
        }
    }
}
