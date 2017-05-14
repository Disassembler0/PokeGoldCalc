using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PokeGoldCalc
{
    static class Program
    {
        private static MainForm mainForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
