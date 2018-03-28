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
    public partial class FRM_RDetails : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_RDetails(string s)
        {
            InitializeComponent();
            txtRoomnum.Text = s;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtObject.Text.Equals(""))
            {
                MessageBox.Show("Required");
                return;
            }
            else 
            {
                OleDbCommand cmd = new OleDbCommand("insert into RoomDetails (Room_Num,R_object,Discreption)" +
                    " values ('"+txtRoomnum.Text+"','"+txtObject.Text+"','"+txtDiscription.Text+"')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Successfully Done");
                txtObject.Text = txtDiscription.Text = "";
            }
        }
    }
}
