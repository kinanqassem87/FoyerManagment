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
    public partial class FRM_BlackList : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_BlackList()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtIdentity.Text.Equals("") || txtFname.Text.Equals("") || txtLname.Text.Equals(""))
            {
                MessageBox.Show("Fields Required");
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("insert into BlackListTab (FName,Lname,FatherN,MotherN,B_Identiy)"+
                    " values ('"+txtFname.Text+"','"+txtLname.Text+"','"+txtfathern.Text+"','"+txtmothern.Text+"','"+txtIdentity.Text+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                txtFname.Text = txtLname.Text = txtfathern.Text = txtmothern.Text = txtIdentity.Text = "";
            }
        }

        private void btnManag_Click(object sender, EventArgs e)
        {
            FRM_BlackListManag fb = new FRM_BlackListManag();
            fb.ShowDialog();
        }
    }
}
