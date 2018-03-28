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
    public partial class FRM_BlackListManag : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_BlackListManag()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from BlackListTab", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvblack.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from BlackListTab where FName+Lname+B_Identiy like '%"+txtSearch.Text+"%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvblack.DataSource = dt;
        }

        private void dgvblack_DoubleClick(object sender, EventArgs e)
        {
            txtUID.Text = dgvblack.CurrentRow.Cells[0].Value.ToString();
            txtFname.Text = dgvblack.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text = dgvblack.CurrentRow.Cells[2].Value.ToString();
            txtfathern.Text = dgvblack.CurrentRow.Cells[3].Value.ToString();
            txtmothern.Text = dgvblack.CurrentRow.Cells[4].Value.ToString();
            txtIdentity.Text = dgvblack.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUID.Text.Equals("") || txtFname.Text.Equals("") || txtLname.Text.Equals("") || txtIdentity.Text.Equals(""))
            {
                MessageBox.Show("Selected Member please !!");
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("update BlackListTab set FName='"+txtFname.Text+"'"+
                    ",Lname='"+txtLname.Text+"',FatherN='"+txtfathern.Text+"'"+
                    ",MotherN='" + txtmothern.Text + "',B_Identiy='" + txtIdentity.Text + "' where Black_ID="+txtUID.Text+"", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                txtFname.Text = txtLname.Text = txtfathern.Text = txtmothern.Text = txtUID.Text = txtIdentity.Text = "";
                display();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUID.Text.Equals(""))
            {
                MessageBox.Show("Selected Member please !!");
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("delete from BlackListTab where Black_ID=" + txtUID.Text + "", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                txtUID.Text = txtfathern.Text = txtFname.Text = txtIdentity.Text = txtLname.Text = txtmothern.Text = "";
                display();
            }
        }
    }
}
