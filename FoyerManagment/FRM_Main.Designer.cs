namespace FoyerManagment
{
    partial class FRM_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.signInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_SignIN = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_ChangePass = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_Res = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_NewReserv = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_leaveRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_tenant = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_NTen = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_TenManag = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_blackList = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_room = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_NewRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_RoomManag = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_elctBill = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_PayBill = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_BillReports = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_report = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_rommstat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTenRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tsEndDec = new System.Windows.Forms.ToolStripMenuItem();
            this.allTenantRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tenantWithNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.payingMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elecMotorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.allPaymentsFromRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TS_About = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.signInToolStripMenuItem,
            this.TS_Res,
            this.ts_tenant,
            this.ts_room,
            this.ts_elctBill,
            this.ts_report,
            this.TS_About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // signInToolStripMenuItem
            // 
            this.signInToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_SignIN,
            this.TS_ChangePass});
            this.signInToolStripMenuItem.Name = "signInToolStripMenuItem";
            this.signInToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.signInToolStripMenuItem.Text = "Sign In";
            // 
            // TS_SignIN
            // 
            this.TS_SignIN.Name = "TS_SignIN";
            this.TS_SignIN.Size = new System.Drawing.Size(168, 22);
            this.TS_SignIN.Text = "Sign IN";
            this.TS_SignIN.Click += new System.EventHandler(this.TS_SignIN_Click);
            // 
            // TS_ChangePass
            // 
            this.TS_ChangePass.Enabled = false;
            this.TS_ChangePass.Name = "TS_ChangePass";
            this.TS_ChangePass.Size = new System.Drawing.Size(168, 22);
            this.TS_ChangePass.Text = "Change Password";
            this.TS_ChangePass.Click += new System.EventHandler(this.TS_ChangePass_Click);
            // 
            // TS_Res
            // 
            this.TS_Res.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_NewReserv,
            this.ts_leaveRoom});
            this.TS_Res.Enabled = false;
            this.TS_Res.Name = "TS_Res";
            this.TS_Res.Size = new System.Drawing.Size(80, 20);
            this.TS_Res.Text = "Reservation";
            // 
            // TS_NewReserv
            // 
            this.TS_NewReserv.Name = "TS_NewReserv";
            this.TS_NewReserv.Size = new System.Drawing.Size(162, 22);
            this.TS_NewReserv.Text = "New Reservation";
            this.TS_NewReserv.Click += new System.EventHandler(this.TS_NewReserv_Click);
            // 
            // ts_leaveRoom
            // 
            this.ts_leaveRoom.Name = "ts_leaveRoom";
            this.ts_leaveRoom.Size = new System.Drawing.Size(162, 22);
            this.ts_leaveRoom.Text = "Leave Room";
            this.ts_leaveRoom.Click += new System.EventHandler(this.ts_leaveRoom_Click);
            // 
            // ts_tenant
            // 
            this.ts_tenant.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_NTen,
            this.TS_TenManag,
            this.ts_blackList});
            this.ts_tenant.Enabled = false;
            this.ts_tenant.Name = "ts_tenant";
            this.ts_tenant.Size = new System.Drawing.Size(61, 20);
            this.ts_tenant.Text = "Tenants";
            // 
            // TS_NTen
            // 
            this.TS_NTen.Name = "TS_NTen";
            this.TS_NTen.Size = new System.Drawing.Size(179, 22);
            this.TS_NTen.Text = "New Tenant";
            this.TS_NTen.Click += new System.EventHandler(this.TS_NTen_Click);
            // 
            // TS_TenManag
            // 
            this.TS_TenManag.Name = "TS_TenManag";
            this.TS_TenManag.Size = new System.Drawing.Size(179, 22);
            this.TS_TenManag.Text = "Tenant Managment";
            this.TS_TenManag.Click += new System.EventHandler(this.TS_TenManag_Click);
            // 
            // ts_blackList
            // 
            this.ts_blackList.Name = "ts_blackList";
            this.ts_blackList.Size = new System.Drawing.Size(179, 22);
            this.ts_blackList.Text = "Black List";
            this.ts_blackList.Click += new System.EventHandler(this.ts_blackList_Click);
            // 
            // ts_room
            // 
            this.ts_room.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_NewRoom,
            this.TS_RoomManag});
            this.ts_room.Enabled = false;
            this.ts_room.Name = "ts_room";
            this.ts_room.Size = new System.Drawing.Size(56, 20);
            this.ts_room.Text = "Rooms";
            // 
            // TS_NewRoom
            // 
            this.TS_NewRoom.Name = "TS_NewRoom";
            this.TS_NewRoom.Size = new System.Drawing.Size(174, 22);
            this.TS_NewRoom.Text = "New Room";
            this.TS_NewRoom.Click += new System.EventHandler(this.TS_NewRoom_Click);
            // 
            // TS_RoomManag
            // 
            this.TS_RoomManag.Name = "TS_RoomManag";
            this.TS_RoomManag.Size = new System.Drawing.Size(174, 22);
            this.TS_RoomManag.Text = "Room Managment";
            this.TS_RoomManag.Click += new System.EventHandler(this.TS_RoomManag_Click);
            // 
            // ts_elctBill
            // 
            this.ts_elctBill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_PayBill,
            this.TS_BillReports});
            this.ts_elctBill.Enabled = false;
            this.ts_elctBill.Name = "ts_elctBill";
            this.ts_elctBill.Size = new System.Drawing.Size(94, 20);
            this.ts_elctBill.Text = "Electricity Bills";
            // 
            // TS_PayBill
            // 
            this.TS_PayBill.Name = "TS_PayBill";
            this.TS_PayBill.Size = new System.Drawing.Size(133, 22);
            this.TS_PayBill.Text = "Pay Bill";
            this.TS_PayBill.Click += new System.EventHandler(this.TS_PayBill_Click);
            // 
            // TS_BillReports
            // 
            this.TS_BillReports.Name = "TS_BillReports";
            this.TS_BillReports.Size = new System.Drawing.Size(133, 22);
            this.TS_BillReports.Text = "Bill Reports";
            this.TS_BillReports.Click += new System.EventHandler(this.TS_BillReports_Click);
            // 
            // ts_report
            // 
            this.ts_report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_rommstat,
            this.tsTenRoom,
            this.tsEndDec,
            this.allTenantRecordsToolStripMenuItem,
            this.tenantWithNetToolStripMenuItem,
            this.toolStripSeparator1,
            this.payingMoneyToolStripMenuItem,
            this.toolStripSeparator2,
            this.allPaymentsFromRoomToolStripMenuItem,
            this.payingReportToolStripMenuItem});
            this.ts_report.Enabled = false;
            this.ts_report.Name = "ts_report";
            this.ts_report.Size = new System.Drawing.Size(59, 20);
            this.ts_report.Text = "Reports";
            // 
            // ts_rommstat
            // 
            this.ts_rommstat.Name = "ts_rommstat";
            this.ts_rommstat.Size = new System.Drawing.Size(187, 22);
            this.ts_rommstat.Text = "Room Status";
            this.ts_rommstat.Click += new System.EventHandler(this.ts_rommstat_Click);
            // 
            // tsTenRoom
            // 
            this.tsTenRoom.Name = "tsTenRoom";
            this.tsTenRoom.Size = new System.Drawing.Size(187, 22);
            this.tsTenRoom.Text = "Tenant in Room Now";
            this.tsTenRoom.Click += new System.EventHandler(this.tsTenRoom_Click);
            // 
            // tsEndDec
            // 
            this.tsEndDec.Name = "tsEndDec";
            this.tsEndDec.Size = new System.Drawing.Size(187, 22);
            this.tsEndDec.Text = "End Decade For Ten";
            this.tsEndDec.Click += new System.EventHandler(this.tsEndDec_Click);
            // 
            // allTenantRecordsToolStripMenuItem
            // 
            this.allTenantRecordsToolStripMenuItem.Name = "allTenantRecordsToolStripMenuItem";
            this.allTenantRecordsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.allTenantRecordsToolStripMenuItem.Text = "All Tenant Records";
            this.allTenantRecordsToolStripMenuItem.Click += new System.EventHandler(this.allTenantRecordsToolStripMenuItem_Click);
            // 
            // tenantWithNetToolStripMenuItem
            // 
            this.tenantWithNetToolStripMenuItem.Name = "tenantWithNetToolStripMenuItem";
            this.tenantWithNetToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.tenantWithNetToolStripMenuItem.Text = "Tenant With Net";
            this.tenantWithNetToolStripMenuItem.Click += new System.EventHandler(this.tenantWithNetToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // payingMoneyToolStripMenuItem
            // 
            this.payingMoneyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elecMotorToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.payingMoneyToolStripMenuItem.Name = "payingMoneyToolStripMenuItem";
            this.payingMoneyToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.payingMoneyToolStripMenuItem.Text = "Paying Money";
            // 
            // elecMotorToolStripMenuItem
            // 
            this.elecMotorToolStripMenuItem.Name = "elecMotorToolStripMenuItem";
            this.elecMotorToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.elecMotorToolStripMenuItem.Text = "Elec Motor";
            this.elecMotorToolStripMenuItem.Click += new System.EventHandler(this.elecMotorToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.otherToolStripMenuItem.Text = "Other";
            this.otherToolStripMenuItem.Click += new System.EventHandler(this.otherToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // allPaymentsFromRoomToolStripMenuItem
            // 
            this.allPaymentsFromRoomToolStripMenuItem.Name = "allPaymentsFromRoomToolStripMenuItem";
            this.allPaymentsFromRoomToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.allPaymentsFromRoomToolStripMenuItem.Text = "Catch Money Report";
            this.allPaymentsFromRoomToolStripMenuItem.Click += new System.EventHandler(this.allPaymentsFromRoomToolStripMenuItem_Click);
            // 
            // payingReportToolStripMenuItem
            // 
            this.payingReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorToolStripMenuItem,
            this.otherToolStripMenuItem1});
            this.payingReportToolStripMenuItem.Name = "payingReportToolStripMenuItem";
            this.payingReportToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.payingReportToolStripMenuItem.Text = "Paying Report";
            // 
            // motorToolStripMenuItem
            // 
            this.motorToolStripMenuItem.Name = "motorToolStripMenuItem";
            this.motorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.motorToolStripMenuItem.Text = "Motor";
            this.motorToolStripMenuItem.Click += new System.EventHandler(this.motorToolStripMenuItem_Click);
            // 
            // otherToolStripMenuItem1
            // 
            this.otherToolStripMenuItem1.Name = "otherToolStripMenuItem1";
            this.otherToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.otherToolStripMenuItem1.Text = "Other";
            this.otherToolStripMenuItem1.Click += new System.EventHandler(this.otherToolStripMenuItem1_Click);
            // 
            // TS_About
            // 
            this.TS_About.Name = "TS_About";
            this.TS_About.Size = new System.Drawing.Size(52, 20);
            this.TS_About.Text = "About";
            this.TS_About.Click += new System.EventHandler(this.TS_About_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "End Decade:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(400, 81);
            this.dataGridView1.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 423);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Visible = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 449);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoyerManagment.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1178, 509);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 535);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Interface";
            this.Activated += new System.EventHandler(this.FRM_Main_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_tenant;
        private System.Windows.Forms.ToolStripMenuItem TS_NTen;
        private System.Windows.Forms.ToolStripMenuItem TS_TenManag;
        private System.Windows.Forms.ToolStripMenuItem ts_room;
        private System.Windows.Forms.ToolStripMenuItem TS_NewRoom;
        private System.Windows.Forms.ToolStripMenuItem TS_RoomManag;
        private System.Windows.Forms.ToolStripMenuItem TS_Res;
        private System.Windows.Forms.ToolStripMenuItem TS_NewReserv;
        private System.Windows.Forms.ToolStripMenuItem ts_elctBill;
        private System.Windows.Forms.ToolStripMenuItem TS_PayBill;
        private System.Windows.Forms.ToolStripMenuItem TS_BillReports;
        private System.Windows.Forms.ToolStripMenuItem ts_report;
        private System.Windows.Forms.ToolStripMenuItem TS_About;
        private System.Windows.Forms.ToolStripMenuItem signInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TS_SignIN;
        private System.Windows.Forms.ToolStripMenuItem TS_ChangePass;
        private System.Windows.Forms.ToolStripMenuItem ts_blackList;
        private System.Windows.Forms.ToolStripMenuItem ts_leaveRoom;
        private System.Windows.Forms.ToolStripMenuItem ts_rommstat;
        private System.Windows.Forms.ToolStripMenuItem tsTenRoom;
        private System.Windows.Forms.ToolStripMenuItem tsEndDec;
        private System.Windows.Forms.ToolStripMenuItem allTenantRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tenantWithNetToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem allPaymentsFromRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payingMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elecMotorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem payingReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem1;
    }
}