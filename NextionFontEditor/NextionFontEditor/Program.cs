﻿using System;
using System.Windows.Forms;
using ZiLib.FileVersion.V5;

namespace NextionFontEditor {

    internal static class Program {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            //var f = ZiFontV5.FromFile(@"Test Files\Arial_32_ASCII_AA_v5.zi");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormFontSuite());
        }
    }
}