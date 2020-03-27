using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SADGames.Classes.Player;
using System.Windows.Input;
using SADGames.Classes.Platform;

namespace CatacombsOfAgony.Levels
{
    public partial class frmLevel1 : Form
    {
        ClsPlayer player;

        #region Tiles
        ClsPlatform mainGround;
        ClsPlatform[] plats;

        #endregion
        public frmLevel1()
        {
            InitializeComponent();
        }

        private void frmLevel1_Load(object sender, EventArgs e)
        {
            LoadScene();
            LoadPlayer();
            StartGame();
        }

        private void LoadScene()
        {
            mainGround = new ClsPlatform { Body = picMainGround };
        }

        private void LoadPlayer()
        {
            player = new ClsPlayer { 
            Body = this.picPlayer
            };

            float scaling = (float)0.5;
            //Idle
            for (int i = 0; i < 3; i++)
            {
                string PATH = @"..\..\Assets\player\Idle\idle_" + i.ToString() + ".png";
                player.AnimIdle.AddFrame(PATH, scaling);
            }
            //Walk
            for (int i = 0; i < 6; i++)
            {
                string PATH = @"..\..\Assets\player\Walk\walk_" + i.ToString() + ".png";
                player.AnimWalk.AddFrame(PATH, scaling);
            }
            //Jump (unused)
            for (int i = 0; i < 5; i++)
            {
                string PATH = @"..\..\Assets\player\Jump\jump_resize_" + i.ToString() + ".png";
                player.AnimJump.AddFrame(PATH, scaling);
            }
            //Attack
            for (int i = 0; i < 6; i++)
            {
                string PATH = @"..\..\Assets\player\LightAttack\lightAttcak1_resize_" + i.ToString() + ".png";
                player.AnimAttack.AddFrame(PATH, scaling);
            }

        }

        private void StartGame()
        {
            Program.moon.Target = this.picMoon;
            Program.moon.TimAnim.Start();
            UnPauseProcess();
            StartAI();
        }

        private void StartAI()
        {
            
        }

        private void timKBHit_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.D))
            {
                player.FDir = SADGames.Classes.Player.FACE_DIR.RIGHT; player.Walk();
                if (player.Body.Location.X > this.Width / 2)
                    Scroll(player.MS);
            }
            else if (Keyboard.IsKeyDown(Key.A)) { player.FDir = SADGames.Classes.Player.FACE_DIR.LEFT; player.Walk(); }
            else if (Keyboard.IsKeyDown(Key.Space)) { player.Jump(); }
            else if (Keyboard.IsKeyDown(Key.F)) { player.Attack(); }
            else { player.Idle(); }
        }

        private void Scroll(int mS)
        {

        }

        private void timGC_Tick(object sender, EventArgs e)
        {//I bitmap non ci mettono molto ad essere rilevati, quindi forzo una pulizia sennò la RAM skizza alle stelle
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void timPhysEng_Tick(object sender, EventArgs e)
        {
            Gravity();
            CheckAndResolveCollisions();
        }

        private void CheckAndResolveCollisions()
        {
            this.player.OnGround = false;
            if (this.mainGround.IsColliding(ref this.player) == SADGames.Classes.Collidable_Object.COLLIDED_EDGE.TOP) this.player.OnGround = true;
        }

        private void Gravity()
        {
            int G = 5;
            #region Player Gravity
            if (!player.OnGround && !player.CanisJump.IsDoing)
            {
                player.Body.Location = new Point(
                    player.Body.Location.X,
                    player.Body.Location.Y + G);
            }
            #endregion
        }

        private void PauseProcess()
        {
            timPhysEng.Stop();
            timKBHit.Stop();
        }
        private void UnPauseProcess()
        {
            timPhysEng.Start();
            timKBHit.Start();
        }

        private void frmLevel1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.timPhysEng.Start();
            else
                this.timPhysEng.Stop();
        }
    }
}
