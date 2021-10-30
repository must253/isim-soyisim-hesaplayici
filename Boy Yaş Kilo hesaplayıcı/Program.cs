using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Boy_Yaş_Kilo_hesaplayıcı
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
