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
    public partial class FRM_BillReports : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_BillReports()
        {
            InitializeComponent();
            OleDbDataAdapter da = new OleDbDataAdapter("select Room_num from Rooms", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) 
            {
                cmbSearch.Items.Add(dt.Rows[i][0].ToString());
            }
            display();
            txtTotal.Text = calTotal().ToString();
        }
        //Tenants ElecBill +t.ten_father+t.ten_lname select ten_fname as 'Full Name' 
        //from (ElecBill e inner join Tenants t ON e.ten_id=t.ten_id)
        //on join must two field same type 
        void display() 
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_fname+' '+ten_father+' '+ten_lname as [Full Name]," +
                "Room_num,Old_cont as [Old Counter],Old_date as O_Date,new_count as [New Counter],new_date as N_Date"+
                ",Amount as KWatt,Total from (ElecBill e inner join Tenants t ON e.ten_id=t.ten_id) "
                + " ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvbills.DataSource = dt;
        }
        int calTotal() 
        {
            int x = 0;
            for (int i = 0; i < dgvbills.Rows.Count; i++)
            {
                x += int.Parse(dgvbills.Rows[i].Cells[7].Value.ToString());
            }
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_fname+' '+ten_father+' '+ten_lname as [Full Name]," +
                "Room_num,Old_cont as [Old Counter],Old_date as O_Date,new_count as [New Counter],new_date as N_Date" +
                ",Amount as KWatt,Total from (ElecBill e inner join Tenants t ON e.ten_id=t.ten_id) "
                + "where new_date between '" + dateTimePicker1.Value.Date.ToShortDateString() + "' and '" + dateTimePicker2.Value.Date.ToShortDateString() + "' ", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvbills.DataSource = dt;
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select ten_fname+' '+ten_father+' '+ten_lname as [Full Name]," +
                "Room_num,Old_cont as [Old Counter],Old_date as O_Date,new_count as [New Counter],new_date as N_Date" +
                ",Amount as KWatt,Total from (ElecBill e inner join Tenants t ON e.ten_id=t.ten_id) "
                + "where Room_num = '" + cmbSearch.Text + "'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvbills.DataSource = dt;
            txtTotal.Text = calTotal().ToString();
        }
    }
}
