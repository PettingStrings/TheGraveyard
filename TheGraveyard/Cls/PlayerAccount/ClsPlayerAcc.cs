using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace TheGraveyard
{
    /// <summary>
    /// Classe dove verranno salvati i dati di un giocatore
    /// </summary>
    public partial class ClsPlayerAcc
    {
        #region Variables

        string username = "", email = "", password = "";

        uint kills = 0,deaths = 0,levelsUnlocked = 0;

        DateTime lastSave = new DateTime();

        #endregion

        #region Properties

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public uint Kills { get => kills; set => kills = value; }
        public uint Deaths { get => deaths; set => deaths = value; }
        public string Email { get => email; set => email = value; }
        public DateTime LastSave { get => lastSave; set => lastSave = value; }
        public uint LevelsUnlocked { get => levelsUnlocked; set => levelsUnlocked = value; }


        #endregion

        #region Methods

        public ClsPlayerAcc() { }
        /// <summary>
        /// Carica i dati da file (da finire)
        /// </summary>
        /// <returns></returns>
        public bool LoadData() {

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
                    Credentials = new NetworkCredential("danutzzu2002.ro@gmail.com", "Danibell2002"),
                    EnableSsl = true
                };
                client.Send(from, this.email, title, body);
            
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
                this.Username = infos[0];
                this.Email = infos[1];
                this.Password = infos[2];
                this.Kills = Convert.ToUInt32(infos[3]);
                this.Deaths = Convert.ToUInt32(infos[4]);
                this.LastSave = DateTime.Parse(infos[5]);
                this.LevelsUnlocked = Convert.ToUInt32(infos[6]);
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
                $"{this.Deaths};{this.LastSave.ToString()};{this.LevelsUnlocked}";
        }

        #endregion

    }
}
