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
    public partial class FRM_TenantManagment : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_TenantManagment()
        {
            InitializeComponent();
            display();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void display() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_id as 'UID',ten_fname as 'FName',ten_lname as 'LName',ten_father as 'FAName'" +
                ",ten_mother as 'MName',ten_phone as 'Phone',ten_job as 'Job',ten_typeDoc as 'TypeDoc'"+
                ",ten_idintity as 'ID',ten_nation as 'Nation',ten_sex as 'Sex',ten_placeBirth as 'Place'"+
                ",ten_DateBirth as 'Date',ten_Addinfo as 'Info' from Tenants", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAllUsers.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_id as 'UID',ten_fname as 'FName',ten_lname as 'LName',ten_father as 'FAName'" +
                ",ten_mother as 'MName',ten_phone as 'Phone',ten_job as 'Job',ten_typeDoc as 'TypeDoc'" +
                ",ten_idintity as 'ID',ten_nation as 'Nation',ten_sex as 'Sex',ten_placeBirth as 'Place'" +
                ",ten_DateBirth as 'Date',ten_Addinfo as 'Info' from Tenants"+
                " where ten_fname+ten_lname+ten_father+ten_mother+ten_phone+ten_nation+ten_sex+ten_idintity like '%"+txtSearch.Text+"%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAllUsers.DataSource = dt;
        }

        private void dgvAllUsers_DoubleClick(object sender, EventArgs e)
        {
            txtUserID.Text = dgvAllUsers.CurrentRow.Cells[0].Value.ToString();
            txtFname.Text = dgvAllUsers.CurrentRow.Cells[1].Value.ToString();
            txtlastname.Text = dgvAllUsers.CurrentRow.Cells[2].Value.ToString();
            txtfather.Text = dgvAllUsers.CurrentRow.Cells[3].Value.ToString();
            txtmother.Text = dgvAllUsers.CurrentRow.Cells[4].Value.ToString();
            txtphonenumber.Text = dgvAllUsers.CurrentRow.Cells[5].Value.ToString();
            txtjob.Text = dgvAllUsers.CurrentRow.Cells[6].Value.ToString();
            txttypeDoc.Text = dgvAllUsers.CurrentRow.Cells[7].Value.ToString();
            txtID.Text = dgvAllUsers.CurrentRow.Cells[8].Value.ToString();
            txtNation.Text = dgvAllUsers.CurrentRow.Cells[9].Value.ToString();
            txtsex.Text = dgvAllUsers.CurrentRow.Cells[10].Value.ToString();
            txtplaceBirth.Text = dgvAllUsers.CurrentRow.Cells[11].Value.ToString();
            dtpDateBirth.Value = DateTime.Parse( dgvAllUsers.CurrentRow.Cells[12].Value.ToString());
            rtxtAddinfo.Text = dgvAllUsers.CurrentRow.Cells[13].Value.ToString();
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtFname.Text.Equals("") || txtfather.Text.Equals("") || txtlastname.Text.Equals("") || txtID.Text.Equals("")||txtUserID.Text.Equals(""))
            {
                MessageBox.Show("First name, last name, Father name and ID  :  Required");
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("update Tenants set ten_fname = '"+txtFname.Text+"' ,ten_lname ='"+txtlastname.Text+"' ,ten_father='"+txtfather.Text+"' " +
                ",ten_mother='"+txtmother.Text+"' ,ten_phone='"+txtphonenumber.Text+"' ,ten_job='"+txtjob.Text+"' ,ten_typeDoc='"+txttypeDoc.Text+"' " +
                ",ten_idintity='"+txtID.Text+"' ,ten_nation='"+txtNation.Text+"' ,ten_sex='"+txtsex.Text+"' ,ten_placeBirth='"+txtplaceBirth.Text+"' " +
                ",ten_DateBirth='" + dtpDateBirth.Value.Date.ToShortDateString() + "' ,ten_Addinfo='" + rtxtAddinfo.Text + "' where ten_id="+txtUserID.Text+"", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                display();
                txtUserID.Text=txtFname.Text = txtfather.Text = txtlastname.Text = txtmother.Text = txtphonenumber.Text = txtjob.Text = txttypeDoc.Text = txtID.Text = txtNation.Text = txtsex.Text = txtplaceBirth.Text = rtxtAddinfo.Text = "";

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text.Equals(""))
            {
                MessageBox.Show("Tenant not Selected");
                return;
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("delete from Tenants where ten_id="+txtUserID.Text+"", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                display();
                txtUserID.Text = txtFname.Text = txtfather.Text = txtlastname.Text = txtmother.Text = txtphonenumber.Text = txtjob.Text = txttypeDoc.Text = txtID.Text = txtNation.Text = txtsex.Text = txtplaceBirth.Text = rtxtAddinfo.Text = "";

            }
        }
    }
}
