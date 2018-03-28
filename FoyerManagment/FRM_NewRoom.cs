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
    public partial class FRM_NewRoom : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_NewRoom()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int x = 0;
            OleDbDataAdapter da = new OleDbDataAdapter("select Room_num from Rooms", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                if (txtRoonNum.Text.Equals(dt.Rows[i][0].ToString())) 
                {
                    x = 1;
                }
            }
            if (x != 1)
            {
                if (txtRoonNum.Text.Equals("") || txtPrice.Text.Equals("") || txtArea.Text.Equals("") || txtNumOfPer.Text.Equals(""))
                {
                    MessageBox.Show("All Fields Required");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Rooms (Room_num,R_Area,R_Price,R_NumPer) values ('" + txtRoonNum.Text + "'" +
                        ",'" + txtArea.Text + "','" + txtPrice.Text + "','" + txtNumOfPer.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                   

                    OleDbCommand cmd1 = new OleDbCommand("insert into RoomState (RoomNum,state) values ('"+txtRoonNum.Text+"',0)", con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Successfully Done");
                    txtArea.Text = txtNumOfPer.Text = txtPrice.Text = txtRoonNum.Text = "";

                }
            }
            else { MessageBox.Show("Room Existing"); return; }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char d = char.Parse(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
        }
    }
}
