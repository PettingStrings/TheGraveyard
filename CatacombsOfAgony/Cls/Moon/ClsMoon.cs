using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes.Animation;

namespace CatacombsOfAgony
{
    public partial class ClsMoon
    {
        #region Variables

        int frameMoon = 0;
        ClsAnimation animMoon = new ClsAnimation();
        Timer timAnim = new Timer();
        PictureBox target = new PictureBox();

        #endregion

        #region Properties

        public ClsAnimation AnimMoon { get => animMoon; set => animMoon = value; }
        public Timer TimAnim { get => timAnim; set => timAnim = value; }
        public PictureBox Target { get => target; set => target = value; }

        #endregion

        #region Methods

        public ClsMoon() {
            TimAnim.Tick += TimAnim_Tick;
        }

        private void TimAnim_Tick(object sender, EventArgs e)
        {
            this.target.BackgroundImage = this.AnimMoon.GetNextFrame(ref this.frameMoon);
        }

        #endregion

    }
}
