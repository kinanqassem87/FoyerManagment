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
    public partial class FRM_RoomDetails : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_RoomDetails(string s)
        {
            InitializeComponent();
            txtRoomnum.Text = s;
                OleDbDataAdapter da = new OleDbDataAdapter("select * from RoomDetails where Room_Num='" + s + "'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRoomDet.DataSource = dt;
            
            
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_RoomDetails_Activated(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from RoomDetails where Room_Num='" + txtRoomnum.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRoomDet.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_RDetails frd = new FRM_RDetails(txtRoomnum.Text);
            frd.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txtRoomnum.Text.Equals("") || txtObject.Text.Equals(""))
            {
                MessageBox.Show("Fields Required");
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("update RoomDetails set R_object='"+txtObject.Text+"'"+
                    ",Discreption='" + txtDiscription.Text + "' where RD_ID="+txtID.Text+" ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                txtObject.Text = txtDiscription.Text = "";
            }
        }

        private void dgvRoomDet_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dgvRoomDet.CurrentRow.Cells[0].Value.ToString();
            txtRoomnum.Text = dgvRoomDet.CurrentRow.Cells[1].Value.ToString();
            txtObject.Text = dgvRoomDet.CurrentRow.Cells[2].Value.ToString();
            txtDiscription.Text = dgvRoomDet.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Fields Required");
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("delete from RoomDetails where RD_ID=" + txtID.Text + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                txtID.Text = txtObject.Text = txtDiscription.Text = "";

            }
        }
       
    }
}
