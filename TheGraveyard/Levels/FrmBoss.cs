using System;
using System.Drawing;
using System.Windows.Forms;
using TheGraveyard.Cls.RainParticle;

namespace TheGraveyard.Levels
{
    public partial class FrmBoss : Form
    {
        ClsRain rain;

        public FrmBoss()
        {
            InitializeComponent();
        }

        private void FrmBoss_Load(object sender, EventArgs e)
        {
            CreateRain();
        }

        private void CreateRain()
        {
            rain = new ClsRain { Velocity = new Point(0,3),Direction = 0,MaxLen = 20, Pen = new Pen(Color.DarkRed,3)};
            for (int i = 0; i < 500; i++)
            {
                ClsRainDrop drop = new ClsRainDrop();
                drop.Randomize(this.Bounds, 5);
                rain.Drops.Add(drop);
            }
        }

        private void FrmBoss_Paint(object sender, PaintEventArgs e)
        {
            rain.Draw(sender, e);
        }
    }
}
