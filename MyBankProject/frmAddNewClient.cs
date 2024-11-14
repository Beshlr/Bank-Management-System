using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using BankBussinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyBankProject
{
    public partial class frmAddNewClient : Form
    {

        private string _AccNO = "";

        private string _Username = "";

        public frmAddNewClient(string AccNO,string Username = "")
        {
            InitializeComponent();

            _Username = Username;
            Client = clsClient.GetClientInfo(AccNO);
            if(AccNO !="")
            {
                txtAccNO.Enabled = false;
                _Mode = _enMode.enUpdate;
            }
            else
            {
                _Mode = _enMode.enAddNew;
            }

        }

        private enum _enMode { enAddNew = 0, enUpdate = 1};

        private _enMode _Mode;

        private string AccNO = "";

        clsClient Client = new clsClient();

        private void _LoadData()
        {
            lblMode.Text = "Update Client [" + Client.AccNO + "]";

            txtAccNO.Text = Client.AccNO;
            txtName.Text = Client.Name;
            txtPhone.Text = Client.Phone;
            txtEmail.Text = Client.Email;
            txtPINCode.Text = Client.PINCode.ToString();
            txtBalance.Text = Client.Balance.ToString();
            pbClientPicture.ImageLocation = Client.ImagePath;
            pnlProgressBar.Visible = false;
        }

        private static int Counter = 0;

       
        private void frmAddNewClient_Load(object sender, EventArgs e)
        {
            if (_Mode == _enMode.enUpdate)
            {
                _LoadData();
            }

        }

        private void _AddNew()
        {
            if (txtAccNO.Text == "" || txtName.Text == "" || txtPhone.Text == "" || txtPINCode.Text == "" || txtBalance.Text == "")
            {
                MessageBox.Show("Please Fill Empty Feilds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (
                clsClient.AddNewClient(txtAccNO.Text, txtName.Text, txtPhone.Text, txtEmail.Text, Convert.ToInt32(txtPINCode.Text), Convert.ToInt32(txtBalance.Text),pbClientPicture.ImageLocation,_Username)
                    != -1)
                {
                    MessageBox.Show("Client Added Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _Mode = _enMode.enUpdate;
                    lblMode.Text = "Update Client [" + txtAccNO.Text + "]";
                    txtAccNO.Enabled = false;
                    
                    
                }
                else
                {
                    MessageBox.Show("Client Added Failed, Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(_Mode == _enMode.enAddNew)
            {
                _AddNew();
            }
            else
            {
                Client = clsClient.GetClientInfo(txtAccNO.Text);
                Client.Name = txtName.Text;
                Client.Phone = txtPhone.Text;
                Client.Email = txtEmail.Text;
                Client.PINCode = Convert.ToInt32(txtPINCode.Text);
                Client.Balance = Convert.ToInt32(txtBalance.Text);
                Client.ImagePath = pbClientPicture.ImageLocation;

                if(MessageBox.Show("Are You Sure You Want To Edit This Client ?","Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if(Client.UpdateClient(Client))
                    {
                        MessageBox.Show("Client Updated Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Client Updated Failed!, Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

            


        }

        private void txtEmail_MouseLeave(object sender, EventArgs e)
        {
            
        }

      

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            bool isTextEntered = false;
            if (!txtEmail.Text.EndsWith("@gmail.com"))
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "InValid Email");
                
            }
            else if (txtEmail.Text.Length == 0)
            {
                e.Cancel = true;
                txtAccNO.Focus();
                errorProvider1.SetError(txtBalance, "This Field Is Required");
                
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
                e.Cancel = false;
            }
                UpdateProgressBar();
        }

        private void mtbAccNO_Validating(object sender, CancelEventArgs e)
        {
            bool isTextEntered = false;
            if (clsClient.FindClientByAccNO(txtAccNO.Text).Rows.Count > 0)
            {
                e.Cancel = true;
                txtAccNO.Focus();
                errorProvider1.SetError(txtAccNO, "This AccNO Is Used");
                
            }
            else if(txtAccNO.Text.Length == 0)
            {
                e.Cancel = true;
                txtAccNO.Focus();
                errorProvider1.SetError(txtBalance, "This Field Is Required");
                
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAccNO, "");
                UpdateProgressBar();
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            bool isTextEntered = false;
            if(txtName.Text == "")
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
            UpdateProgressBar();
        }

        private void mtbPhone_Validating(object sender, CancelEventArgs e)
        {
            bool isTextEntered = false;
            if (txtPhone.Text == "")
            {
                e.Cancel = true;
                txtPhone.Focus();
                errorProvider1.SetError(txtPhone, "This Field Is Required");
                if (Counter > 0&&!isTextEntered)
                {
                    
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPhone, "");
                
            }
            UpdateProgressBar();
        }

        private void txtEmail_Validating_1(object sender, CancelEventArgs e)
        {
            bool isTextEntered = false;
            if (txtEmail.Text == "")
            {
                e.Cancel = true;
                txtEmail.Focus();
                errorProvider1.SetError(txtEmail, "This Field Is Required");
                if (Counter > 0&&!isTextEntered)
                {
                    
                
                }
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, "");
                
                
            }
            UpdateProgressBar();
        }

        private void mtbPINCode_Validating(object sender, CancelEventArgs e)
        {
            bool isTextEntered = false;
            if (txtPINCode.Text == "")
            {
                e.Cancel = true;
                txtPINCode.Focus();
                errorProvider1.SetError(txtPINCode, "This Field Is Required");
               
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPINCode, "");
                
            }
            UpdateProgressBar();
        }

        private void mtbBalance_Validating(object sender, CancelEventArgs e)
        {
            bool isTextEntered = false;
            if (txtBalance.Text == "")
            {
                e.Cancel = true;
                txtBalance.Focus();
                errorProvider1.SetError(txtBalance, "This Field Is Required");
               
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBalance, "");
               
            }
            UpdateProgressBar();
        }

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
                pbClientPicture.ImageLocation = selectedFilePath;
                pbClientPicture.Load(selectedFilePath);

            }
        }

        private void pbHideIcon_Click(object sender, EventArgs e)
        {
            if (txtPINCode.PasswordChar == '*')
            {
                txtPINCode.PasswordChar = '\0';
            }
            else if (txtPINCode.PasswordChar == '\0' && txtPINCode.Text != "Enter your password")
            {
                txtPINCode.PasswordChar = '*';
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

        private void Field_TextChanged(object sender, EventArgs e)
        {
            //UpdateProgressBar();
        }

        private const int RequiredFieldsCount = 6;

        private void UpdateProgressBar()
        {
            int filledFieldsCount = 0;

            if (!string.IsNullOrWhiteSpace(txtAccNO.Text)) filledFieldsCount++;
            if (!string.IsNullOrWhiteSpace(txtName.Text)) filledFieldsCount++;
            if (!string.IsNullOrWhiteSpace(txtPhone.Text)) filledFieldsCount++;
            if (!string.IsNullOrWhiteSpace(txtEmail.Text)) filledFieldsCount++;
            if (!string.IsNullOrWhiteSpace(txtPINCode.Text)) filledFieldsCount++;
            if (!string.IsNullOrWhiteSpace(txtBalance.Text)) filledFieldsCount++;

            int progressPercentage = (filledFieldsCount * 100) / RequiredFieldsCount;

            progressBar1.Value = progressPercentage;

            // تحديث النص في الـ Label داخل الـ ProgressBar
            lblProgress.Text = $"{progressPercentage}%";
        }
    }
}
