using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UNR_Crossroad.Core
{
    public class Car : IMovementMember
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public Bitmap Sprite { get; set; }
        public Vector Direct { get; set; }
        public int SomeTt { get; set; }

        public Car(int x, int y, int speed,Bitmap sprite,Vector dir,int som)
        {
            X = x;
            Y = y;
            Speed = speed;
            Sprite = sprite;
            Direct = dir;
            SomeTt = som;
        }
    }
}
