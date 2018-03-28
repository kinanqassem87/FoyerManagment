namespace FoyerManagment
{
    partial class FRM_ElecBillPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ElecBillPay));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtTenName = new System.Windows.Forms.TextBox();
            this.txtoldElec = new System.Windows.Forms.TextBox();
            this.txtNewElec = new System.Windows.Forms.TextBox();
            this.txtTenID = new System.Windows.Forms.TextBox();
            this.cmbRoonnum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Num:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tenant Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TenID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "New Elec Counter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Elec Counter:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "For 1 K Watt >>";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(148, 7);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(54, 20);
            this.txtValue.TabIndex = 6;
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // txtTenName
            // 
            this.txtTenName.Location = new System.Drawing.Point(123, 75);
            this.txtTenName.Name = "txtTenName";
            this.txtTenName.ReadOnly = true;
            this.txtTenName.Size = new System.Drawing.Size(121, 20);
            this.txtTenName.TabIndex = 8;
            // 
            // txtoldElec
            // 
            this.txtoldElec.Location = new System.Drawing.Point(123, 101);
            this.txtoldElec.Name = "txtoldElec";
            this.txtoldElec.ReadOnly = true;
            this.txtoldElec.Size = new System.Drawing.Size(121, 20);
            this.txtoldElec.TabIndex = 9;
            // 
            // txtNewElec
            // 
            this.txtNewElec.Location = new System.Drawing.Point(123, 153);
            this.txtNewElec.Name = "txtNewElec";
            this.txtNewElec.Size = new System.Drawing.Size(121, 20);
            this.txtNewElec.TabIndex = 10;
            this.txtNewElec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewElec_KeyPress);
            // 
            // txtTenID
            // 
            this.txtTenID.Location = new System.Drawing.Point(296, 49);
            this.txtTenID.Name = "txtTenID";
            this.txtTenID.ReadOnly = true;
            this.txtTenID.Size = new System.Drawing.Size(100, 20);
            this.txtTenID.TabIndex = 11;
            // 
            // cmbRoonnum
            // 
            this.cmbRoonnum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoonnum.FormattingEnabled = true;
            this.cmbRoonnum.Location = new System.Drawing.Point(123, 48);
            this.cmbRoonnum.Name = "cmbRoonnum";
            this.cmbRoonnum.Size = new System.Drawing.Size(121, 21);
            this.cmbRoonnum.TabIndex = 12;
            this.cmbRoonnum.SelectedIndexChanged += new System.EventHandler(this.cmbRoonnum_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(296, 75);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // btnPay
            // 
            this.btnPay.Enabled = false;
            this.btnPay.Location = new System.Drawing.Point(296, 150);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 23);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(123, 127);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(121, 20);
            this.txtDate.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Date:";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(296, 101);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 23);
            this.btnCalc.TabIndex = 18;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // FRM_ElecBillPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 192);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbRoonnum);
            this.Controls.Add(this.txtTenID);
            this.Controls.Add(this.txtNewElec);
            this.Controls.Add(this.txtoldElec);
            this.Controls.Add(this.txtTenName);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ElecBillPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Elec Bill Pay";
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
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtTenName;
        private System.Windows.Forms.TextBox txtoldElec;
        private System.Windows.Forms.TextBox txtNewElec;
        private System.Windows.Forms.TextBox txtTenID;
        private System.Windows.Forms.ComboBox cmbRoonnum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalc;
    }
}