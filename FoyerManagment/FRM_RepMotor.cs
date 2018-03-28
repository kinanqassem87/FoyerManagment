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
    public partial class FRM_RepMotor : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Foyer.accdb;Persist Security Info=True");
        public FRM_RepMotor()
        {
            InitializeComponent();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from MotorBill", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvmotor.DataSource = dt;
        }
    }
}
