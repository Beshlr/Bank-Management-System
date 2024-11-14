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
    public partial class frmTransferLogScreen : Form
    {

        public void _FillListWithClients(bool Find = false, bool SortByASC = true)
        {
            if (Find)
            {
                dgvTransferLogList.DataSource = clsUser.GetAllTransferLogs(Find,txtAccountNO.Text, SortByASC);

                lblNumOfTransferLog.Text = dgvTransferLogList.RowCount.ToString();
            }
            else
            {
                dgvTransferLogList.DataSource = clsUser.GetAllTransferLogs(false,"",SortByASC);

                lblNumOfTransferLog.Text = dgvTransferLogList.RowCount.ToString();

            }
            dgvTransferLogList.ColumnHeadersHeight = 25;


        }

        public frmTransferLogScreen()
        {
            InitializeComponent();
        }

        private void frmTransferLogScreen_Load(object sender, EventArgs e)
        {
            _FillListWithClients();
        }

        private void txtAccountNO_TextChanged(object sender, EventArgs e)
        {
            _FillListWithClients(true);
        }

        private void rbOrderClientListASC_CheckedChanged(object sender, EventArgs e)
        {
            _FillListWithClients();
        }

        private void rbOrderClientListDESC_CheckedChanged(object sender, EventArgs e)
        {
            _FillListWithClients(false, false);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            _FillListWithClients();
        }
    }
}
