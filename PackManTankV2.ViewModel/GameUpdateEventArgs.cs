using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackManTankV2.Model;

namespace PackManTankV2.ViewModel
{
    public class GameUpdateEventArgs :EventArgs
    {
        /// <summary>
        /// Массив игровых объектов
        /// </summary>
        public List<object> GameObjects { get; }

        /// <summary>
        /// Хранит значение победы в игре если true, поражения если false, null если игра ещё идёт
        /// </summary>
        public bool? IsWin { get; } = null;

        /// <summary>
        /// Сигнализирует о том что игра запущена если true, если false то на паузе или завершена
        /// </summary>
        public bool GameStart { get; }
    }
}
