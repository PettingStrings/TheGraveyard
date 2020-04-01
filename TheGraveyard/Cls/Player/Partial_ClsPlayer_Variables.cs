using SADGames.Classes.Animation;
using SADGames.Classes.CanIs;
using SADGames.Classes.Collidable_Object;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Costruttore e cose un po' miste

namespace SADGames.Classes.Player
{
    enum FACE_DIR { LEFT, RIGHT };
    public enum ACTIONS { WRIGHT, WLEFT, JUMP, CROUCH, IDLE, ATTACK };
    public partial class ClsPlayer:ClsCollidableObject
    { 

        FACE_DIR fDir = FACE_DIR.RIGHT;//Direzione in cui va il giocatore
        PictureBox lastTouchedPlat;
        

        #region Properties
        public ClsAnimation AnimAttack { get => atkAnimation; set => atkAnimation = value; }
        public ClsAnimation AnimWalk { get => walkAnimation; set => walkAnimation = value; }
        public ClsAnimation AnimJump { get => jumpAnimation; set => jumpAnimation = value; }
        public ClsAnimation AnimIdle { get => idleAnimation; set => idleAnimation = value; }
        public Timer TimIdle { get => timIdle; set => timIdle = value; }
        public Timer TimRun { get => WalkTim; set => WalkTim = value; }
        internal FACE_DIR FDir { get => fDir; set => fDir = value; }
        public bool OnGround { get => onGround; set => onGround = value; }
        public StrCanIs CanisJump { get => jumpCanIs; set => jumpCanIs = value; }
        public StrCanIs CanisAttack { get => atkCanIs; set => atkCanIs = value; }
        public PictureBox LastOnTop { get => lastTouchedPlat; set => lastTouchedPlat = value; }

        #endregion

        public ClsPlayer()
        {
            walkAnimation = new ClsAnimation();
            jumpAnimation = new ClsAnimation();
            idleAnimation = new ClsAnimation();
            AnimAttack = new ClsAnimation();

            idleCanIs.CanDo = true;
            idleCanIs.IsDoing = false;

            jumpCanIs.CanDo = true;
            jumpCanIs.IsDoing = false;

            walkCanIs.CanDo = true;
            walkCanIs.IsDoing = false;

            atkCanIs.CanDo = true;
            atkCanIs.IsDoing = false;

            TimIdle = new Timer { Interval = 1000 / 3 };
            TimIdle.Tick += TimIdle_Tick;

            TimRun = new Timer { Interval = 100 };
            TimRun.Tick += TimRun_Tick;

            jumpTim = new Timer { Interval = 10 };
            jumpTim.Tick += TimJump_Tick;

            timAnimJmump = new Timer { Interval = 100 };
            timAnimJmump.Tick += TimAnimJmump_Tick;

            AtkTim = new Timer { Interval = 100 };
            AtkTim.Tick += TimAttack_Tick;

            atkTimCD = new Timer { Interval = 1000};
            atkTimCD.Tick += TimAttackCD_Tick;

            timDie = new Timer { Interval = 100 };
            timDie.Tick += TimDie_Tick;
        }
    }
}
