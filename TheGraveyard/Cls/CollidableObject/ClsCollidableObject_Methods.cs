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
    /// <summary>
    /// Ritorna il lato con cui si è entrati in collisione
    /// </summary>
    public enum COLLIDED_EDGE { RIGHT,LEFT,TOP,BOT,NONE};
    /// <summary>
    /// Oggetto che è soggetto alla fisica
    /// </summary>
    public abstract partial class ClsCollidableObject
    {
        #region Methods
        /// <summary>
        /// Ritorna la coordinata X del cetro di target
        /// </summary>
        /// <param name="target">Picturebox di cui misurare il centro</param>
        /// <returns></returns>
        public static double GetCx(PictureBox target) { return target.Location.X + target.Width * 0.5; }
        /// <summary>
        /// Ritorna la coordinata Y del cetro di target
        /// </summary>
        /// <param name="target">Picturebox di cui misurare il centro</param>
        /// <returns></returns>
        public static double GetCy(PictureBox target) { return target.Location.Y + target.Height * 0.5; }
        /// <summary>
        /// Funzione che controllase la picturebox è in collisione con 'player'
        /// </summary>
        /// <param name="player">picturebox da controllare</param>
        /// <returns></returns>
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
        /// <summary>
        /// Azione da eseguire nel caso di una collisione dal basso 
        /// dalla prospettiva del nemico
        /// </summary>
        /// <param name="player">giocatore entrato in collsione</param>
        public abstract void BottomCollisionAction(ref ClsPlayer player);
        /// <summary>
        /// Azione da eseguire nel caso di una collisione dall'alto 
        /// dalla prospettiva del nemico
        /// </summary>
        /// <param name="player">giocatore entrato in collsione</param>
        public abstract void TopCollisionAction(ref ClsPlayer player);
        /// <summary>
        /// Azione da eseguire nel caso di una collisione da sinistra 
        /// dalla prospettiva del nemico
        /// </summary>
        /// <param name="player">giocatore entrato in collsione</param>
        public abstract void LeftCollisionAction(ref ClsPlayer player);
        /// <summary>
        /// Azione da eseguire nel caso di una collisione da destra 
        /// dalla prospettiva del nemico
        /// </summary>
        /// <param name="player">giocatore entrato in collsione</param>
        public abstract void RightCollisionAction(ref ClsPlayer player);

        #endregion
    }

}
