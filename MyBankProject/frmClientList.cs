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
    public partial class frmClientList : Form
    {
        private string _Username;

        public frmClientList(string Username)
        {
            InitializeComponent();
            _Username = Username;
        }

        clsClient Client = new clsClient();

        private void _RefreshClientList(bool FindClient = false,bool OrderByASC = true,string AccountNO = "")
        {
            if (!FindClient)
                dgvClientList.DataSource = BankBussinessLayer.clsClient.GetAllClients(OrderByASC);
            else
            {
                
                dgvClientList.DataSource = clsClient.FindClientByAccNO(AccountNO);
                
            }

            lblNumOfClients.Text = dgvClientList.RowCount.ToString();
            dgvClientList.ColumnHeadersHeight = 25;
        }

        private void _RefreshClientList(string Name)
        {

            dgvClientList.DataSource = clsClient.FindClientByName(Name);
            lblNumOfClients.Text = dgvClientList.RowCount.ToString();
        }

        private void _RefreshClientListByBalance(string Balance)
        {
            dgvClientList.DataSource = clsClient.FindClientByBalance(Balance);
            lblNumOfClients.Text = dgvClientList.RowCount.ToString();
  
        }

        private void frmClientList_Load(object sender, EventArgs e)
        {
            _RefreshClientList();
            txtFindClient.Focus();
        }

        private bool IsEmpty = false;

        private void txtFindClient_TextChanged(object sender, EventArgs e)
        {
            if(rbAccountNO.Checked)
            {
                _RefreshClientList(true, true, txtFindClient.Text);

            }
            if(rbName.Checked)
            {
            _RefreshClientList(txtFindClient.Text);

            }
            if(rbBalance.Checked)
            {
                if (txtFindClient.Text != "")
                    _RefreshClientListByBalance(txtFindClient.Text);
                else
                    _RefreshClientList();
                    
            }

        }

        private void txtFindClient_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void txtFindClient_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void pbSearchIcon_Click(object sender, EventArgs e)
        {
            if(txtFindClient.Text.Length == 0)
            {
                return;
                
            }
            if(clsClient.IsClientExist(txtFindClient.Text))
            {
                _RefreshClientList(true,true, txtFindClient.Text);

            }
            else
            {
                MessageBox.Show("This Account Number Is not Exist, try Another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFindClient.Text = "";
                txtFindClient.Focus();
            }

            
            if(txtFindClient.Text == "")
            {
                _RefreshClientList();
            }
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm1 = new frmAddNewClient("",_Username);
            frm1.ShowDialog();
            _RefreshClientList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Delete Client With AccNO [" + dgvClientList.CurrentRow.Cells[0].Value + "]?", "Confirm", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsClient.DeleteClient((string)dgvClientList.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Client Deleted Successfully", "Done");
                }

            }

            _RefreshClientList();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmAddNewClient(dgvClientList.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
            _RefreshClientList();

      
        }

        private void rbOrderClientListASC_CheckedChanged(object sender, EventArgs e)
        {
            _RefreshClientList(false, true);
        }

        private void rbOrderClientListDESC_CheckedChanged(object sender, EventArgs e)
        {
            _RefreshClientList(false, false);

        }


        private void rbAccountNO_CheckedChanged(object sender, EventArgs e)
        {
            txtFindClient.PlaceholderText = "Enter AccNO";


        }

        private void rbBalance_CheckedChanged(object sender, EventArgs e)
        {
            txtFindClient.PlaceholderText = "Enter Balance";

        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            txtFindClient.PlaceholderText = "Enter Name";

        }

        private void pbFindClientSettings_Click(object sender, EventArgs e)
        {
            if (gbFindBy.Visible)
                gbFindBy.Visible = false;
            else
                gbFindBy.Visible = true;
        }

        private void txtFindClient_Enter(object sender, EventArgs e)
        {
            if(gbFindBy.Visible)
                gbFindBy.Visible = false;
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            _RefreshClientList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvClientList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Form frm = new frmAddNewClient(dgvClientList.CurrentRow.Cells[0].Value.ToString());
            frm.ShowDialog();
            _RefreshClientList();
        }
    }
}
