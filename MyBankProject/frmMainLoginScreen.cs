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
    public partial class frmMainLoginScreen : Form
    {
        public frmMainLoginScreen()
        {
            InitializeComponent();
        }


        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter your email")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {

                txtUsername.Text = "Enter your email";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Enter your password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.PasswordChar = '*';
            }
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Enter your password";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Font = new Font("Arial", 12, FontStyle.Regular);
            txtUsername.ForeColor = Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

        }

        bool HidePassword = true;

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Enter your password")
            {
                txtPassword.Font = new Font("Arial", 12, FontStyle.Regular);
                txtPassword.ForeColor = Color.Black;
            }
            if (!string.IsNullOrEmpty(txtPassword.Text) && txtPassword.Text != "Enter your password")
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }


        clsUser LoginUser = new clsUser();


        private void Form1_Load(object sender, EventArgs e)
        {

            txtUsername.Text = "Enter your email";
            txtUsername.ForeColor = Color.Gray;

            txtPassword.Text = "Enter your password";
            txtPassword.Font = new Font("Arial", 12, FontStyle.Regular);
            txtPassword.ForeColor = Color.Gray;

            txtUsername.KeyDown += new KeyEventHandler(Form1_KeyDown);
            txtPassword.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void HideOrViewPass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (txtPassword.PasswordChar == '\0' && txtPassword.Text != "Enter your password")
            {
                txtPassword.PasswordChar = '*';
            }
            if(pbHideIcon.ImageLocation == "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png")
            {
                pbHideIcon.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\HideEye_Password.png";
            }
            else
            {
                pbHideIcon.ImageLocation = "C:\\Users\\Hassan\\Pictures\\Icnos\\OpenEye_Password.png";

            }
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int _Trails = 3;
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (BankBussinessLayer.clsUser.FindByUsernameAndPass(txtUsername.Text, txtPassword.Text))
            {
                LoginUser = clsUser.GetUserInfo(txtUsername.Text);
                LoginUser.SaveLoginRecord();
                Form frm = new frmMainScreen(txtUsername.Text);
                frm.ShowDialog();
                lblFailedToLogIn.Visible = false;
                _Trails = 3;
            }
            else
            {
                _Trails--;
                lblFailedToLogIn.Visible = true;

                if (_Trails > 0)
                {
                    lblFailedToLogIn.Text = $"Invalid Username/Password\r\nYou have {_Trails} Trials to login.\r\n";
                    //lblFailedToLogIn.Visible = false;

                }
                else
                {
                    MessageBox.Show("You Have Enter Wrong Password/Username 3 Trails Please Call Your Admain", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                    {
                            form.Close();
                    }
                }
            }
        }

        private void frmMainLoginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
