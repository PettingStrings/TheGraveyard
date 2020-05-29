using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SADGames.Classes.CanIs
{
    /// <summary>
    /// Struttura usata per sapere se un'azione
    /// può essere fatta e se la si sta facendo
    /// </summary>
    public struct StrCanIs
    {
        bool isDoing;
        bool canDo;

        public bool CanDo { get => canDo; set => canDo = value; }
        public bool IsDoing { get => isDoing; set => isDoing = value; }
    }
}
