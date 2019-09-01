using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackManTankV2.Model;

namespace PackManTankV2.ViewModel
{
    public class GameView
    {
        private GameCore myGame;

        public delegate void UpdateEventHandler();

        public event UpdateEventHandler OnUpdate;

    }
}
