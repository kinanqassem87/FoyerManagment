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
    public partial class FRM_addTenantForRoom : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_addTenantForRoom(string s)
        {
            InitializeComponent();
            txtReserveID.Text = s;
            display();
        }
        void display() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_id,ten_fname,ten_lname,ten_father,ten_idintity from Tenants", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTenant.DataSource = dt;
        }

        private void dgvTenant_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dgvTenant.CurrentRow.Cells[0].Value.ToString();
            txtfname.Text = dgvTenant.CurrentRow.Cells[1].Value.ToString();
            txtlname.Text = dgvTenant.CurrentRow.Cells[2].Value.ToString();
            txtfather.Text = dgvTenant.CurrentRow.Cells[3].Value.ToString();
            txtIdentity.Text = dgvTenant.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_id,ten_fname,ten_lname,ten_father"+
                ",ten_idintity from Tenants where ten_fname+ten_lname+ten_father+ten_idintity like '%"+txtSearch.Text+"%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTenant.DataSource = dt;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from TenantReserveRoom", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int x = 0;
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                if (txtReserveID.Text.Equals(dt.Rows[i][2].ToString()) && txtID.Text.Equals(dt.Rows[i][1].ToString())) 
                {
                    x = 1;
                }
            }
            if (x != 1 && !txtID.Text.Equals("")) 
            {
                OleDbCommand cmd = new OleDbCommand("insert into TenantReserveRoom (ten_id,Reserve_ID)"+
                    " values ("+txtID.Text+","+txtReserveID.Text+")", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                txtID.Text = txtfname.Text = txtfather.Text = txtIdentity.Text = txtlname.Text = "";
                
                //******************************************
                OleDbDataAdapter tenID = new OleDbDataAdapter("select ten_id from TenantReserveRoom where Reserve_ID="+txtReserveID.Text+"", con);
                DataTable tenIDt = new DataTable();
                tenID.Fill(tenIDt);
                
                //*****************************************

                OleDbDataAdapter roomnum = new OleDbDataAdapter("select Room_Num,Elec_Counter,Beg_decade from ReserveInfo where Reserve_ID="+ txtReserveID.Text + "", con);
                DataTable roomnumt = new DataTable();
                roomnum.Fill(roomnumt);
                
                //*****************************************
                OleDbCommand cmd1 = new OleDbCommand("insert into Counter_Elec (ten_id,Room_num"+
                    ",counter_Am,Count_Date) values ('"+tenIDt.Rows[0][0].ToString()+"','"+roomnumt.Rows[0][0].ToString()+"'"+
                    ",'"+roomnumt.Rows[0][1].ToString()+"','"+roomnumt.Rows[0][2].ToString()+"')", con);
                
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

            }
            else 
            {
                MessageBox.Show("This Tenant is already added or you do not select one..");
            }
        }
    }
}
