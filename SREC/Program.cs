﻿using System;
using System.Windows.Forms;

namespace SREC
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length == 0) Application.Run(new SRECForm());
            else Application.Run(new SRECForm(args));
        }
    }
}
