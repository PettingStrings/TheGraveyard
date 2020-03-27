using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SADGames.Classes.Collidable_Object;

//Memento Mori,
//Memento programori,
//Questam Partiribum

namespace SADGames.Classes.Player
{
    public partial class ClsPlayer:ClsCollidableObject
    {
        public void Die()
        {
            Body.Location = new Point(this.lastTouchedPlat.Location.X, this.lastTouchedPlat.Location.Y - this.Body.Height);
        }

        public override void BottomCollisionAction(ref ClsPlayer player){}

        public override void LeftCollisionAction(ref ClsPlayer player){}

        public override void RightCollisionAction(ref ClsPlayer player){}
        public override void TopCollisionAction(ref ClsPlayer player){}
    }
}
