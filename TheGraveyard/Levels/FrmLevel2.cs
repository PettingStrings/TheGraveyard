using System;
using System.Drawing;
using System.Windows.Forms;
using SADGames.Classes.Player;
using System.Windows.Input;
using SADGames.Classes.Platform;
using SADGames.Classes.PlatformWatcher;
using SADGames.Classes.Animation;
using SADGames.Classes.WinFlag;
using SADGames.Classes.Birb;
using SADGames.Classes.Spikes;

namespace TheGraveyard.Levels
{
    public partial class FrmLevel2 : Form
    {
        ClsPlayer player;

        #region Tiles

        ClsSpikes spike;
        ClsPlatform mainGround;
        ClsPlatform[] plats;
        ClsPlatformWatcher[] platWatchers;
        ClsSkyChaser[] skyChasers;
        ClsWinFlag winFlag;

        #endregion

        #region Anims

        ClsAnimation animSkeleWalk;
        ClsAnimation animSkeleAttack;
        ClsAnimation animSkeletonDead;

        ClsAnimation animBirbIdle_Walk;

        #endregion
        public FrmLevel2()
        {
            InitializeComponent();
        }

        private void FrmLevel2_Load(object sender, EventArgs e)
        {
            LoadScene();
            LoadPlayer();
            StartGame();
            timGC.Start();
        }

        private void LoadScene()
        {
            spike = new ClsSpikes { Body = this.picSpikes };
            LoadPlats();
            LoadSkeletonAnim();
            LoadPlatWatchers();
            LoadBirbsAnim();
            LoadBirbs();
            winFlag = new ClsWinFlag { Body = picWinFlag };
        }

        private void LoadBirbs()
        {
            skyChasers = new ClsSkyChaser[] {
                new ClsSkyChaser{ Body = picBirb1,Target = this.picPlayer,Range = 150,AnimWalk = animBirbIdle_Walk,AnimIdle = animBirbIdle_Walk},
                new ClsSkyChaser{ Body = picBirb2,Target = this.picPlayer,Range = 150,AnimWalk = animBirbIdle_Walk,AnimIdle = animBirbIdle_Walk},
                new ClsSkyChaser{ Body = picBirb3,Target = this.picPlayer,Range = 150,AnimWalk = animBirbIdle_Walk,AnimIdle = animBirbIdle_Walk},
                new ClsSkyChaser{ Body = picBirb4,Target = this.picPlayer,Range = 150,AnimWalk = animBirbIdle_Walk,AnimIdle = animBirbIdle_Walk}
            };
        }
        private void LoadBirbsAnim()
        {
            animBirbIdle_Walk = new ClsAnimation();
            for (int i = 0; i < 16; i++)
            {
                string PATH = @"..\..\Assets\enemies\SkyChaser\frame" + i.ToString() + ".png";
                animBirbIdle_Walk.AddFrame(PATH);
            }
        }
        private void LoadPlatWatchers()
        {
            platWatchers = new ClsPlatformWatcher[] {
                new ClsPlatformWatcher{ Body = this.picSkele1,LastOnTop = picMainGround},
                new ClsPlatformWatcher{ Body = this.picSkele2,LastOnTop = picMainGround},
                new ClsPlatformWatcher{ Body = this.picSkele3,LastOnTop = picMainGround},
                new ClsPlatformWatcher{ Body = this.picSkele4,LastOnTop = picMainGround}
            };
            foreach (var enemy in platWatchers)
            {
                enemy.AnimAttack = this.animSkeleAttack;
                enemy.AnimWalk = this.animSkeleWalk;
                enemy.AnimDie = this.animSkeletonDead;
                enemy.Target = this.picPlayer;
            }
        }
        private void LoadPlats()
        {
            mainGround = new ClsPlatform { Body = picMainGround };
            plats = new ClsPlatform[]{
            new ClsPlatform { Body = picSpawn}};
        }

        private void LoadPlayer()
        {
            player = new ClsPlayer
            {
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
                string PATH = @"..\..\Assets\enemies\Skeleton\skeleton_walk\skeleton_walk" + i.ToString() + ".png";
                animSkeleWalk.AddFrame(PATH);
            }
            //Attack
            animSkeleAttack = new ClsAnimation();
            for (int i = 0; i < 18; i++)
            {
                string PATH = @"..\..\Assets\enemies\Skeleton\skeleton_attack\skeleton_attack" + i.ToString() + ".png";
                animSkeleAttack.AddFrame(PATH);
            }
            //Dead
            animSkeletonDead = new ClsAnimation();
            for (int i = 0; i < 15; i++)
            {
                string PATH = @"..\..\Assets\enemies\Skeleton\skeleton_dead\skeleton_dead" + i.ToString() + ".png";
                animSkeletonDead.AddFrame(PATH);
            }
        }

        private void StartGame()
        {
            Program.moon.Target = this.picMoon;
            Program.moon.TimAnim.Start();
            timTrap.Start();
            UnPauseProcess();
            StartAI();
        }
        private void StartAI()
        {
            foreach (var skele in platWatchers)
                skele.TimAI.Start();

            foreach (var birb in skyChasers)
                birb.TimAI.Start();
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
                foreach (var control in this.Controls)
                {
                    if (control is PictureBox)
                    {
                        PictureBox temp = control as PictureBox;
                        if (temp.Name != "picMoon")
                            temp.Left -= dist;
                    }
                }
        }
        private void timGC_Tick(object sender, EventArgs e)
        {//I bitmap non ci mettono molto ad essere rilevati, quindi forzo una pulizia sennò l'uso RAM skizza alle stelle
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
                if (enemy.IsColliding(ref player) != SADGames.Classes.Collidable_Object.COLLIDED_EDGE.NONE & enemy.TimAI.Enabled)
                {
                    Retry();
                }

            foreach (var birb in skyChasers)
                if (birb.IsColliding(ref player) != SADGames.Classes.Collidable_Object.COLLIDED_EDGE.NONE & birb.TimAI.Enabled)
                {
                    Retry();
                }

            winFlag.IsColliding(ref player);
            if (spike.IsColliding(ref player) != SADGames.Classes.Collidable_Object.COLLIDED_EDGE.NONE) {
                Retry();
            }

            if (winFlag.Win)
                this.Close();
        }
        void Retry()
        {
            PauseProcess();
            this.DialogResult = DialogResult.Retry;
            FrmYouDied frm = new FrmYouDied(this.Location, this.Size);
            frm.ShowDialog(this);
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

        private void frmLevel2_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                UnPauseProcess();
            else
                PauseProcess();
        }

        private void timTrap_Tick(object sender, EventArgs e)
        {
            int vel = 20;
            this.picCeiling1.Location = new Point(this.picCeiling1.Location.X,
                this.picCeiling1.Location.Y + vel);
            this.picCeiling2.Location = new Point(this.picCeiling2.Location.X,
                this.picCeiling2.Location.Y + vel);
            this.picSpikes.Location = new Point(this.picSpikes.Location.X,
                this.picSpikes.Location.Y + vel);
        }
    }
}
