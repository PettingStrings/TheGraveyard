using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes.Player;

namespace SADGames.Classes.Birb
{
    public partial class ClsSkyChaser:ClsPlayer
    {
        #region Variables

        Timer timAI;
        PictureBox target;
        int range;

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

        private void AI()
        {
            //https://yal.cc/rectangle-circle-intersection-test/
            int distX = this.Body.Location.X - 
                Math.Max(target.Location.X, Math.Min(this.Body.Location.X, target.Location.X + target.Width));
            int distY = this.Body.Location.Y - 
                Math.Max(target.Location.Y, Math.Min(this.Body.Location.Y, target.Location.Y + target.Height));
            if (TimIdle.Enabled)
            {
                bool inRange = (distX * distX + distY * distY) < (range * range);
                if (inRange)
                    TimIdle.Stop();
            }
            else
            {
                this.Body.Location = new System.Drawing.Point(
                    (int)(this.Body.Location.X - distX*0.20),
                    (int)(this.Body.Location.Y - distY * 0.20)
                    );
            }
        }

        private new void Die()
        {
            this.Body.Hide();
            this.Body.Location = new System.Drawing.Point(0, 0);
            this.timAI.Stop();
        }

        #endregion

    }
}
