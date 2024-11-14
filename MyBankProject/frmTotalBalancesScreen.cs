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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyBankProject
{
    public partial class frmTotalBalancesScreen : Form
    {

        clsClient Client = new clsClient();

        public frmTotalBalancesScreen()
        {
            InitializeComponent();
        }

        public void _FillListWithClients(bool Find = false,bool OrderBalancesACS = true)
        {
            if(Find)
            {
                dgvClientsList.DataSource = clsClient.FindClientByAccNO(txtAccountNO.Text);
            }
            else
            {
                
                dgvClientsList.DataSource = clsClient.GetAllClientsAndOrderBalances(OrderBalancesACS);
                lblTotalAmount.Text = clsClient.GetTotalOfBalances()+"$";
            }

            lblNumOfClients.Text = dgvClientsList.RowCount.ToString();
            dgvClientsList.ColumnHeadersHeight = 25;

        }

        private void frmTotalBalancesScreen_Load(object sender, EventArgs e)
        {
            _FillListWithClients();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            _FillListWithClients(true);
        }

        private void rbOrderClientListASC_CheckedChanged(object sender, EventArgs e)
        {
            _FillListWithClients(false, true);
        }

        private void rbOrderClientListDESC_CheckedChanged(object sender, EventArgs e)
        {
            _FillListWithClients(false,false);
        }

        private void pbSearchIcon_Click(object sender, EventArgs e)
        {
            if (clsClient.IsClientExist(txtAccountNO.Text))
            {
                _FillListWithClients(true);

            }
            else
            {
                MessageBox.Show("This Account Number Is not Exist, try Another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAccountNO.Text = "";
                txtAccountNO.Focus();
            }


            if (txtAccountNO.Text == "")
            {
                _FillListWithClients();
            }
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            _FillListWithClients();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
