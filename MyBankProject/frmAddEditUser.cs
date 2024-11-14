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
using BankBussinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MyBankProject
{
    public partial class frmAddEditUser : Form
    {
        public frmAddEditUser(string Username = "")
        {
            InitializeComponent();
            if(Username != "")
            {
                this.Username = Username;
                _FillScreenDetails();
            }
        }

        

        private void _FillScreenDetails()
        {
            lblMode.Text = "Update User";
            user = clsUser.GetUserInfo(Username);
            txtUsername.Enabled = false;
            pbUserPicture.ImageLocation = user.ImagePath;
            txtPassword.Text = user.Password;
            txtEmail.Text = user.Email;
            txtName.Text = user.Name;
            txtUsername.Text = user.Username;
            mtxtPhone.Text = user.Phone;
            txtAddress.Text = user.Address;

            if((user.Permissions & Convert.ToInt32(cbxClientListPer.Tag)) == Convert.ToInt32(cbxClientListPer.Tag))
            {
                cbxClientListPer.Checked = true;
            }
            if((user.Permissions & Convert.ToInt32(cbxTransactionsPer.Tag)) == Convert.ToInt32(cbxTransactionsPer.Tag))
            {
                cbxTransactionsPer.Checked = true;
            }
            if((user.Permissions & Convert.ToInt32(cbxManageUsersPer.Tag)) == Convert.ToInt32(cbxManageUsersPer.Tag))
            {
                cbxManageUsersPer.Checked = true;
            }
            if((user.Permissions & Convert.ToInt32(cbxLoginRegistersPer.Tag)) == Convert.ToInt32(cbxLoginRegistersPer.Tag))
            {
                cbxLoginRegistersPer.Checked = true;
            }
            if(user.Permissions == -1)
            {
                cbxAllPer.Checked = true;
            }


            btnAddEditUser.Text = "Save";
        }


        private string Username;
        private string Email;
        private string Name;
        private string Password;
        private string Phone;
        private string ImagePath;
        private string Address;
        private int    Permissions;



        private void _FormatScreen()
        {
            pbUserPicture.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\3669480_account_circle_ic_icon.png";
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            mtxtPhone.Clear();
            txtAddress.Clear();

            cbxClientListPer.Checked = false;
            cbxTransactionsPer.Checked = false;
            cbxManageUsersPer.Checked = false;
            cbxAllPer.Checked = false;
        }

        private void btnAddNewUser()
        {
            if (clsUser.IsUsersExist(txtUsername.Text))
            {
                MessageBox.Show("Username You Entered Is Already Used Please Enter Another One", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "Enter Another Username");
            }
            else
            {
                errorProvider1.SetError(txtUsername, "");
                user.Username = txtUsername.Text.ToLower();
                user.Email = txtEmail.Text;
                user.Name = txtName.Text;
                user.Password = txtPassword.Text;
                user.Phone = mtxtPhone.Text;
                user.ImagePath = pbUserPicture.ImageLocation;
                user.Address = txtAddress.Text;
                if (cbxAllPer.Checked)
                {
                    user.Permissions = -1;
                }
                else
                {
                    if (cbxClientListPer.Checked)
                    {
                        user.Permissions += 1;
                    }
                    if (cbxTransactionsPer.Checked)
                    {
                        user.Permissions += 2;
                    }
                    if (cbxManageUsersPer.Checked)
                    {
                        user.Permissions += 4;
                    }
                    if(cbxLoginRegistersPer.Checked)
                    {
                        user.Permissions += 8;
                    }

                }



                if (MessageBox.Show("Are You Sure You Want To Add This User ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clsUser.AddNewUser(user.Username, user.Name, user.Email, user.Phone, user.Password, user.Permissions, user.ImagePath, user.Address))
                    {
                        MessageBox.Show("User Added Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _FormatScreen();

                    }
                    else
                    {
                        MessageBox.Show("User Didn't Added Please Try Again", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }


        private void btnEditUser()
        {
            user.Email = txtEmail.Text;
            user.Name = txtName.Text;
            user.Password = txtPassword.Text;
            user.Phone = mtxtPhone.Text;
            user.ImagePath = pbUserPicture.ImageLocation;
            user.Address = txtAddress.Text;
            user.Permissions = 0;
            if (cbxAllPer.Checked)
            {
                user.Permissions = -1;
            }
            else
            {
                if (cbxClientListPer.Checked)
                {
                    user.Permissions += 1;
                }
                if (cbxTransactionsPer.Checked)
                {
                    user.Permissions += 2;
                }
                if (cbxManageUsersPer.Checked)
                {
                    user.Permissions += 4;
                }
                if(cbxLoginRegistersPer.Checked)
                {
                    user.Permissions += 8;
                }

            }



            if (MessageBox.Show("Are You Sure You Want To Save This Changes ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsUser.UpdateUser(user))
                {
                    MessageBox.Show("Changes Saved Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _FillScreenDetails();
                }
                else
                {
                    MessageBox.Show("Changes Didn't Saved Please Try Again", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(btnAddEditUser.Text == "Add")
            {
                btnAddNewUser();
            }
            else
            {
                btnEditUser();
            }
            
        }

        clsUser user = new clsUser();

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Process the selected file
                string selectedFilePath = openFileDialog1.FileName;
                //MessageBox.Show("Selected Image is:" + selectedFilePath);
                pbUserPicture.ImageLocation = selectedFilePath;
                pbUserPicture.Load(selectedFilePath);
                
            }
        }

        private bool AllChecked = false;

        private void cbxAllPer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAllPer.Checked)
            {
                cbxClientListPer.Checked = true;
                cbxTransactionsPer.Checked = true;
                cbxManageUsersPer.Checked = true;
                cbxLoginRegistersPer.Checked = true;
            }
            else
            {

                cbxClientListPer.Checked = false;
                cbxTransactionsPer.Checked = false;
                cbxManageUsersPer.Checked = false;
                cbxLoginRegistersPer.Checked = false;
            }
        }

        private void cbxClientListPer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTransactionsPer.Checked && cbxManageUsersPer.Checked && cbxClientListPer.Checked&& cbxLoginRegistersPer.Checked)
            {
                cbxAllPer.Checked = true;
            }
            else
            {
                
            }
            

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbUserPicture_Click(object sender, EventArgs e)
        {

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (txtName.Text.Length == 0)
            {
                e.Cancel = true;
                txtName.Focus();
                errorProvider1.SetError(txtName, "This Field Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text.Length == 0)
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "This Field Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtPassword.Text.Length == 0)
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "This Field Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            if(clsUser.IsUsersExist(txtUsername.Text.ToLower()))
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "This Username Is Already Used");
            }
            else if (txtUsername.Text.Length == 0)
            {
                e.Cancel = true;
                txtUsername.Focus();
                errorProvider1.SetError(txtUsername, "This Field Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, "");
            }
        }

        private void mtxtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (mtxtPhone.Text.Length == 0)
            {
                e.Cancel = true;
                mtxtPhone.Focus();
                errorProvider1.SetError(mtxtPhone, "This Field Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(mtxtPhone, "");
            }
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtAddress.Text.Length == 0)
            {
                e.Cancel = true;
                txtAddress.Focus();
                errorProvider1.SetError(txtAddress, "This Field Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, "");
            }
        }

        private void pbHideIcon_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (txtPassword.PasswordChar == '\0' && txtPassword.Text != "Enter your password")
            {
                txtPassword.PasswordChar = '*';
            }
            if (pbHideIcon.ImageLocation == "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png")
            {
                pbHideIcon.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\HideEye_Password.png";
            }
            else
            {
                pbHideIcon.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png";

            }
        }
    }
}
