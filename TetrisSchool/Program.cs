﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisSchool
{
    static class Program
    {
        /// Der Haupteinstiegspunkt für die Anwendung.
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Tetris());
        }


    }
}
