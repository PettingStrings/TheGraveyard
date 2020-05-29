using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PED;

namespace TheGraveyard
{

    static class Program
    {
        public static ClsMoon moon;
        public static ClsPlayerAcc account = new ClsPlayerAcc();
        const int keyLen = 5;
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
        /// <summary>
        /// Carica frame per animare la luna
        /// </summary>
        private static void LoadMoon()
        {
            moon = new ClsMoon();

            for (int i = 1; i < 7; i++)
            {
                moon.AnimMoon.AddFrame($@"../../Assets/moon/Moon_0{i}.png");
            }

            moon.TimAnim.Interval = (int)(1000 / moon.AnimMoon.FramesLenght);
        }
        /// <summary>
        /// Salva i dati su HDD
        /// </summary>
        internal static void SaveOfflineAccountData()
        {
            StreamWriter writer = new StreamWriter("saveData.padu");
            writer.WriteLine(account.GetInfoString());
            writer.Close();
        }
        /// <summary>
        /// Carica i dati da HDD
        /// </summary>
        /// <returns>vero se è andato tutto a buon fine</returns>
        internal static bool LoadOfflineAccountData()
        {
            try
            {
                StreamReader reader = new StreamReader("saveData.padu");
                account.ParseInfoString(reader.ReadLine());
                reader.Close();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
