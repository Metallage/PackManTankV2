using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackManTankV2.Model;

namespace PackManTankV2.ViewModel
{
    public class HeroView : Hero , INotifyPropertyChanged
    {
        private int coordX;
        private int coordY;

        public override int Height => base.Height;
        public override int Width => base.Width;

        public override int CoordX { get => coordX;
            set
            {
                if (value != coordX)
                {
                    coordX = value;
                    OnPropertyChanged(this, "CoordX");
                }
            }
        }


        public override int CoordY { get => coordY; set
            {
                if (value != coordY)
                {
                    coordY = value;
                    OnPropertyChanged(this, "CoordY");
                }
            }
        }

        public HeroView()
        { }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged(object sender, string propertyName)
        {
            PropertyChanged?.Invoke(sender, new PropertyChangedEventArgs(propertyName));
        }
    }
}
