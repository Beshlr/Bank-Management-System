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
    public partial class frmUserProfile : Form
    {

        private clsUser _user = new clsUser();
        private clsUser CurrentUser = new clsUser();

        private string _Username = "";

        private bool AllowToLogOut = false;

        public frmUserProfile(clsUser User,string Username)
        {
            InitializeComponent();
            _Username = Username;
            CurrentUser = User;
        }

        private void _FillProfileWithDetails()
        {
            _user = clsUser.GetUserInfo(_Username);
            if (CurrentUser.Username != _user.Username)
            {
                //panel2.Enabled = false;
                lblLogOut.Cursor = Cursors.No;
                pbLogOut.Cursor = Cursors.No;
                lblLogOut.ForeColor = Color.Gray;
                //pbLogOut.Enabled = false;
                AllowToLogOut = false;
            }
            else
            {
                pbActiveSign.Visible = true ;
                AllowToLogOut = true;
            }
            lblName.Text = _user.Name;
            lblUsername.Text = _user.Username;
            pbImage.ImageLocation = _user.ImagePath;
            lblPhone.Text = _user.Phone;
            lblEmail.Text = _user.Email;
            lblAddress.Text = _user.Address;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Username == "admin"|| CurrentUser.Username == _user.Username)
            {
                lblPassword.Text = _user.Password;
            }
            else
            {
                MessageBox.Show("Only Admin Can Show Users Password", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (!AllowToLogOut)
            {
                MessageBox.Show("This Is Not User You Enter With To Log Out From", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
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

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void frmUserProfile_Load(object sender, EventArgs e)
        {
            _FillProfileWithDetails();
        }

        private void pbEditProfile_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddEditUser(_user.Username);
            frm.ShowDialog();
            _FillProfileWithDetails();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Username == "admin")
            {

                if (MessageBox.Show("Are You Sure You Want To Delete User With Username [" + _user.Username + "]?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (clsUser.DeleteUser(_user.Username))
                    {
                        MessageBox.Show("User Deleted Successfully", "Done");
                    }

                }
            }
            else
            {
                MessageBox.Show("Only Admin Can Delete Users", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
