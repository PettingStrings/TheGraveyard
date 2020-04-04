using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TheGraveyard.Cls.RainParticle
{
    public partial class ClsRain
    {
        #region Variables

        List<ClsRainDrop> drops = new List<ClsRainDrop>();
        Point velocity;
        int direction,maxLen;
        Rectangle bounds;
        Pen pen;

        #endregion

        #region Properties

        public List<ClsRainDrop> Drops { get => drops; set => drops = value; }
        public int Direction { get => direction; set => direction = value; }
        public Point Velocity { get => velocity; set => velocity = value; }
        public int MaxLen { get => maxLen; set => maxLen = value; }
        public Pen Pen { get => pen; set => pen = value; }


        #endregion

        #region Methods

        public ClsRain() {}

        public void Update()
        {
            foreach (var drop in drops)
            {
                drop.Location = new Point(
                    drop.Location.X + (int)ClsRain.map(this.velocity.X, 0, drop.Len, 1, 5),
                    drop.Location.Y + (int)ClsRain.map(this.velocity.Y, 0, drop.Len, 1, 5));

                if (!this.bounds.Contains(drop.Location))
                    drop.Randomize(this.bounds, maxLen);
            }
        }
        int i = 0;
        public void Draw(object sender, PaintEventArgs e)
        {
            // this.Update();
            foreach (var drop in drops)
            {
                e.Graphics.DrawLine(this.pen, drop.Location,
                    new Point(drop.Location.X + i, drop.Location.Y + 20));
                i += 10;
            }

            e.Graphics.DrawLine(this.pen, new Point(100, 100), new Point(200, 200));
        }

        public static float map(float value, float fromLow, float fromHigh, float toLow, float toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }
        #endregion

    }
}
