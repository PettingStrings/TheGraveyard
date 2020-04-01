using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGraveyard
{

    static class Program
    {
        public static ClsMoon moon;
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoadMoon();
            Application.Run(new FrmMainMenu());
        }

        private static void LoadMoon()
        {
            moon = new ClsMoon();

            for (int i = 1; i < 7; i++)
            {
                moon.AnimMoon.AddFrame($@"../../Assets/moon/Moon_0{i}.png");
            }

            moon.TimAnim.Interval = (int)(1000 / moon.AnimMoon.FramesLenght);
        }
    }
}
