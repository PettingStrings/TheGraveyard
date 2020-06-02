using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace TheGraveyard
{
    /// <summary>
    /// SINGLETON
    /// Classe dove verranno salvati i dati di un giocatore
    /// </summary>
    public sealed class ClsPlayerAcc
    {

        private static readonly ClsPlayerAcc account = new ClsPlayerAcc();

        public static ClsPlayerAcc Account => account;

        #region Variables

        public const int SIZE_EMAIL = 100;
        public const int SIZE_USERNAME = 20, SIZE_PASSWORD = 20;

        char[] username = new char[SIZE_USERNAME], password = new char[SIZE_PASSWORD];
        char[] email = new char[SIZE_EMAIL];

        int kills = 0,deaths = 0,levelsUnlocked = 0;

        DateTime lastSave = new DateTime();

        bool verified = false;
        #endregion

        #region Properties

        public char[] Username { get => username; set => username = value; }
        public char[] Password { get => password; set => password = value; }
        public int Kills { get => kills; set => kills = value; }
        public int Deaths { get => deaths; set => deaths = value; }
        public char[] Email { get => email; set => email = value; }
        public DateTime LastSave { get => lastSave; set => lastSave = value; }
        public int LevelsUnlocked { get => levelsUnlocked; set => levelsUnlocked = value; }
        public bool Verified { get => verified; set => verified = value; }
        public bool Connected { get => !string.IsNullOrWhiteSpace(new string(Email).Trim('\0')); }

        #endregion

        #region Methods
        private ClsPlayerAcc() { }

        /// <summary>
        /// Carica i dati da file (da finire)
        /// </summary>
        /// <returns></returns>
        public bool LoadLocalData() {

            return false;
        }
        /// <summary>
        /// Invia un email
        /// </summary>
        /// <param name="from"></param>
        /// <param name="title"></param>
        /// <param name="body"></param>
        public void SendMail(string from,string title,string body)
        {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("danutzzu2002.ro@gmail.com", "qui ci va la password che ovviamente ho cancellato"),
                    EnableSsl = true
                };
                client.Send(from, email.ToString(), title, body);
            
        }
        /// <summary>
        /// Data una stringa, la scompone e la memorizza nei dati adeguati
        /// </summary>
        /// <param name="data"></param>
        internal void ParseInfoString(string data)
        {
            try
            {
                string[] infos = data.Split(';');
                this.Username = infos[0].ToCharArray();
                this.Email = infos[1].ToCharArray();
                this.Password = infos[2].ToCharArray();
                this.Kills = Convert.ToInt32(infos[3]);
                this.Deaths = Convert.ToInt32(infos[4]);
                this.LastSave = DateTime.Parse(infos[5]);
                this.LevelsUnlocked = Convert.ToInt32(infos[6]);
            }
            catch { }
        }
        /// <summary>
        /// Ritorna una stringa con le informazioni del giocatore dentro
        /// </summary>
        /// <returns></returns>
        public string GetInfoString()
        {
            return $"{this.Username};{this.Email};{this.Password};{this.Kills};" +
                $"{this.Deaths};{this.LastSave};{this.LevelsUnlocked}";
        }

        public void Reset()
        {
            username = new char[SIZE_USERNAME];
            password = new char[SIZE_PASSWORD];
            email = new char[SIZE_EMAIL];
            kills = deaths = levelsUnlocked = 0;
            lastSave = new DateTime();
            verified = false;
        }
        #endregion

    }
}
