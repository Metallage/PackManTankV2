using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackManTankV2.Model
{
    public class Hero: GameObject
    {
        public override int CoordX { get; set; }

        public override int CoordY { get; set; }

        public override int Height { get; }

        public override int Width { get; }

        public Hero(int coordX, int coordY, int height, int width)
        {
            CoordX = coordX;
            CoordY = coordY;
            Height = height;
            Width = width;
        }

    }
}
