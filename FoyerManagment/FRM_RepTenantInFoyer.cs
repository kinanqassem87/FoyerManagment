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
    public partial class FRM_RepTenantInFoyer : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_RepTenantInFoyer()
        {
            InitializeComponent();
            if (dateTimePicker1.Value.Date.ToShortDateString().Equals(dateTimePicker2.Value.Date.ToShortDateString()))
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select ReserveInfo.Reserve_ID,ten_fname+' '+ten_father+' '+ten_lname as [Full Name]" +
                ",Room_Num,Beg_decade,End_decade from ((TenantReserveRoom inner join ReserveInfo" +
                " ON TenantReserveRoom.Reserve_ID=ReserveInfo.Reserve_ID)" +
                "inner join Tenants ON TenantReserveRoom.ten_id=Tenants.ten_id) order by End_decade desc", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAllTen.DataSource = dt;
            }
            else
            {
                display();
            }
        }
        void display() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ReserveInfo.Reserve_ID,ten_fname+' '+ten_father+' '+ten_lname as [Full Name]" +
                ",Room_Num,Beg_decade,End_decade from ((TenantReserveRoom inner join ReserveInfo" +
                " ON TenantReserveRoom.Reserve_ID=ReserveInfo.Reserve_ID)" +
                "inner join Tenants ON TenantReserveRoom.ten_id=Tenants.ten_id)"+
                "where End_decade between '" + dateTimePicker1.Value.Date.ToShortDateString() + "' and '" + dateTimePicker2.Value.Date.ToShortDateString() + "' order by End_decade desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAllTen.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            display();
        }

        private void dgvAllTen_DoubleClick(object sender, EventArgs e)
        {
            FRM_RepTenRoom fr = new FRM_RepTenRoom(dgvAllTen.CurrentRow.Cells[0].Value.ToString());
            fr.ShowDialog();
        }
    }
}
