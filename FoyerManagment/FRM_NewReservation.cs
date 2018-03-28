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
    public partial class FRM_NewReservation : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_NewReservation()
        {
            InitializeComponent();
            fullcmbRoNum();
            cmbFullNet();
        }
        void fullcmbRoNum() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select RoomNum from RoomState where state='0'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                cmbRoomNum.Items.Add(dt.Rows[i][0].ToString());
            }
            
        }
        void cmbFullNet() 
        {
            cmbInternet.Items.Add("Yes");
            cmbInternet.Items.Add("No");
        }

        private void cmbRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomNum.Text.Equals("")) { }
            else 
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select * from Rooms where Room_num='"+cmbRoomNum.Text+"'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                txtArea.Text = dt.Rows[0][2].ToString();
                txtPrice.Text = dt.Rows[0][3].ToString();
                txtnumofper.Text = dt.Rows[0][4].ToString();

                OleDbDataAdapter da1 = new OleDbDataAdapter("select R_object,Discreption from RoomDetails where Room_Num='" + cmbRoomNum.Text + "'", con);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                string s = "";
                for (int i = 0; i < dt1.Rows.Count; i++) 
                {
                    s+=dt1.Rows[i][0].ToString()+ "   " +dt1.Rows[i][1].ToString()+"\n";
                }
                rtxtDetails.Text = s;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbInternet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInternet.Text.Equals("Yes"))
            {
                txtnetAmount.Enabled = true;
            }
            else 
            {
                txtnetAmount.Enabled = false;
            }
        }

        private void txtelec_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txtMaintenantnce_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void txtnetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbRoomNum.Text.Equals("") || cmbInternet.Text.Equals("") || txtelec.Text.Equals("") || txtMaintenantnce.Text.Equals(""))
            {
                MessageBox.Show("Please Fill All Fields !!");
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("insert into ReserveInfo (Room_Num,Beg_decade,End_decade,Elec_Counter"+
                    ",Maintence,Net_State,Net_Amount)" +
                    " values ('"+cmbRoomNum.Text+"','"+dtpBegin.Value.Date.ToShortDateString()+"'"+
                    ",'"+dtpEnd.Value.Date.ToShortDateString()+"','"+txtelec.Text+"'"+
                    ",'"+txtMaintenantnce.Text+"','"+cmbInternet.Text+"','"+txtnetAmount.Text+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                txtMaintenantnce.Enabled = txtelec.Enabled = txtnetAmount.Enabled = false;
                txtArea.Enabled = txtPrice.Enabled = txtnumofper.Enabled = rtxtDetails.Enabled = false;
                //***********************************************************************
                OleDbCommand cmd1 = new OleDbCommand("update RoomState set state='1' where RoomNum='"+cmbRoomNum.Text+"'", con);
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();


                //***********************************************************************
                cmbRoomNum.Enabled = false;
                btnSave.Enabled=btnCancel.Enabled = false;
                btnAddTen.Enabled = true;

                OleDbDataAdapter da = new OleDbDataAdapter("select Reserve_ID from ReserveInfo order by Reserve_ID desc", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                FRM_addTenantForRoom fa = new FRM_addTenantForRoom(dt.Rows[0][0].ToString());
                fa.ShowDialog();
                
            }
        }

        private void btnAddTen_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select Reserve_ID from ReserveInfo order by Reserve_ID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            FRM_addTenantForRoom fa = new FRM_addTenantForRoom(dt.Rows[0][0].ToString());
            fa.ShowDialog();
        }
    }
}
