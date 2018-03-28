namespace FoyerManagment
{
    partial class FRM_NewReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_NewReservation));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRoomNum = new System.Windows.Forms.ComboBox();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.txtelec = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMaintenantnce = new System.Windows.Forms.TextBox();
            this.cmbInternet = new System.Windows.Forms.ComboBox();
            this.btnAddTen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtxtDetails = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtnumofper = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnetAmount = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Begin of the decade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "End of the decade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Elec Counter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Maintenance:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Internet:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Add Tenant To Room:";
            // 
            // cmbRoomNum
            // 
            this.cmbRoomNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomNum.FormattingEnabled = true;
            this.cmbRoomNum.Location = new System.Drawing.Point(121, 6);
            this.cmbRoomNum.Name = "cmbRoomNum";
            this.cmbRoomNum.Size = new System.Drawing.Size(220, 21);
            this.cmbRoomNum.TabIndex = 8;
            this.cmbRoomNum.SelectedIndexChanged += new System.EventHandler(this.cmbRoomNum_SelectedIndexChanged);
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(121, 33);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(220, 20);
            this.dtpBegin.TabIndex = 9;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(121, 59);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(220, 20);
            this.dtpEnd.TabIndex = 10;
            // 
            // txtelec
            // 
            this.txtelec.Location = new System.Drawing.Point(121, 85);
            this.txtelec.Name = "txtelec";
            this.txtelec.Size = new System.Drawing.Size(220, 20);
            this.txtelec.TabIndex = 11;
            this.txtelec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtelec_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(99, 15);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(220, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtMaintenantnce
            // 
            this.txtMaintenantnce.Location = new System.Drawing.Point(121, 111);
            this.txtMaintenantnce.Name = "txtMaintenantnce";
            this.txtMaintenantnce.Size = new System.Drawing.Size(220, 20);
            this.txtMaintenantnce.TabIndex = 13;
            this.txtMaintenantnce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaintenantnce_KeyPress);
            // 
            // cmbInternet
            // 
            this.cmbInternet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInternet.FormattingEnabled = true;
            this.cmbInternet.Location = new System.Drawing.Point(121, 137);
            this.cmbInternet.Name = "cmbInternet";
            this.cmbInternet.Size = new System.Drawing.Size(75, 21);
            this.cmbInternet.TabIndex = 14;
            this.cmbInternet.SelectedIndexChanged += new System.EventHandler(this.cmbInternet_SelectedIndexChanged);
            // 
            // btnAddTen
            // 
            this.btnAddTen.Enabled = false;
            this.btnAddTen.Location = new System.Drawing.Point(121, 190);
            this.btnAddTen.Name = "btnAddTen";
            this.btnAddTen.Size = new System.Drawing.Size(220, 23);
            this.btnAddTen.TabIndex = 15;
            this.btnAddTen.Text = "Add Tenant";
            this.btnAddTen.UseVisualStyleBackColor = true;
            this.btnAddTen.Click += new System.EventHandler(this.btnAddTen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(121, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(266, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtxtDetails);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtnumofper);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtArea);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(347, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 207);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Info:";
            // 
            // rtxtDetails
            // 
            this.rtxtDetails.Location = new System.Drawing.Point(99, 97);
            this.rtxtDetails.Name = "rtxtDetails";
            this.rtxtDetails.ReadOnly = true;
            this.rtxtDetails.Size = new System.Drawing.Size(220, 96);
            this.rtxtDetails.TabIndex = 18;
            this.rtxtDetails.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Details:";
            // 
            // txtnumofper
            // 
            this.txtnumofper.Location = new System.Drawing.Point(99, 71);
            this.txtnumofper.Name = "txtnumofper";
            this.txtnumofper.ReadOnly = true;
            this.txtnumofper.Size = new System.Drawing.Size(220, 20);
            this.txtnumofper.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Num Of Person:";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(99, 45);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(220, 20);
            this.txtArea.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Area:";
            // 
            // txtnetAmount
            // 
            this.txtnetAmount.Enabled = false;
            this.txtnetAmount.Location = new System.Drawing.Point(202, 137);
            this.txtnetAmount.Name = "txtnetAmount";
            this.txtnetAmount.Size = new System.Drawing.Size(139, 20);
            this.txtnetAmount.TabIndex = 19;
            this.txtnetAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnetAmount_KeyPress);
            // 
            // FRM_NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 218);
            this.Controls.Add(this.txtnetAmount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddTen);
            this.Controls.Add(this.cmbInternet);
            this.Controls.Add(this.txtMaintenantnce);
            this.Controls.Add(this.txtelec);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.cmbRoomNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_NewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Reservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRoomNum;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox txtelec;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMaintenantnce;
        private System.Windows.Forms.ComboBox cmbInternet;
        private System.Windows.Forms.Button btnAddTen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxtDetails;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtnumofper;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnetAmount;
    }
}