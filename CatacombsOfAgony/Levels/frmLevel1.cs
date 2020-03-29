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
using SADGames.Classes.PlatformWatcher;
using SADGames.Classes.Animation;
using SADGames.Classes.WinFlag;

namespace CatacombsOfAgony.Levels
{
    public partial class frmLevel1 : Form
    {
        ClsPlayer player;

        #region Tiles

        ClsPlatform mainGround;
        ClsPlatform[] plats;
        ClsPlatformWatcher[] platWatchers;
        ClsWinFlag winFlag;

        #endregion

        #region Skeleton Anims

        ClsAnimation animSkeleWalk;
        ClsAnimation animSkeleAttack;

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
            LoadPlats();
            LoadSkeletonAnim();
            LoadPlatWatchers();
            winFlag = new ClsWinFlag { Body = picWinFlag };
        }

        private void LoadPlatWatchers()
        {
            platWatchers = new ClsPlatformWatcher[] { 
                new ClsPlatformWatcher{ Body = this.picSkelly1,LastOnTop = picPlat1}
            };
            foreach (var enemy in platWatchers)
            {
                enemy.AnimAttack = this.animSkeleAttack;
                enemy.AnimWalk = this.animSkeleWalk;
                enemy.Target = this.picPlayer;
            }
        }

        private void LoadPlats()
        {
            mainGround = new ClsPlatform { Body = picMainGround };
            plats = new ClsPlatform[]{
            new ClsPlatform { Body = picPlat1},
            new ClsPlatform { Body = picLeftWall1},
            new ClsPlatform { Body = picLeftWall2 },
            new ClsPlatform{ Body = picTopGround},
            new ClsPlatform{ Body = picRightWall1},
            new ClsPlatform{ Body = picRightWall2}};
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
        private void LoadSkeletonAnim()
        {
            //Walk
            animSkeleWalk = new ClsAnimation();
            for (int i = 1; i < 14; i++)
            {
                string PATH = @"..\..\Assets\enemies\Skeleton\skeleton_walk\skeleton_walk" + i.ToString()+".png";
                animSkeleWalk.AddFrame(PATH);
            }
            animSkeleAttack = new ClsAnimation();
            //Attack
            for (int i = 0; i < 18; i++)
            {
                string PATH = @"..\..\Assets\enemies\Skeleton\skeleton_attack\skeleton_attack" + i.ToString() + ".png";
                animSkeleAttack.AddFrame(PATH);
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
            foreach (var skele in platWatchers)
                skele.TimAI.Start();
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

        private void Scroll(int dist)
        {
            if (picWinFlag.Location.X > this.Width)
                foreach(var control in this.Controls)
                {
                    if(control is PictureBox)
                    {
                        PictureBox temp = control as PictureBox;
                        if (temp.Name != "picMoon")
                            temp.Left -= dist;
                    }
                }
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

            foreach (var platform in this.plats)
                if (platform.IsColliding(ref this.player) == SADGames.Classes.Collidable_Object.COLLIDED_EDGE.TOP) this.player.OnGround = true;

            foreach (var enemy in platWatchers)
                enemy.IsColliding(ref player);

            winFlag.IsColliding(ref player);
            if (winFlag.Win)
                this.Close();
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
