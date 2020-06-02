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
    public partial class FrmScore : Form
    {
        public int kills, deaths, time, finalScore, bonus = 1000;
        private readonly int pKills = 50, pDeaths = 60, pTime = 15; //Peso uccisioni ...
        private int count = 0;

        private void LblContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblScore_Click(object sender, EventArgs e)
        {

        }

        private void TimScore_Tick(object sender, EventArgs e)
        {
            int jump = (int)finalScore / 100;
            lblScore.Left = (Width - lblScore.Width) / 2;

            lblScore.Text = count.ToString();

            if (count == finalScore)
            {
                ShowData();
                timScore.Stop();
            }

            if (finalScore - count < jump)
                jump = finalScore - count;

            count += jump;
        }

        private void ShowData()
        {
            lblKills.Show();
            lblDeaths.Show();
            lblTime.Show();
            lblContinue.Show();
        }

        public int FinalScore { get => finalScore; }
        public FrmScore(int kills,int deaths,int time)
        {
            InitializeComponent();
            this.kills = kills;
            this.deaths = deaths;
            this.time = time;
        }

        private void FrmScore_Load(object sender, EventArgs e)
        {
            finalScore = CalcScore();
            timScore.Interval = 5;

            lblKills.Text = $"Kills: {kills}";
            lblDeaths.Text = $"Deaths: {deaths}";
            lblTime.Text = $"Time: {time} s";

            timScore.Start();
        }

        private int CalcScore()
        {
            return kills * pKills + time * pTime + bonus - deaths * pDeaths;
        }
    }
}
