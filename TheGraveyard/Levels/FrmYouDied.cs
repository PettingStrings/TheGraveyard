using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGraveyard.Levels
{
    public partial class FrmYouDied : Form
    {
        public FrmYouDied(Point location,Size size)
        {
            InitializeComponent();
            this.Location = location;
            this.Size = size;
        }

        private void timAlpha_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (this.Opacity == 1)
                timPause.Start();
        }

        private void FrmYouDied_Load(object sender, EventArgs e)
        {
            
            this.timAlpha.Start();
            this.lblMessage.Location = new Point(
                (this.Width - lblMessage.Width) / 2,
                (this.Height - lblMessage.Height) / 2
                );
        }

        private void timPause_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
