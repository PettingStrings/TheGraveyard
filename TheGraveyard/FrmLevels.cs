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
        private void PicLvl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A-> Movimento a Sinistra\nD-> Movimento a Destra\nF-> Attacco\n Space-> Salto","Comandi");
            this.Hide();
            Levels.FrmLevel1 frmLvl1 = new Levels.FrmLevel1();
            int deaths = 0;
            while (frmLvl1.ShowDialog(this) == DialogResult.Retry)
            {
                if (!frmLvl1.Win)
                    deaths++;

                frmLvl1 = new Levels.FrmLevel1();
            }
            if (frmLvl1.Win)
            {
                Levels.FrmScore score = new Levels.FrmScore(frmLvl1.Kills, deaths, frmLvl1.Time);
                score.ShowDialog();
                if (ClsPlayerAcc.Account.LevelsUnlocked == 0)
                    ClsPlayerAcc.Account.LevelsUnlocked++;
                Program.AddOrUpdateScore(1, frmLvl1.Kills, frmLvl1.Time, new string(ClsPlayerAcc.Account.Email));
            }
            Program.Commit();
            this.Show();
        }

        /// <summary>
        /// Avvia livello 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicLvl2_Click(object sender, EventArgs e)
        {
            if (ClsPlayerAcc.Account.LevelsUnlocked == 0)
            {
                MessageBox.Show("level locked");
                return;
            }
                
            MessageBox.Show("A-> Movimento a Sinistra\nD-> Movimento a Destra\nF-> Attacco\n Space-> Salto", "Comandi");
            this.Hide();
            TheGraveyard.Levels.FrmLevel2 frmLvl2 = new Levels.FrmLevel2();
            int deaths = 0;
            while (frmLvl2.ShowDialog(this) == DialogResult.Retry)
            {
                if (!frmLvl2.Win)
                    deaths++;

                frmLvl2 = new Levels.FrmLevel2();
            }
            if (frmLvl2.Win)
            {
                Levels.FrmScore score = new Levels.FrmScore(frmLvl2.Kills, deaths, frmLvl2.Time);
                score.ShowDialog();
                if (ClsPlayerAcc.Account.LevelsUnlocked == 1)
                    ClsPlayerAcc.Account.LevelsUnlocked++;
                Program.AddOrUpdateScore(2, frmLvl2.Kills, frmLvl2.Time, new string(ClsPlayerAcc.Account.Email));
            }
            Program.Commit();
            this.Show();
        }
    }
}
