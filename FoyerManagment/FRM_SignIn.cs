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
    public partial class FRM_SignIn : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_SignIn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Users", con);
            DataTable dt=new DataTable();
            da.Fill(dt);
            if (txtUserName.Text.Equals("") && txtPassword.Text.Equals(""))
            {
                MessageBox.Show("Please fill all Fields");
                return;
            }
            else 
            {
                
                if (dt.Rows[0][1].Equals(txtUserName.Text))
                {
                    if (dt.Rows[0][2].Equals(txtPassword.Text)) 
                    {
                        FRM_Main.x = 1;
                        Close();
                    }
                    else { MessageBox.Show("Password Not Valid"); txtPassword.Text=txtUserName.Text = ""; return; }
                }
                else { MessageBox.Show("User Name Not Valid"); txtUserName.Text =txtPassword.Text= ""; return; }
            }
        }
    }
}
