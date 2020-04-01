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
    public partial class FrmLevels : Form
    {
        public FrmLevels()
        {
            InitializeComponent();
        }

        private void FrmLevels_Load(object sender, EventArgs e)
        {
            
        }

        private void picLvl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A-> Movimento a Sinistra\nD-> Movimento a Destra\nF-> Attacco\n Space-> Salto","Comandi");
            TheGraveyard.Levels.FrmLevel1 frmLvl1 = new Levels.FrmLevel1();
            this.Hide();
            frmLvl1.ShowDialog(this);
            this.Show();
        }

        private void picLvl2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A-> Movimento a Sinistra\nD-> Movimento a Destra\n F-> Attacco\n Space-> Salto");
            TheGraveyard.Levels.FrmLevel2 frmLvl2 = new Levels.FrmLevel2();
            this.Hide();
            frmLvl2.ShowDialog(this);
            this.Show();
        }
    }
}
