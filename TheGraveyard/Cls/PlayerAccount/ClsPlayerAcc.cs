using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGraveyard.Cls.PlayerAccount
{
    public partial class ClsPlayerAcc
    {
        #region Variables

        string userName;
        string password;

        uint kills;
        uint deaths;

        #endregion

        #region Properties

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password;}
        public uint Kills { get => kills; set => kills = value; }
        public uint Deaths { get => deaths; set => deaths = value; }


        #endregion

        #region Methods

        public ClsPlayerAcc() { }

        public bool LoadData() {

            return false;
        }

        #endregion

    }
}
