using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace TheGraveyard
{
    public partial class ClsPlayerAcc
    {
        #region Variables

        string username, email, password;

        uint kills,deaths;

        #endregion

        #region Properties

        public string Username { get => username; set => username = value; }
        public string Password { get => password;}
        public uint Kills { get => kills; set => kills = value; }
        public uint Deaths { get => deaths; set => deaths = value; }
        public string Email { get => email; set => email = value; }


        #endregion

        #region Methods

        public ClsPlayerAcc() { }

        public bool LoadData() {

            return false;
        }

        public void SendMail(string from,string title,string body)
        {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("danutzzu2002.ro@gmail.com", "Danibell2002"),
                    EnableSsl = true
                };
                client.Send(from, this.email, title, body);
            
        }

        #endregion

    }
}
