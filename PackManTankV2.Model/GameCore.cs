﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackManTankV2.Model
{
    public enum Directions
    {
        North = 1,
        East = 2,
        South = 3,
        West = 4
    }

    public class GameCore
    {
        public GameMap currentMap = null;
        

        public GameMap CurentMap
        {
            get
            {
                return currentMap;
            }
        }

    }
}
