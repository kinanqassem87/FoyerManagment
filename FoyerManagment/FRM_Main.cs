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
    public partial class FRM_Main : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public static int x = 0;
        public FRM_Main()
        {
            InitializeComponent();
            
            MessageBox.Show("Done");

            OleDbDataAdapter da = new OleDbDataAdapter("select ten_fname+' '+ten_father+' '+ten_lname as [Full Name]" +
                ",Room_Num,Beg_decade,End_decade from ((TenantReserveRoom inner join ReserveInfo" +
                " ON TenantReserveRoom.Reserve_ID=ReserveInfo.Reserve_ID)" +
                "inner join Tenants ON TenantReserveRoom.ten_id=Tenants.ten_id)" +
                "where End_decade between '" + dateTimePicker1.Value.Date.ToShortDateString() + "' and '" + dateTimePicker2.Value.AddDays(2).Date.ToShortDateString() + "' order by End_decade desc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void TS_SignIN_Click(object sender, EventArgs e)
        {
            FRM_SignIn fs = new FRM_SignIn();
            fs.ShowDialog();
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            if (x == 1)
            {
                TS_ChangePass.Enabled = TS_Res.Enabled = ts_tenant.Enabled = ts_room.Enabled = ts_elctBill.Enabled = ts_report.Enabled = true;
                TS_SignIN.Enabled = false;
            }
        }

        private void TS_ChangePass_Click(object sender, EventArgs e)
        {
            FRM_ChangePassword fc = new FRM_ChangePassword();
            fc.ShowDialog();
        }

        private void TS_NTen_Click(object sender, EventArgs e)
        {
            FRM_NewTenant fn = new FRM_NewTenant();
            fn.ShowDialog();
        }

        private void TS_TenManag_Click(object sender, EventArgs e)
        {
            FRM_TenantManagment ftm = new FRM_TenantManagment();
            ftm.ShowDialog();
        }

        private void TS_NewRoom_Click(object sender, EventArgs e)
        {
            FRM_NewRoom fnr = new FRM_NewRoom();
            fnr.ShowDialog();
        }

        private void TS_RoomManag_Click(object sender, EventArgs e)
        {
            FRM_RoomManagment frm = new FRM_RoomManagment();
            frm.ShowDialog();
        }

        private void ts_blackList_Click(object sender, EventArgs e)
        {
            FRM_BlackList fb = new FRM_BlackList();
            fb.ShowDialog();
        }

        private void TS_NewReserv_Click(object sender, EventArgs e)
        {
            FRM_NewReservation fn = new FRM_NewReservation();
            fn.ShowDialog();
        }

        private void TS_PayBill_Click(object sender, EventArgs e)
        {
            FRM_ElecBillPay fe = new FRM_ElecBillPay();
            fe.ShowDialog();
        }

        private void ts_leaveRoom_Click(object sender, EventArgs e)
        {
            FRM_LeaveRoom fl = new FRM_LeaveRoom();
            fl.ShowDialog();
        }

        private void TS_BillReports_Click(object sender, EventArgs e)
        {
            FRM_BillReports fb = new FRM_BillReports();
            fb.ShowDialog();
        }

        private void ts_rommstat_Click(object sender, EventArgs e)
        {
            FRM_RoomStatus fr = new FRM_RoomStatus();
            fr.ShowDialog();
        }

        private void tsTenRoom_Click(object sender, EventArgs e)
        {
            FRM_RepRoomWithTen fr = new FRM_RepRoomWithTen();
            fr.ShowDialog();
        }

        private void tsEndDec_Click(object sender, EventArgs e)
        {
            FRM_RepEndDecade fr = new FRM_RepEndDecade();
            fr.ShowDialog();
        }

        private void allTenantRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RepTenantInFoyer fr = new FRM_RepTenantInFoyer();
            fr.ShowDialog();
        }

        private void tenantWithNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_TenantWithNet ft = new FRM_TenantWithNet();
            ft.ShowDialog();
        }

        private void TS_About_Click(object sender, EventArgs e)
        {
            FRM_About fs = new FRM_About();
            fs.ShowDialog();
        }

        private void allPaymentsFromRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CatchMoneyRoom fc = new FRM_CatchMoneyRoom();
            fc.ShowDialog();
        }

        private void elecMotorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RFM_Motor fm = new RFM_Motor();
            fm.ShowDialog();
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Other fo = new FRM_Other();
            fo.ShowDialog();
        }

        private void motorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RepMotor fr = new FRM_RepMotor();
            fr.ShowDialog();
        }

        private void otherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_RepOther fr = new FRM_RepOther();
            fr.ShowDialog();
        }

        
    }
}
