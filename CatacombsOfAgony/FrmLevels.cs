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

namespace CatacombsOfAgony
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
            CatacombsOfAgony.Levels.frmLevel1 frmLvl1 = new Levels.frmLevel1();
            this.Hide();
            frmLvl1.ShowDialog(this);
            this.Show();
        }
    }
}
