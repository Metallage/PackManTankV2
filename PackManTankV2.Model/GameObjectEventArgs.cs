using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackManTankV2.Model
{
    public class GameObjectEventArgs: EventArgs
    {
        public Directions Direction { get; }

        public int CoordX { get; }

        public int CoordY { get; }
    }
}
