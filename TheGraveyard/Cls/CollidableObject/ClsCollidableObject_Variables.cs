using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADGames.Classes.Collidable_Object
{
    public partial class ClsCollidableObject
    {
        #region Variables

        PictureBox body;

        #endregion

        #region Properties



        #endregion

        #region Methods

        public ClsCollidableObject() { }

        public PictureBox Body { get => body; set => body = value; }


        #endregion

    }
}
