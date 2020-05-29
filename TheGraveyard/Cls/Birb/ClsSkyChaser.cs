using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes.Player;

namespace SADGames.Classes.Birb
{
    /// <summary>
    /// Nemico volante che in un certo range  insegue il giocatore
    /// </summary>
    public partial class ClsSkyChaser:ClsPlayer
    {
        #region Variables

        Timer timAI;
        PictureBox target;
        int range;
        bool inRange = false;
        bool dead = false;

        #endregion

        #region Properties

        public Timer TimAI { get => timAI; set => timAI = value; }
        public PictureBox Target { get => target; set => target = value; }
        public int Range { get => range; set => range = value; }

        #endregion

        #region Methods

        public ClsSkyChaser() {

            timAI = new Timer();
            timAI.Interval = 100;
            timAI.Tick += TimAI_Tick;
            this.Idle();
        }

        private void TimAI_Tick(object sender, EventArgs e)
        {
                AI();
        }
        /// <summary>
        /// Intelligenza del nemico, essa controlla se il giocatore è
        /// entrato nel suo raggio d'azione, per poi inseguiro
        /// 
        /// </summary>
        private void AI()
        {
            //https://yal.cc/rectangle-circle-intersection-test/
            int distX = this.Body.Location.X - 
                Math.Max(target.Location.X, Math.Min(this.Body.Location.X, target.Location.X + target.Width));
            int distY = this.Body.Location.Y - 
                Math.Max(target.Location.Y, Math.Min(this.Body.Location.Y, target.Location.Y + target.Height));
            if (!inRange)
            {
                inRange = (distX * distX + distY * distY) < (range * range);
                if (inRange)
                    TimIdle.Stop();
            }
            else
            {
                this.Body.Location = new System.Drawing.Point(
                    (int)(Math.Ceiling(this.Body.Location.X - distX*0.10)),
                    (int)(Math.Ceiling(this.Body.Location.Y - distY * 0.10))
                    );
            }
        }

        public override void BottomCollisionAction(ref ClsPlayer player) {
            player.Die();
        }

        public override void TopCollisionAction(ref ClsPlayer player) {
            if (player.CanisAttack.IsDoing)
                this.Die();
            else if (!this.dead)
                player.Die();
        }

        public override void LeftCollisionAction(ref ClsPlayer player) {
            if (player.CanisAttack.IsDoing)
                this.Die();
            else if(!this.dead)
                player.Die();
        }

        public override void RightCollisionAction(ref ClsPlayer player) {
            if (player.CanisAttack.IsDoing)
                this.Die();
            else if (!this.dead)
                player.Die();
        }

        private new void Die()
        {
            this.dead = false;
            this.TimDie.Tick += this.TimDie_Tick;
            this.WalkTim.Stop();
            this.AtkTim.Stop();
            this.TimAI.Stop();
            if (!this.TimDie.Enabled)
                this.TimDie.Start();
        }
        new internal void TimDie_Tick(object sender, EventArgs e)
        {
            DieAnim();
        }
        /// <summary>
        /// Esegue l'animazione della morte
        /// </summary>
        new private void DieAnim()
        {
            int frame = FrameDie;

            if (FDir == FACE_DIR.RIGHT)
                this.Body.Image = AnimDie.GetNextFrame(ref frame);
            else
                this.Body.Image = AnimDie.GetNextFlippedXFrame(ref frame);

            FrameDie = frame;

            if (FrameDie == AnimDie.FramesLenght - 1)
            {
                this.TimDie.Stop();
                this.Body.Hide();
                this.Body.Location = new System.Drawing.Point(-500, -500);
            }
        }
        #endregion

    }
}
