using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using TheGraveyard;
using TheGraveyard.Cls.MyQueries;

// cmd.ExecuteScalar();   query che ritornano un solo valore COUNT, SUM, AVG etc...
// cmd.ExecuteNonQuery(); query di tipo CREATE, DROP, INSERT, UPDATE, DELETE etc...
// cmd.ExecuteReader();   query di SELECT


namespace TheGraveyard
{

    static class Program
    { 
        public static ClsMoon moon;
        public static OleDbConnection conn = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=db.accdb;
            Persist Security Info=False;");
        public static OleDbCommand cmd = new OleDbCommand("", conn);

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            conn.Open();
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

        public static bool LoadFromDatabase(string email,string password)
        {
            try
            {
                cmd.CommandText = MyQueries.GetAccount(email,password);
                OleDbDataReader dbReader = cmd.ExecuteReader();
                dbReader.Read();
                ClsPlayerAcc.Account.Email = dbReader["email"].ToString().Trim().ToCharArray();
                ClsPlayerAcc.Account.Username = dbReader["nome"].ToString().Trim().ToCharArray();
                ClsPlayerAcc.Account.Password = dbReader["password"].ToString().Trim().ToCharArray();
                ClsPlayerAcc.Account.Verified = (bool)dbReader["verificato"];
                ClsPlayerAcc.Account.Deaths = (int)dbReader["mortiTotali"];
                ClsPlayerAcc.Account.Kills = (int)dbReader["uccisioniTotali"];
                ClsPlayerAcc.Account.LastSave = (DateTime)dbReader["ultimoBackup"];
                dbReader.Close();
                cmd.CommandText = MyQueries.GetUnlockedLevels(email);
                ClsPlayerAcc.Account.LevelsUnlocked = (int)cmd.ExecuteScalar();
            }
            catch
            {
                return false;
            }
            
            return true;
        }

        internal static void Commit()
        {
            cmd.CommandText = MyQueries.UpdatePlayer(
                new string(ClsPlayerAcc.Account.Email),
                new string(ClsPlayerAcc.Account.Username),
                new string(ClsPlayerAcc.Account.Password),
                ClsPlayerAcc.Account.Verified,
                ClsPlayerAcc.Account.Kills,
                ClsPlayerAcc.Account.Deaths);
            cmd.ExecuteNonQuery();
        }
    }
}
