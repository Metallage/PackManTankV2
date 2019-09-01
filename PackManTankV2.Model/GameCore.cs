using System;
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


        public delegate void GameStartedHandler(bool startGame);

        public delegate void GameUpdateHandler(GameMap mymap);

        public delegate void GameFinishHandler(bool win);

        public event GameStartedHandler GameStarted;

        public event GameUpdateHandler GameUpdate;

        public event GameFinishHandler GameFinished;


        public GameMap CurentMap { get; }

    }
}
