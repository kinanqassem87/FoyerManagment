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
    public partial class FRM_RepTenRoom : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_RepTenRoom(string s)
        {
            InitializeComponent();
            txtID.Text = s;
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_fname as 'FName',ten_lname as 'LName',ten_father as 'FAName'" +
                ",ten_mother as 'MName',ten_phone as 'Phone',ten_job as 'Job',ten_typeDoc as 'TypeDoc'" +
                ",ten_idintity as 'ID',ten_nation as 'Nation',ten_sex as 'Sex',ten_placeBirth as 'Place'" +
                ",ten_DateBirth as 'Date',ten_Addinfo as 'Info' from TenantReserveRoom inner join Tenants ON TenantReserveRoom.ten_id=Tenants.ten_id where TenantReserveRoom.Reserve_ID=" + txtID.Text + "", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAllUsers.DataSource = dt;
        }
    }
}
