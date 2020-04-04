using System;
using System.Windows.Forms;
using SADGames.Classes.Animation;
using SADGames.Classes.CanIs;
using SADGames.Classes.Collidable_Object;

//Variabili e funzioni per gestire l'azione attacco

namespace SADGames.Classes.Player
{
    public partial class ClsPlayer:ClsCollidableObject
    {
        ClsAnimation atkAnimation; //Gesstice i frame dell'attacco
        Timer atkTimCD; //Coold Down
        Timer atkTim;//Timer che scorre i frame d'animazione dell'attacco
        StrCanIs atkCanIs;
        int atkFrame = 0;

        public int AtkFrame { get => atkFrame; set => atkFrame = value; }
        public Timer AtkTim { get => atkTim; set => atkTim = value; }

        /// <summary>
        /// Varifica se può attaccare, se può fa partire il timer(l'animazione) e disabilita le altre mosse
        /// </summary>
        public void Attack()
        {
            if (atkCanIs.CanDo && !atkCanIs.IsDoing && !AtkTim.Enabled && !atkTimCD.Enabled)
            {
                SetUpForAttack();
                AtkTim.Start();
            }
        }
        /// <summary>
        /// Disabilita le altre mosse
        /// </summary>
        private void SetUpForAttack()
        {
            timIdle.Stop();
            idleCanIs.CanDo = false;
            idleCanIs.CanDo = false;
            walkCanIs.CanDo = false;
            jumpCanIs.CanDo = false;
            atkCanIs.CanDo = false;
            atkCanIs.IsDoing = true;
        }
        /// <summary>
        /// Anima l'attacco fino a quando non finiscono i frame,
        /// quindi riabilita le altre mosse e fa partire un CD che sarà uguale al tick
        /// del timer del CD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimAttack_Tick(object sender, EventArgs e)
        {
            if (this.FDir == FACE_DIR.RIGHT) Body.Image = AnimAttack.GetNextFrame(ref atkFrame);
            else { Body.Image = atkAnimation.GetNextFlippedXFrame(ref atkFrame);
                if (this.AtkFrame == (int)(AnimAttack.FramesLenght / 2))
                    this.Body.Left -= this.Body.Width / 5;
                        }
            if (this.AtkFrame == atkAnimation.FramesLenght - 1)
            {
                AtkTim.Stop();
                idleCanIs.CanDo = true;
                walkCanIs.CanDo = true;
                jumpCanIs.CanDo = true;
                atkCanIs.CanDo = true;
                idleCanIs.CanDo = true;
                atkCanIs.IsDoing = false;
                atkTimCD.Start();
            }
        }
        /// <summary>
        /// Quando il timer finisce, il giocatore
        /// può attaccare di nuovo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimAttackCD_Tick(object sender, EventArgs e)
        {
            atkTimCD.Stop();
        }
    }
}
