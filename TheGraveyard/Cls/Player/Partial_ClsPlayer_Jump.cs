using SADGames.Classes.Animation;
using SADGames.Classes.CanIs;
using SADGames.Classes.Collidable_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Variabili e funzioni addette per il salto del giocatore

namespace SADGames.Classes.Player
{
    /// <summary>
    /// Parte di classe addetta alla gestione del salto
    /// </summary>
    public partial class ClsPlayer:ClsCollidableObject
    {
        ClsAnimation jumpAnimation;
        StrCanIs jumpCanIs;
        Timer jumpTim; //Questo muove il giocatore
        Timer timAnimJmump;//Questo lo anima

        int jumpFrame = 0;
        const int maxJumpHeight = 200;
        int jHeight = maxJumpHeight;//Altezza salto
        bool onGround = false;//Se sta SOPRA un oggetto è true
        /// <summary>
        /// Muove il giocatore verso l'alto(salto),
        /// dopo aver controllato che può farlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void TimJump_Tick(object sender, EventArgs e)
        {
            int jumpSpeed = 5;
            if (jHeight <= 0)
            {
                jumpCanIs.IsDoing = false;
                jumpCanIs.CanDo = true;
                jHeight = maxJumpHeight;
                jumpTim.Stop();
            }
            jHeight -= jumpSpeed;
            Body.Location = new System.Drawing.Point(Body.Location.X, Body.Location.Y - jumpSpeed);
        }
        /// <summary>
        /// Anima il salto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimAnimJmump_Tick(object sender, EventArgs e)
        {//C'è da lavorare sui frame, attualmente animazione solo buggata
            if (fDir == FACE_DIR.RIGHT)
                Body.Image = jumpAnimation.GetNextFrame(ref jumpFrame);
            else if (fDir == FACE_DIR.LEFT)
                Body.Image = AnimJump.GetNextFlippedXFrame(ref jumpFrame);

            if(jumpFrame == AnimJump.FramesLenght - 1)
            {
                timAnimJmump.Stop();
            }
        }
        public void Jump()
        {
            SetupJump();
        }
        /// <summary>
        /// Blocca le azioni che non si possono fare durante il salto
        /// </summary>
        private void BlockActionsForJump()
        {
            idleCanIs.CanDo = false;
            idleCanIs.IsDoing = false;
            walkCanIs.CanDo = true;
            walkCanIs.IsDoing = false;
        }
        /// <summary>
        /// Prepara il giocatore al salto
        /// </summary>
        private void SetupJump()
        {
            if (CanisJump.CanDo && !CanisJump.IsDoing && onGround)
            {
                onGround = false;
                jumpCanIs.CanDo = false;
                jumpCanIs.IsDoing = true;
                BlockActionsForJump();
                jumpTim.Start();
            }
        }
    }
}
