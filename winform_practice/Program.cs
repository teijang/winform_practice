﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDLLApp1;
using System.Runtime.InteropServices;
using WindowsFormsDLLApp1;

namespace winform_practice
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            DllForm1 frm1 = new DllForm1();
            Application.Run(frm1);
        }
    }
}
