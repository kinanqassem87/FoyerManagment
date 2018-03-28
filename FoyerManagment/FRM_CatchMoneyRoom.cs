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
    public partial class FRM_CatchMoneyRoom : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_CatchMoneyRoom()
        {
            InitializeComponent();
            OleDbDataAdapter da = new OleDbDataAdapter("select Room_num from Rooms", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbRoom.Items.Add(dt.Rows[i][0].ToString());
            }
            display();
            txttotal.Text = calTotal().ToString();
        }
        void display() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ReserveInfo.Room_num,Beg_decade,End_decade,Rooms.R_Price from" +
                " ReserveInfo inner join Rooms on ReserveInfo.Room_num=Rooms.Room_num", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
        }
        int calTotal()
        {
            int x = 0;
            for (int i = 0; i < dgvRoom.Rows.Count; i++)
            {
                x += int.Parse(dgvRoom.Rows[i].Cells[3].Value.ToString());
            }
            return x;
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ReserveInfo.Room_num,Beg_decade,End_decade,Rooms.R_Price from" +
                " ReserveInfo inner join Rooms on ReserveInfo.Room_num=Rooms.Room_num where Room_num='"+cmbRoom.Text+"'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txttotal.Text = calTotal().ToString();
        }
    }
}
