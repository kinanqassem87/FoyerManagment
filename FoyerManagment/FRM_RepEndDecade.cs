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
    public partial class FRM_RepEndDecade : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_RepEndDecade()
        {
            InitializeComponent();
            //dateTimePicker2.Value.AddDays(40);
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_fname+' '+ten_father+' '+ten_lname as [Full Name]" +
                ",Room_Num,Beg_decade,End_decade from ((TenantReserveRoom inner join ReserveInfo" +
                " ON TenantReserveRoom.Reserve_ID=ReserveInfo.Reserve_ID)" +
                "inner join Tenants ON TenantReserveRoom.ten_id=Tenants.ten_id)" +
                "where End_decade between '" + dateTimePicker1.Value.Date.ToShortDateString() + "' and '" + dateTimePicker2.Value.AddDays(2).Date.ToShortDateString() + "' order by End_decade desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTenDec.DataSource = dt;

           
        }
    }
}
