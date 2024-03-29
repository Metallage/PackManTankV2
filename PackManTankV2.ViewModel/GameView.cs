﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackManTankV2.Model;

namespace PackManTankV2.ViewModel
{

    public delegate void UpdateEventHandler(object sender, GameUpdateEventArgs e);
    public class GameView
    {
        private GameCore myGame;

        public ObservableCollection<GameObject> GameObjects { get; } = new ObservableCollection<GameObject>();



        public event UpdateEventHandler OnUpdate;

        public GameView()
        {
            myGame = new GameCore();
        }

        private void RunGame()
        {
            
        }

    }
}
