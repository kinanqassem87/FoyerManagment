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
    public partial class FRM_ElecBillPay : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_ElecBillPay()
        {
            InitializeComponent();
            txtValue.Text = "500";
            fillcmb();
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }
        void fillcmb() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select RoomNum from RoomState where state='1'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbRoonnum.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cmbRoonnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select Reserve_ID from ReserveInfo"+
                " "+
                " where Room_Num='" + cmbRoonnum.Text + "' order by Reserve_ID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            //*************
            


            //************
            OleDbDataAdapter da1 = new OleDbDataAdapter("select ten_id from TenantReserveRoom where Reserve_ID="+dt.Rows[0][0].ToString()+"", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            txtTenID.Text = dt1.Rows[0][0].ToString();
            //*************

            OleDbDataAdapter daelec = new OleDbDataAdapter("select counter_Am,Count_Date from Counter_Elec where ten_id='" + txtTenID.Text + "' and Room_num='"+cmbRoonnum.Text+"' order by Counter_ID desc", con);
            DataTable dtelec = new DataTable();
            daelec.Fill(dtelec);
            txtoldElec.Text = dtelec.Rows[0][0].ToString();
            txtDate.Text = dtelec.Rows[0][1].ToString();

            //***********
            OleDbDataAdapter da2 = new OleDbDataAdapter("select ten_fname,ten_father,ten_lname from Tenants where ten_id="+txtTenID.Text+"", con);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            txtTenName.Text = dt2.Rows[0][0].ToString()+" "+dt2.Rows[0][1].ToString()+" "+dt2.Rows[0][2].ToString();


        }

        private void txtNewElec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }
        
        void total() 
        {
            txtTotal.Text = ((int.Parse(txtNewElec.Text) - int.Parse(txtoldElec.Text)) * int.Parse(txtValue.Text)).ToString();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (txtoldElec.Text.Equals("") || txtNewElec.Text.Equals("")||txtValue.Text.Equals("")) 
            {
                MessageBox.Show("Fields Required");
            }
            else
            {
                total();
                btnPay.Enabled = true;
                btnCalc.Enabled =txtValue.Enabled=txtNewElec.Enabled=cmbRoonnum.Enabled= false;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string s = (int.Parse(txtNewElec.Text) - int.Parse(txtoldElec.Text)).ToString();
            OleDbCommand cmd = new OleDbCommand("insert into ElecBill (ten_id,Room_num"+
                ",Old_cont,Old_date,new_count,new_date,Amount"+
                ",Total) values ("+txtTenID.Text+",'"+cmbRoonnum.Text+"'"+
                ",'"+txtoldElec.Text+"','"+txtDate.Text+"','"+txtNewElec.Text+"'"+
                ",'"+DateTime.Now.Date.ToShortDateString()+"','"+s+"','"+txtTotal.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


            OleDbCommand cmd1 = new OleDbCommand("insert into Counter_Elec (ten_id,Room_num,counter_Am,Count_Date)"+
                " values ('"+txtTenID.Text+"','"+cmbRoonnum.Text+"','"+txtNewElec.Text+"'"+
                ",'"+DateTime.Now.Date.ToShortDateString()+"')", con);
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Successfully Done");
            btnPay.Enabled = false;

        }
        
        
    }
}
