using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SADGames.Classes.Collidable_Object;
using SADGames.Classes.Animation;
using System.Windows.Forms;

//Memento Mori,
//Memento programori,
//Questam Partiribum

namespace SADGames.Classes.Player
{
    /// <summary>
    /// Parte della classe contenente i metodi che non hanno
    /// dei metodi che non richiedono molte varibili o altri metodi
    /// </summary>
    public partial class ClsPlayer:ClsCollidableObject
    {
        ClsAnimation animDie = new ClsAnimation();
        Timer timDie = new Timer();
        int frameDie = 0;

        public ClsAnimation AnimDie { get => animDie; set => animDie = value; }
        public Timer TimDie { get => timDie; set => timDie = value; }
        public int FrameDie { get => frameDie; set => frameDie = value; }
        /// <summary>
        /// Anima la morte
        /// </summary>
        public void Die()
        {
            TimDie.Start();
        }
        /// <summary>
        /// Timer che continua l'animazinone
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void TimDie_Tick(object sender, EventArgs e)
        {
            DieAnim();
        }
        /// <summary>
        /// Estrae i frame oer l'animazione
        /// </summary>
        internal void DieAnim()
        {
            if (FDir == FACE_DIR.RIGHT)
                this.Body.Image = animDie.GetNextFrame(ref frameDie);
            else
                this.Body.Image = animDie.GetNextFlippedXFrame(ref frameDie);

            if (frameDie == animDie.FramesLenght - 1 || animDie.FramesLenght == 0)
            {
                timDie.Stop();
                Body.Location = new Point(0, 0);
                onGround = false;
            }
        }

        public override void BottomCollisionAction(ref ClsPlayer player){}

        public override void LeftCollisionAction(ref ClsPlayer player){}

        public override void RightCollisionAction(ref ClsPlayer player){}
        public override void TopCollisionAction(ref ClsPlayer player){}
    }
}
