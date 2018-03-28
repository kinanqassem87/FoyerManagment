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
    public partial class FRM_RoomStatus : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_RoomStatus()
        {
            InitializeComponent();
            display();
            
        }
        //dt.Rows[0][1] = "No";
        void display() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select RoomNum,state from RoomState", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                if (dt.Rows[i][1].ToString().Equals("0"))
                {
                    dt.Rows[i][1] = "Empty";
                }
                else 
                {
                    dt.Rows[i][1] = "Reserved";
                }
            }
            dgvRoom.DataSource = dt;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select RoomNum,state from RoomState where RoomNum like '%" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString().Equals("0"))
                {
                    dt.Rows[i][1] = "Empty";
                }
                else
                {
                    dt.Rows[i][1] = "Reserved";
                }
            }
            dgvRoom.DataSource = dt;
        }
    }
}
