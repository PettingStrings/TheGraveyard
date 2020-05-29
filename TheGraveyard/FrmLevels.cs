using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes;

namespace TheGraveyard
{
    /// <summary>
    /// Selezione livelli
    /// </summary>
    public partial class FrmLevels : Form
    {
        public FrmLevels()
        {
            InitializeComponent();
        }

        private void FrmLevels_Load(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// Avvia livello 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picLvl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A-> Movimento a Sinistra\nD-> Movimento a Destra\nF-> Attacco\n Space-> Salto","Comandi");
            this.Hide();
            TheGraveyard.Levels.FrmLevel1 frmLvl1 = new Levels.FrmLevel1();
            while (frmLvl1.ShowDialog(this) == DialogResult.Retry)
            {
                frmLvl1 = new Levels.FrmLevel1();
            }
            this.Show();
        }
        /// <summary>
        /// Avvia livello 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picLvl2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A-> Movimento a Sinistra\nD-> Movimento a Destra\nF-> Attacco\n Space-> Salto", "Comandi");
            this.Hide();
            TheGraveyard.Levels.FrmLevel2 frmLvl2 = new Levels.FrmLevel2();
            while (frmLvl2.ShowDialog(this) == DialogResult.Retry)
            {
                frmLvl2 = new Levels.FrmLevel2();
            }
            this.Show();
        }
    }
}
