using System;
using System.Drawing;

namespace TheGraveyard.Cls.RainParticle
{
    public partial class ClsRainDrop
    {
        #region Variables

        Point location;
        int len;

        #endregion

        #region Properties

        public Point Location { get => location; set => location = value; }
        public int Len { get => len; set =>len = value; }

        #endregion

        #region Methods

        public ClsRainDrop(){}

        public void Randomize(Rectangle bounds,int maxLen)
        {
            Random rnd = new Random();
            this.Location = new Point(
                rnd.Next(bounds.X, 500),
                rnd.Next(bounds.Y , 500));
            this.Len = rnd.Next(maxLen);
        }


        #endregion

    }
}
