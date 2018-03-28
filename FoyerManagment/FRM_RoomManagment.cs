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
    public partial class FRM_RoomManagment : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_RoomManagment()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Rooms", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRooms.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Rooms where Room_num+R_Area+R_Price+R_NumPer like '%"+txtSearch.Text+"%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvRooms.DataSource = dt;
        }

        private void dgvRooms_DoubleClick(object sender, EventArgs e)
        {
            txtRoomID.Text = dgvRooms.CurrentRow.Cells[0].Value.ToString();
            txtRoonNum.Text = dgvRooms.CurrentRow.Cells[1].Value.ToString();
            txtArea.Text = dgvRooms.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dgvRooms.CurrentRow.Cells[3].Value.ToString();
            txtNumOfPer.Text = dgvRooms.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtRoomID.Text.Equals("") || txtRoonNum.Text.Equals(""))
            {
                MessageBox.Show("Fields Required");
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("update Rooms set Room_num='"+txtRoonNum.Text+"'"+
                    ",R_Area='"+txtArea.Text+"',R_Price='"+txtPrice.Text+"'"+
                    ",R_NumPer='"+txtNumOfPer.Text+"' where Room_ID="+txtRoomID.Text+"", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                display();
                txtRoomID.Text = txtRoonNum.Text = txtArea.Text = txtNumOfPer.Text = txtPrice.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtRoomID.Text.Equals(""))
            {
                MessageBox.Show("Room not Selected");
                return;
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("delete from Rooms where Room_ID=" + txtRoomID.Text + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                display();
                txtRoomID.Text = txtRoonNum.Text = txtArea.Text = txtNumOfPer.Text = txtPrice.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtRoonNum.Text.Equals("")) { MessageBox.Show("Selected Room Please !!"); }
            else
            {
                FRM_RoomDetails frd = new FRM_RoomDetails(txtRoonNum.Text);
                frd.ShowDialog();
            }
        }
    }
}
