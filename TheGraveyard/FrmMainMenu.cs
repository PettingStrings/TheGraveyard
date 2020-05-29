using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes.Animation;
using TheGraveyard.Levels;

namespace TheGraveyard
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            lblVersion.Text = this.ProductVersion;
            Program.moon.Target = this.picMoon;
            Program.moon.TimAnim.Start();
            if (LoadAccData())
                lblAccount.Text = Program.account.Username;
        }
        /// <summary>
        /// Carica i dati salvati da file
        /// </summary>
        /// <returns>Ritorna true se il login (o registrazione) va a buon fine</returns>
        private bool LoadAccData()
        {
            if (!Program.LoadOfflineAccountData())
            {
                MessageBox.Show("Crea un account per poter salvare online i tuoi dati");
                return false;
            }
            return true;
        }

        private void LblPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            PauseProcess();
            FrmLevels frmLevels = new FrmLevels();
            frmLevels.ShowDialog(this);
            UnPauseProcess();
            this.Show();
        }

        /// <summary>
        /// Attiviamo suoni/animazioni
        /// </summary>
        private void UnPauseProcess()
        {
            Program.moon.TimAnim.Start();
        }
        /// <summary>
        /// Disattiviamo suoni/animazioni
        /// </summary>
        private void PauseProcess()
        {
            Program.moon.TimAnim.Stop();
        }

        private void LblAccount_Click(object sender, EventArgs e)
        {
            FrmAccesso frm = new FrmAccesso();
            frm.ShowDialog(this);
        }
    }
}
