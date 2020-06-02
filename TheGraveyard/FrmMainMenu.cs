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
        }

        private void LblPlay_Click(object sender, EventArgs e)
        {
            if (!ClsPlayerAcc.Account.Connected)
            {
                MessageBox.Show("Fai l'accesso per poter continuare");
                return;
            }
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
            if(string.IsNullOrWhiteSpace(new string(ClsPlayerAcc.Account.Email)))
            {
                MessageBox.Show("Fai l'accesso per poter continuare");
            }
            else
            {
                lblAccount.Text = $"Welcome {new string(ClsPlayerAcc.Account.Username)}";
                lblAccount.Location = new Point(this.Width - lblAccount.Width,lblAccount.Location.Y);
            }
        }
    }
}
