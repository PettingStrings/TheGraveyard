using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes.Player;

namespace SADGames.Classes.PlatformWatcher
{
    public partial class ClsPlatformWatcher:ClsPlayer
    {
        #region Variables

        Timer timAI;
        bool dead = false;
        int range = 25;
        bool inRange;
        PictureBox target;

        #endregion

        #region Properties
        public Timer TimAI { get => timAI; set => timAI = value; }
        public PictureBox Target { get => target; set => target = value; }
        #endregion

        #region Methods

        public ClsPlatformWatcher():base()
        {
            TimAI = new Timer
            {
                Interval = 50
            };
            timAI.Tick += TimAI_Tick;
        }

        private void TimAI_Tick(object sender, EventArgs e)
        {
            AI();
        }

        private void AI()
        {
            int distX = this.Body.Location.X -
                Math.Max(target.Location.X, Math.Min(this.Body.Location.X, target.Location.X + target.Width));
            int distY = this.Body.Location.Y -
                Math.Max(target.Location.Y, Math.Min(this.Body.Location.Y, target.Location.Y + target.Height));


            bool inRange = (distX * distX + distY * distY) < (range * range);
            if (inRange)
            {
                this.WalkTim.Stop();
                if (distX > 0) this.FDir = FACE_DIR.LEFT;
                else this.FDir = FACE_DIR.RIGHT;
                if (this.AtkFrame == 7)
                    this.Body.Location = new System.Drawing.Point
                        ((int)(this.Body.Location.X - distX*1.3),
                        this.Body.Location.Y);
                this.Attack();
            }
            else
            {
                this.Walk();
                if (this.Body.Location.X + this.Body.Width > this.LastOnTop.Location.X + this.LastOnTop.Width)
                { this.FDir = FACE_DIR.LEFT; }
                else if (this.Body.Location.X < this.LastOnTop.Location.X)
                { this.FDir = FACE_DIR.RIGHT; }
            }
            


        }

        public override void BottomCollisionAction(ref ClsPlayer player)
        {
            player.Die();
        }

        public override void LeftCollisionAction(ref ClsPlayer player)
        {
            if (player.CanisAttack.IsDoing)
                this.Die();
            else
                player.Die();
            
        }

        public override void RightCollisionAction(ref ClsPlayer player)
        {
            if (player.CanisAttack.IsDoing)
                this.Die();
            else
                player.Die();
        }

        public override void TopCollisionAction(ref ClsPlayer player)
        {
            if (player.CanisAttack.IsDoing)
                this.Die();
            else
                player.Die();
        }

        new public void Die()
        {
            this.dead = true;
            this.TimAI.Stop();
            this.Body.Hide();
            this.Body.Location = new System.Drawing.Point(-100, -100);
        }

        #endregion

    }
}
