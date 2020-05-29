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
    /// <summary>
    /// Form di morte
    /// </summary>
    public partial class FrmYouDied : Form
    {
        public FrmYouDied(Point location,Size size)
        {
            InitializeComponent();
            this.Location = location;
            this.Size = size;
        }
        /// <summary>
        /// Da un effetto di fade in
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Chiude la form dopo un po di secondi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timPause_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
