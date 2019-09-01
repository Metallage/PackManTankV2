using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackManTankV2.Model
{
    /// <summary>
    /// Клас абстрактного игрового объекта
    /// </summary>
    public abstract class GameObject
    {
        /// <summary>
        /// Расположение огбъекта по координате X
        /// </summary>
        public abstract int CoordX { get; set; }
        /// <summary>
        /// Расположение объета по координате Y
        /// </summary>
        public abstract int CoordY { get; set; }

        /// <summary>
        /// Высота объекта
        /// </summary>
        public abstract int Height { get;  }

        /// <summary>
        /// Ширина объекта
        /// </summary>
        public abstract int Width { get; }
    }
}
