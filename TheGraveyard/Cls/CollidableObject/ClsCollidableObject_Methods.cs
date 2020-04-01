using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes.Player;

namespace SADGames.Classes.Collidable_Object
{
    public enum COLLIDED_EDGE { RIGHT,LEFT,TOP,BOT,NONE};
    public abstract partial class ClsCollidableObject
    {
        #region Methods

        public static double GetCx(PictureBox target) { return target.Location.X + target.Width * 0.5; }
        public static double GetCy(PictureBox target) { return target.Location.Y + target.Height * 0.5; }

        public COLLIDED_EDGE IsColliding(ref ClsPlayer player)
        {

            double dx = GetCx(player.Body) - GetCx(this.Body);// x difference between centers
            double dy = GetCy(player.Body) - GetCy(this.Body);// y difference between centers
            double aw = (player.Body.Width + this.Body.Width) * 0.5;// average width
            double ah = (player.Body.Height + this.Body.Height) * 0.5;// average height

            /* If either distance is greater than the average dimension there is no collision. */
            if (Math.Abs(dx) > aw || Math.Abs(dy) > ah)
            {
                return COLLIDED_EDGE.NONE;
            }
            /* To determine which region of this rectangle the rect's center
            point is in, we have to account for the scale of the this rectangle.
            To do that, we divide dx and dy by it's width and height respectively. */
            if (Math.Abs(dx / this.Body.Width) > Math.Abs(dy / this.Body.Height))
            {
                if (dx < 0)
                {
                    LeftCollisionAction(ref player);
                    return COLLIDED_EDGE.LEFT;
                }// left
                else
                {
                    RightCollisionAction(ref player);
                    return COLLIDED_EDGE.RIGHT;
                } // right
            }
            else
            {
                if (dy < 0)
                {
                    TopCollisionAction(ref player);
                    return COLLIDED_EDGE.TOP;
                } // top
                else
                {
                    BottomCollisionAction(ref player);
                    return COLLIDED_EDGE.BOT;
                } // bottom
            }
        }

        public abstract void BottomCollisionAction(ref ClsPlayer player);

        public abstract void TopCollisionAction(ref ClsPlayer player);

        public abstract void LeftCollisionAction(ref ClsPlayer player);

        public abstract void RightCollisionAction(ref ClsPlayer player);

        #endregion
    }

}
