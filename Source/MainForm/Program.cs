using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MainForm.DataAccessLayer;
using MainForm.Giao_diện.Bán_Vé___Đặt_Chỗ;

namespace MainForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            DataAccessLayer.DataConnection.getInstance().SetupConnection("TRANMINHLUAN\\SQLEXPRESS", "QUANLYCHUYENBAY");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
