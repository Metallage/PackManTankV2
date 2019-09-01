using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackManTankV2.Model
{/// <summary>
 /// В этом класе храняться данные о расположении и состоянии объектов на карте
 /// </summary>
    public class GameMap
    {
        #region Поля и свойства


        /// <summary>
        /// Размер карты в высоту
        /// </summary>
        public int Height { get; }

        /// <summary>
        /// Расмер карты в ширину
        /// </summary>
        public int Width { get; }

        /// <summary>
        /// Список объектов
        /// </summary>
        public List<GameObject> GameObjects { get; }

        #endregion


        private void AddHero(int coordX, int coordY, int height, int width, Directions directions)
        {
            Hero myHero = new Hero(coordX, coordY, height, width);
            GameObjects.Add(myHero);          
        }

    }
}
