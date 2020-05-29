using System;
using System.Collections.Generic;//Liste
using System.Drawing;//Bitmap,Size
using System.IO;
using System.Text;

namespace SADGames.Classes.Animation
{
    /// <summary>
    /// Classe che serve a gestire le animazioni
    /// </summary>
    public class ClsAnimation
    {
        //Bitmap che serve da restituire nel caso che un frame risulti nullo
        public static Bitmap ErrorBitmap = new Bitmap(100,100);

        #region Variables
        //List dei frame
        List<Bitmap> frames = new List<Bitmap>();

        #endregion

        #region Properties
        public int FramesLenght { get => frames.Count; }

        #endregion

        #region Methods

        public ClsAnimation() { }

        /// <summary>
        /// Controlla che INDEX sia accettabile, per poi
        /// ritornare il frame in posizione INDEX e aumentare
        /// di uno INDEX
        /// </summary>
        /// <param name="INDEX">Posizione Del Prossimo Frame</param>
        /// <returns>Il frame in posizione INDEX</returns>
        public Bitmap GetNextFrame(ref int INDEX)
        {
            if (this.frames == null)
                return ErrorBitmap;
            if (this.frames.Count == 0)
                return ErrorBitmap;

            if (INDEX < 0 || INDEX >= frames.Count)
                INDEX = 0;

            Bitmap temp = new Bitmap(frames[INDEX]);

            INDEX++;

            return temp;
        }
        /// <summary>
        /// Stessa cosa di GetNextFrame(...),
        /// solo che in questo caso specchia il frame
        /// sull'asse X
        /// <seealso cref="GetNextFrame(ref int)"/>
        /// </summary>
        /// <param name="INDEX">Posizione del frame da prendere</param>
        /// <returns>Frame in posizione INDEX</returns>
        public Bitmap GetNextFlippedXFrame(ref int INDEX)
        {
            Bitmap temp = GetNextFrame(ref INDEX);
            temp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return temp;
        }
        /// <summary>
        /// Aggiunge un frame
        /// </summary>
        /// <param name="PATH">Posizione in cui prendere l'immagine</param>
        public void AddFrame(string PATH)
        {
            frames.Add(new Bitmap(PATH));
        }
        /// <summary>
        /// Aggiunge un frame, ma ridotto secondo una scala
        /// </summary>
        /// <param name="PATH">Posizione del frame</param>
        /// <param name="scaling">Rapporto di ingrandimento/rimpicciolimento</param>
        public void AddFrame(string PATH,float scaling)
        {
            //Non c'era un costruttore (path,size) ma solo (image,size)
            Bitmap temp = new Bitmap(PATH);
            temp = new Bitmap(temp,new Size(
                (int)(temp.Width * scaling),
                (int)(temp.Height * scaling)
                ));
            frames.Add(temp);
        }

        public void AddFrame(Bitmap frame)
        {
            //Non c'era un costruttore (path,size) ma solo (image,size)
            Bitmap temp = new Bitmap(frame);
            frames.Add(temp);
        }
        /// <summary>
        /// Rimuove un frame
        /// </summary>
        /// <param name="INDEX"></param>
        public void RemoveFrame(int INDEX)
        {
            frames.RemoveAt(INDEX);
        }

        #endregion
    }
}
