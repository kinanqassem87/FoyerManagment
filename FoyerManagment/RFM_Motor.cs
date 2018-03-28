using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FoyerManagment
{
    public partial class RFM_Motor : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public RFM_Motor()
        {
            InitializeComponent();
            txtPrice.Text = "500";
            btnPay.Enabled = false;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txtOld_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txtNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text.Equals("") || txtOld.Text.Equals("") || txtNew.Text.Equals(""))
            {
                MessageBox.Show("Fields Requird");
            }
            else 
            {
                txtAmount.Text = (int.Parse(txtNew.Text) - int.Parse(txtOld.Text)).ToString();
                txtTotal.Text = (int.Parse(txtAmount.Text) * int.Parse(txtPrice.Text)).ToString();
                btnCal.Enabled = txtPrice.Enabled = txtOld.Enabled = txtNew.Enabled = false;
                btnPay.Enabled = true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("insert into MotorBill (Price_U,Old_Counter,New_Counter,AmountM,TotalM,Date_Pay)" +
                " values ('"+txtPrice.Text+"','"+txtOld.Text+"','"+txtNew.Text+"','"+txtAmount.Text+"','"+txtTotal.Text+"','"+DateTime.Now.Date.ToShortDateString()+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done");
            btnPay.Enabled = false;
        }
    }
}
