using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SADGames.Classes.Collidable_Object;
using SADGames.Classes.Player;

namespace SADGames.Classes.Spikes
{
    /// <summary>
    /// Spine,trappole
    /// </summary>
    public partial class ClsSpikes:ClsCollidableObject
    {

        public override void BottomCollisionAction(ref ClsPlayer player)
        {
            player.Die();
        }

        public override void LeftCollisionAction(ref ClsPlayer player)
        {
            player.Die();
        }

        public override void RightCollisionAction(ref ClsPlayer player)
        {
            player.Die();
        }

        public override void TopCollisionAction(ref ClsPlayer player)
        {
            player.Die();
        }

    }
}
