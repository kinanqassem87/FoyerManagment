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
    public partial class FRM_LeaveRoom : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_LeaveRoom()
        {
            InitializeComponent();
            fillcmb();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void fillcmb()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select RoomNum from RoomState where state='1'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbRoomNum.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void cmbRoomNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select Reserve_ID,Beg_decade"+
                ",End_decade from ReserveInfo where Room_Num='" + cmbRoomNum.Text + "' order by Reserve_ID desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtBeg.Text = dt.Rows[0][1].ToString();
            txtLast.Text = dt.Rows[0][2].ToString();

            OleDbDataAdapter da1 = new OleDbDataAdapter("select Counter_ID,Count_Date from Counter_Elec"+
                " where Room_num='" + cmbRoomNum.Text + "' order by Counter_ID desc", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            txtElecDate.Text = dt1.Rows[0][1].ToString();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da1 = new OleDbDataAdapter("select Counter_ID,Count_Date from Counter_Elec" +
                " where Room_num='" + cmbRoomNum.Text + "' order by Counter_ID desc", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt1.Rows[0][1].ToString().Equals(DateTime.Now.Date.ToShortDateString())) 
            {
                OleDbCommand cmd = new OleDbCommand("update RoomState set state='0' where RoomNum='"+cmbRoomNum.Text+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                cmbRoomNum.Enabled = btnLeave.Enabled = false;
            }
            else 
            {
                MessageBox.Show("There is an electricity bill payable !!!!   You can not leave before pay bill Please.");
            }
        }
    }
}
