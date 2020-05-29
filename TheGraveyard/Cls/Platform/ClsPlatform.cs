using SADGames.Classes.Player;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SADGames.Classes.Platform
{
    /// <summary>
    /// Piattaforma, terreno
    /// </summary>
    public class ClsPlatform : Classes.Collidable_Object.ClsCollidableObject
    {
        #region Variables



        #endregion

        #region Properties



        #endregion

        #region Methods

        public ClsPlatform() : base()
        { }
        public override void BottomCollisionAction(ref ClsPlayer player)
        {
            player.Body.Location = new System.Drawing.Point(
                player.Body.Location.X,
                base.Body.Location.Y + base.Body.Height
                );
        }

        public override void LeftCollisionAction(ref ClsPlayer player)
        {
            player.Body.Location = new System.Drawing.Point(
                this.Body.Location.X - player.Body.Width,
                player.Body.Location.Y
                );
        }

        public override void TopCollisionAction(ref ClsPlayer player)
        {
            if (!player.OnGround)
            {
                player.OnGround = true;
                player.Body.Location = new Point(
                    player.Body.Location.X,
                    this.Body.Location.Y - player.Body.Height
                    );
                player.LastOnTop = this.Body;
            }
        }

        public override void RightCollisionAction(ref ClsPlayer player)
        {
            player.Body.Location = new System.Drawing.Point(
                this.Body.Location.X + this.Body.Width,
                player.Body.Location.Y
                );
        }

        #endregion

    }
}
