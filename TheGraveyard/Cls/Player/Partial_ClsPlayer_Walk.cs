using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes.Animation;
using SADGames.Classes.CanIs;
using SADGames.Classes.Collidable_Object;

//"Camina fino a matina"

namespace SADGames.Classes.Player
{
    /// <summary>
    /// Parte di classe che gestisce la camminata del giocatore
    /// </summary>
    public partial class ClsPlayer:ClsCollidableObject
    {
        ClsAnimation walkAnimation;
        StrCanIs walkCanIs;

        int ms = 5;//Movement Speed
        int walkFrame = 0;
        Timer walkTim;

        public int MS { get => ms; }
        public Timer WalkTim { get => walkTim; set => walkTim = value; }

        /// <summary>
        /// Cambia le immagini al della picturebox
        /// per simulare l'animazione
        /// </summary>
        private void TimRun_Tick(object sender, EventArgs e)
        {
            if (FDir == FACE_DIR.RIGHT)
                Body.Image = AnimWalk.GetNextFrame(ref walkFrame);
            else if (FDir == FACE_DIR.LEFT)
                Body.Image = AnimWalk.GetNextFlippedXFrame(ref walkFrame);
        }
        /// <summary>
        /// Funzione che fa camminare il giocatore
        /// anche quando sta saltando
        /// </summary>
        internal void Walk()
        {
            int finalSpeed = ms;
            if (!this.onGround) { finalSpeed = 4; }//Se sta saltando, si muoverà di menoù
            SetupForWalk();
            
            if (FDir == FACE_DIR.RIGHT)
            {
                WalkRight(finalSpeed);
            }
            else if (FDir == FACE_DIR.LEFT)
            {
                WalkLeft(finalSpeed);
            }
        }
        #region Walk
        /// <summary>
        /// Cammina vers sinistra
        /// </summary>
        /// <param name="finalSpeed">velocità con cui farlo</param>
        private void WalkLeft(int finalSpeed)
        {
            Body.Location = new System.Drawing.Point(
                    Body.Location.X - finalSpeed,
                    Body.Location.Y
                    );
        }
        /// <summary>
        /// Cammina vers destra
        /// </summary>
        /// <param name="finalSpeed">velocità con cui farlo</param>
        private void WalkRight(int finalSpeed)
        {
            Body.Location = new System.Drawing.Point(
                    Body.Location.X + finalSpeed,
                    Body.Location.Y
                    );
        }
        /// <summary>
        /// Prepara il giocatore a camminare
        /// </summary>
        private void SetupForWalk()
        {
            if ((walkCanIs.CanDo && !walkCanIs.IsDoing && !WalkTim.Enabled))
            {
                idleCanIs.CanDo = true;
                idleCanIs.IsDoing = false;
                this.TimIdle.Stop();
                this.WalkTim.Start();
            }
        }

        #endregion

    }
}
