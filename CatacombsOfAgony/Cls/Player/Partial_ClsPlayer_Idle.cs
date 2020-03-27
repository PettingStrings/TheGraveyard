using SADGames.Classes.Animation;
using SADGames.Classes.CanIs;
using SADGames.Classes.Collidable_Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Variabili e funzioni per gestire il giocatore mentre sta fermo

namespace SADGames.Classes.Player
{
    public partial class ClsPlayer:ClsCollidableObject
    {
        ClsAnimation idleAnimation;//Contenitore animazione da fermo
        StrCanIs idleCanIs;
        int currentIdleFrame = 0;

        Timer timIdle;//Timer che anima la pictureBox

        /// <summary>
        /// Se il giocatore può star fermo,
        /// fa partire il animIdle
        /// </summary>
        public void Idle()
        {
            if (idleCanIs.CanDo && !idleCanIs.IsDoing)
            {
                walkCanIs.CanDo = true;
                walkCanIs.IsDoing = false;
                SetUpIdle();
                this.timIdle.Start();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void SetUpIdle()
        {
            walkTim.Stop();
        }

        private void TimIdle_Tick(object sender, EventArgs e)
        {
            if (FDir == FACE_DIR.RIGHT)
                Body.Image = AnimIdle.GetNextFrame(ref currentIdleFrame);
            else if (FDir == FACE_DIR.LEFT)
                Body.Image = AnimIdle.GetNextFlippedXFrame(ref currentIdleFrame);
        }
    }
}
