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
using TheGraveyard.Levels;

namespace TheGraveyard.Levels
{
    /// <summary>
    /// Livello 1
    /// </summary>
    public partial class FrmLevel1 : Form
    {
        ClsPlayer player;

        #region Tiles

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

        private int kills = 0, time = 0;
        public int Kills { get => kills; }
        public int Time { get => (int)time/1000; }
        public bool Win { get => winFlag.Win; }
        public FrmLevel1()
        {
            InitializeComponent();
        }

        private void FrmLevel1_Load(object sender, EventArgs e)
        {
            LoadScene();
            LoadPlayer();
            StartGame();
            timGC.Start();
        }
        /// <summary>
        /// Carica le picturebox sulla scena
        /// </summary>
        private void LoadScene()
        {
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
                new ClsSkyChaser{ Body = picSkyChaser1,Target = this.picPlayer,Range = 100,AnimWalk = animBirbIdle_Walk,AnimIdle = animBirbIdle_Walk},
                new ClsSkyChaser{ Body = picSkyChaser2,Target = this.picPlayer,Range = 100,AnimWalk = animBirbIdle_Walk,AnimIdle = animBirbIdle_Walk}
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
                new ClsPlatformWatcher{ Body = this.picSkelly1,LastOnTop = picPlat1},
                new ClsPlatformWatcher{ Body = this.picSkelly2,LastOnTop = picRange},
                new ClsPlatformWatcher{ Body = this.picSkelly3,LastOnTop = picRange}
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
        /// <summary>
        /// Avvia il gioco 
        /// </summary>
        private void StartGame()
        {
            Program.moon.Target = this.picMoon;
            Program.moon.TimAnim.Start();
            UnPauseProcess();
            StartAI();
        }
        /// <summary>
        /// Fa partire le intelligenze artificiali
        /// </summary>
        private void StartAI()
        {
            foreach (var skele in platWatchers)
                skele.TimAI.Start();

            foreach (var birb in skyChasers)
                birb.TimAI.Start();
        }
        /// <summary>
        /// Controlla quali tasti vengono premuti
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimKBHit_Tick(object sender, EventArgs e)
        {
            time += timKBHit.Interval;
            if (Keyboard.IsKeyDown(Key.D))
            {
                player.FDir = SADGames.Classes.Player.FACE_DIR.RIGHT; player.Walk();
                if (player.Body.Location.X > this.Width / 2)
                    ScrollCamera(player.MS);
            }
            else if (Keyboard.IsKeyDown(Key.A)) { player.FDir = SADGames.Classes.Player.FACE_DIR.LEFT; player.Walk(); }
            else if (Keyboard.IsKeyDown(Key.Space)) { player.Jump(); }
            else if (Keyboard.IsKeyDown(Key.F)) { player.Attack(); }
            else { player.Idle(); }
        }

        private void ScrollCamera(int dist)
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
        /// <summary>
        /// Chiama il garbace collectore ogni 5 secondis
        /// perchè i bitmap vengono rimossi dopo molto tempo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimGC_Tick(object sender, EventArgs e)
        {//I bitmap non ci mettono molto ad essere rilevati, quindi forzo una pulizia sennò l'uso RAM skizza alle stelle
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }
        /// <summary>
        /// Engine fisico, applica la gravità e controlla le collisioni
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimPhysEng_Tick(object sender, EventArgs e)
        {
            Gravity();
            CheckAndResolveCollisions();
        }
        /// <summary>
        /// Controlla e risolve le collsioni
        /// </summary>
        private void CheckAndResolveCollisions()
        {
            this.player.OnGround = false;

            if (this.mainGround.IsColliding(ref this.player) == SADGames.Classes.Collidable_Object.COLLIDED_EDGE.TOP) this.player.OnGround = true;

            foreach (var platform in this.plats)
                if (platform.IsColliding(ref this.player) == SADGames.Classes.Collidable_Object.COLLIDED_EDGE.TOP) this.player.OnGround = true;

            foreach (var enemy in platWatchers)
            {
                if (enemy.TimAI.Enabled)
                {
                    if (enemy.IsColliding(ref player) != SADGames.Classes.Collidable_Object.COLLIDED_EDGE.NONE & enemy.TimAI.Enabled)
                    {
                        Retry();
                    }
                    else if (!enemy.TimAI.Enabled)
                    { ClsPlayerAcc.Account.Kills++; Program.Commit(); kills++; }
                }
            }

            foreach (var birb in skyChasers)
            {
                if (birb.TimAI.Enabled)
                {
                    if (birb.IsColliding(ref player) != SADGames.Classes.Collidable_Object.COLLIDED_EDGE.NONE & birb.TimAI.Enabled)
                    {
                        Retry();
                    }
                    else if (!birb.TimAI.Enabled)
                    { ClsPlayerAcc.Account.Kills++; Program.Commit(); kills++; }
                }
            }

            winFlag.IsColliding(ref player);

            if (winFlag.Win)
                EndGame();
        }

        private void EndGame()
        { 
            this.Close();
        }

        /// <summary>
        /// Schermata di morte e ri inizio del livello
        /// </summary>
        void Retry()
        {
            PauseProcess();
            this.DialogResult = DialogResult.Retry;
            FrmYouDied frm = new FrmYouDied(this.Location, this.Size);
            frm.ShowDialog(this);
            ClsPlayerAcc.Account.Deaths++;
            Program.Commit();
            this.Close();
        }
        /// <summary>
        /// Applica la gravità
        /// </summary>
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
        /// <summary>
        /// Ferma il processo
        /// (stoppa l'engine fisico e il timer che legge i tasti premuti)
        /// </summary>
        private void PauseProcess()
        {
            timPhysEng.Stop();
            timKBHit.Stop();
        }
        /// <summary>
        /// Fa ripartire la partita
        /// (avvia l'engine fisico e il timer che legge i tasti premuti)
        /// </summary>
        private void UnPauseProcess()
        {
            timPhysEng.Start();
            timKBHit.Start();
        }
        /// <summary>
        /// Nel caso in cui la finestra venga minimizzata mette in pausa il gioco
        /// e viceversa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLevel1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.timPhysEng.Start();
            else
                this.timPhysEng.Stop();
        }
    }
}
