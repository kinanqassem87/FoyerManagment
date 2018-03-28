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
    public partial class FRM_ChangePassword : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_ChangePassword()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select UPassword from Users", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (txtCurrent.Text.Equals("") || txtConfirm.Text.Equals("") || txtNew.Text.Equals(""))
            { MessageBox.Show("Please Fill All Fields"); return; }
            else 
            {
                if (txtCurrent.Text.Equals(dt.Rows[0][0])) 
                {
                    if (txtNew.Text.Equals(txtConfirm.Text)) 
                    {
                        con.Open();
                        OleDbCommand cmd = new OleDbCommand("update Users set UPassword='" + txtNew.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully Done");
                        this.Close();
                    }
                    else { MessageBox.Show("New Password and Confirm Password dismatch"); return; }
                }
                else { MessageBox.Show("Current Password not Valid"); return; }
            }
            
        }
    }
}
