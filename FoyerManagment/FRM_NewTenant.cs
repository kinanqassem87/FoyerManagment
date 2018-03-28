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
    public partial class FRM_NewTenant : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_NewTenant()
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
            int BlackList = 0;
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_idintity from Tenants", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (txtID.Text.Equals(dt.Rows[i][0].ToString()))
                {
                    x = 1;
                }
            }

            OleDbDataAdapter da1 = new OleDbDataAdapter("select B_Identiy from BlackListTab", con);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                if (txtID.Text.Equals(dt1.Rows[i][0].ToString()))
                {
                    BlackList = 1;
                }
            }


            if (x != 1 && BlackList!=1)
            {
                if (txtFname.Text.Equals("") || txtlastname.Text.Equals("") || txtfather.Text.Equals("") || txtID.Text.Equals(""))
                {
                    MessageBox.Show("First name, last name, Father name and ID  :  Required");
                }
                else
                {
                    OleDbCommand cmd = new OleDbCommand("insert into Tenants (ten_fname,ten_lname,ten_father," +
                        "ten_mother,ten_phone,ten_job,ten_typeDoc,ten_idintity,ten_nation,ten_sex,ten_placeBirth," +
                        "ten_DateBirth,ten_Addinfo) values ('" + txtFname.Text + "','" + txtlastname.Text + "','" + txtfather.Text + "'" +
                        ",'" + txtmother.Text + "','" + txtphonenumber.Text + "','" + txtjob.Text + "','" + txttypeDoc.Text + "'" +
                        ",'" + txtID.Text + "','" + txtNation.Text + "','" + txtsex.Text + "','" + txtplaceBirth.Text + "'" +
                        ",'" + dtpDateBirth.Value.Date.ToShortDateString() + "','" + rtxtAddinfo.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Done");
                    txtFname.Text = txtfather.Text = txtlastname.Text = txtmother.Text = txtphonenumber.Text = txtjob.Text = txttypeDoc.Text = txtID.Text = txtNation.Text = txtsex.Text = txtplaceBirth.Text = rtxtAddinfo.Text = "";

                }
            }
            else if(x==1) { MessageBox.Show("Tenant Existing"); return; }
            else if (BlackList == 1) { MessageBox.Show("Tenant in the BlackList"); return; }
        }
    }
}
