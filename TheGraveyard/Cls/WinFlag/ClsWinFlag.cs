using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SADGames.Classes.Collidable_Object;
using SADGames.Classes.Player;

namespace SADGames.Classes.WinFlag
{
    public partial class ClsWinFlag:ClsCollidableObject
    {
        #region Variables

        bool win = false;

        #endregion

        #region Properties

        public bool Win { get => win; set => win = value; }

        #endregion

        #region Methods

        public ClsWinFlag() { }

        public override void BottomCollisionAction(ref ClsPlayer player)
        {
            this.win = true;
        }

        public override void TopCollisionAction(ref ClsPlayer player)
        {
            this.win = true;
        }

        public override void LeftCollisionAction(ref ClsPlayer player)
        {
            this.win = true;
        }

        public override void RightCollisionAction(ref ClsPlayer player)
        {
            this.win = true;
        }

        #endregion

    }
}
