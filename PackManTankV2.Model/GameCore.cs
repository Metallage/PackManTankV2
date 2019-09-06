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

    public delegate void GameObjectStateHandler(object sender, EventArgs e);


    public class GameCore
    {


        public delegate void GameStartedHandler(bool startGame);

        public delegate void GameUpdateHandler(GameMap mymap);

        public delegate void GameFinishHandler(bool win);

        public event GameStartedHandler GameStarted;

        public event GameUpdateHandler GameUpdate;

        public event GameFinishHandler GameFinished;


        public GameMap CurentMap { get; }

        public Hero MyHero { get; set;}

        private bool? isWin = null;
        private bool? gameRunning = null;


        public void StartGame()
        {
            gameRunning = true;
        }


        private void SpawnHero(int cX, int cY, Directions direction, GameObjectStateHandler heroSpawn)
        {
            Hero newHero = new Hero(cX, cY, 10, 10);
            newHero.HeroSpawned += heroSpawn;
        }

    }
}
