﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
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

            //Form Main
            //Application.Run(new frmMain());
            //Application.Run(new frmNhapDiem());

            //Application.Run(new frmHocSinh());
            //Application.Run(new frmLopHoc());
            //Application.Run(new frmLogin());
            Application.Run(new frmGiaoVien());
            //Form Login
            //Application.Run(new frmLogin());
        }
    }
}
