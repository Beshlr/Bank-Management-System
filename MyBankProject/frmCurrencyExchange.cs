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
    public partial class frmCurrencyExchange : Form
    {
        private string _Username;
        private clsUser _User;

        public frmCurrencyExchange(clsUser User,string Username)
        {
            InitializeComponent();
            _Username = Username;
            _User = User;
        }

        clsCurrency Currency = new clsCurrency();
        
        clsCurrency Currency1 = new clsCurrency();
        clsCurrency Currency2 = new clsCurrency();

        
        private void _RefreshCurrenciesList(bool FindCurrency = false, bool SortedASC = true,string FindBy = "", string SearchText = "")
        {
            dgvCurrenciesList.DataSource = clsCurrency.GetAllCurrencies(FindCurrency, SortedASC,FindBy, SearchText);

            dgvCurrenciesList.ColumnHeadersHeight = 25;
            lblNumOfCurrencies.Text = dgvCurrenciesList.RowCount.ToString();
        }

        private void _FillcbWithCodes()
        {
            cbCurrency1Code.Items.Clear();
            cbCurrency2Code.Items.Clear();

            DataTable dt = clsCurrency.GetAllCurrenciesCodes();
            foreach (DataRow row in dt.Rows)
            {
                cbCurrency1Code.Items.Add(row["Code"]);
                cbCurrency2Code.Items.Add(row["Code"]);

            }
            cbCurrency1Code.SelectedIndex = 0;
            cbCurrency2Code.SelectedIndex = 1;
        }

        private void frmCurrencyExchange_Load(object sender, EventArgs e)
        {
            _RefreshCurrenciesList();
            _FillcbWithCodes();
            lblUsername.Text = _Username;
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblDateTime.Text = DateTime.Now.ToLongTimeString().ToString();
            timer1.Enabled = true;

        }

        private void rbCode_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchBarCurrency.PlaceholderText = "Enter Currency Code";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAccountNO_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchBarCurrency.Text.Length >0)
            {
                if(rbOrderCurrenciesListASC.Checked)
                {
                    if (rbCode.Checked)
                        _RefreshCurrenciesList(true, true, "Code", txtSearchBarCurrency.Text);
                    if (rbCountry.Checked)
                        _RefreshCurrenciesList(true, true, "Country", txtSearchBarCurrency.Text);
                    if (rbName.Checked)
                        _RefreshCurrenciesList(true, true, "Name", txtSearchBarCurrency.Text);
                }
                else
                {
                    if (rbCode.Checked)
                        _RefreshCurrenciesList(true, false, "Code", txtSearchBarCurrency.Text);
                    if (rbCountry.Checked)
                        _RefreshCurrenciesList(true, false, "Country", txtSearchBarCurrency.Text);
                    if (rbName.Checked)
                        _RefreshCurrenciesList(true, false, "Name", txtSearchBarCurrency.Text);
                }
            }
            else
            {
                _RefreshCurrenciesList();
            }

        }

        private void pbSearchIcon_Click(object sender, EventArgs e)
        {

        }

        private void pbFindClientSettings_Click(object sender, EventArgs e)
        {
            if (gbFindBy.Visible == true)
                gbFindBy.Visible = false;
            else
                gbFindBy.Visible = true;


        }

        private void txtSearchBarCurrency_Enter(object sender, EventArgs e)
        {
                gbFindBy.Visible = false;
        }

        private void rbOrderCurrenciesListDESC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCode.Checked)
                _RefreshCurrenciesList(false, false,"Code");
            if(rbCountry.Checked)
                _RefreshCurrenciesList(false, false,"Country");
            if(rbName.Checked)
                _RefreshCurrenciesList(false, false,"Name");


        }

        private void rbOrderCurrenciesListASC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCode.Checked)
                _RefreshCurrenciesList(false, true, "Code");
            if (rbCountry.Checked)
                _RefreshCurrenciesList(false, true, "Country");
            if (rbName.Checked)
                _RefreshCurrenciesList(false, true, "Name");
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            _RefreshCurrenciesList();
        }

        private void UpdateLabelPosition()
        {
            int rightControlRightEdge = label3.Left;

            lblNumOfCurrencies.Left = rightControlRightEdge + 200;
        }

        private void lblNumOfCurrencies_Click(object sender, EventArgs e)
        {

            UpdateLabelPosition();
        }

        private void updateRateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            button1.Visible = true;
            txtEnterNewRate.Visible = true;
            txtEnterNewRate.Focus();

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Code = dgvCurrenciesList.SelectedRows[0].Cells[1].Value.ToString();
            if (MessageBox.Show("Are You Sure You Want To Edit Rate Of Currency With Code [" + Code + "] From " +
                                dgvCurrenciesList.SelectedRows[0].Cells[3].Value.ToString() + " To " + txtEnterNewRate.Text + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (clsCurrency.UpdateCurrencyRate(Code, Convert.ToDecimal(txtEnterNewRate.Text)))
                {
                    MessageBox.Show("Update Done Successfully!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Update Didn't Complete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtEnterNewRate.Visible = false;
                button1.Visible = false;
            }
        }

        private void txtSearchBarCurrency_TextChanged(object sender, EventArgs e)
        {


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency1 = clsCurrency.GetCurrencyInfo(cbCurrency1Code.Text);
            lblCurrency1Rate.Text = Currency1.CurrencyRate.ToString()+"$";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cbCurrency2Code_SelectedIndexChanged(object sender, EventArgs e)
        {
            Currency2 = clsCurrency.GetCurrencyInfo(cbCurrency2Code.Text);
            lblCurrency2Rate.Text = Currency2.CurrencyRate.ToString()+"$";
            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            decimal result = 0;
            if (Currency1.CurrencyCode == "USD" || Currency1.CurrencyRate == 1)
            {
                result = (decimal)nudAmount.Value * Currency2.CurrencyRate;

            }
            else
            {
                if (cbCurrency2Code.Text != "USD")
                {
                    result = (Currency1.CurrencyRate * (decimal)nudAmount.Value) / Currency2.CurrencyRate;
                }
                else
                {
                    result = ((decimal)nudAmount.Value) * (1 / Currency1.CurrencyRate);
                }

            }
                lblResult.Text = ((float)result).ToString() + " " + Currency2.CurrencyCode;
        }

        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
        }

        private void FormatScreen()
        {
            cbCurrency1Code.SelectedIndex = -1;
            cbCurrency2Code.SelectedIndex = -1;
            lblCurrency1Rate.Text = "0$";
            lblCurrency2Rate.Text = "0$";
            lblResult.Text = "0";
            nudAmount.Value = 50;
            Currency1 = null;
            Currency2 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormatScreen();
        }

        private void _ReloadScreen()
        {
            Currency1 = clsCurrency.GetCurrencyInfo(cbCurrency1Code.Text);
            Currency2 = clsCurrency.GetCurrencyInfo(cbCurrency2Code.Text);
            lblCurrency1Rate.Text = Currency1.CurrencyRate.ToString() + "$";
            lblCurrency2Rate.Text = Currency2.CurrencyRate.ToString() + "$";
            lblResult.Text = "0";
            nudAmount.Value = 50;

        }

        private void pbSwitch_Click(object sender, EventArgs e)
        {
            string tempAccNo = "";

            tempAccNo = cbCurrency1Code.Text;
            cbCurrency1Code.Text = cbCurrency2Code.Text;
            cbCurrency2Code.Text = tempAccNo;
            _ReloadScreen();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form frm = new frmUserProfile(_User, lblUsername.Text);
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbCountry_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchBarCurrency.PlaceholderText = "Enter Country Name";
        }

        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearchBarCurrency.PlaceholderText = "Enter Currency Name";
        }

        private void cbCurrency1Code_TextChanged(object sender, EventArgs e)
        {
            //cbCurrency1Code.Text = clsCurrency.GetCurrencyCode(cbCurrency1Code.Text);
        }

        private void cbCurrency2Code_TextChanged(object sender, EventArgs e)
        {
            //cbCurrency2Code.Text = clsCurrency.GetCurrencyCode(cbCurrency2Code.Text);

        }
    }
}
