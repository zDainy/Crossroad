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
        public Point Direct { get; set; }

        public Car(int x, int y, int speed,string sprite,Point dir)
        {
            X = x;
            Y = y;
            Speed = speed;
            Sprite = new Bitmap(Image.FromFile(sprite));
            Direct = dir;
        }
    }
}
