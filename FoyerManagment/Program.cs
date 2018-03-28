using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Management;

namespace FoyerManagment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorID"].ToString();
            }

            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string motherBoard = "";
            foreach (ManagementObject mo1 in moc)
            {
                motherBoard = (string)mo1["SerialNumber"];
            }
            if (id.Equals("BFEBFBFF00010676") || motherBoard.Equals("CNF8371P6H"))
            {
                Application.Run(new FRM_Main());
            }
            else 
            {
                MessageBox.Show("This Program is not Activation For More Information : kinanshasho@gmail.com");
            }
        }
    }
}
