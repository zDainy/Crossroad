using System.Drawing;

namespace UNR_Crossroad.Core
{
    public class Car : IMovementMember
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public Bitmap Sprite { get; set; }
        public int NSprite { get; set; }
        public Vector Direct { get; set; }
        public int Polosa { get; set; }
        public int StartRoadCount { get; set; }
        public int FinishRoadCount { get; set; }
        public CRoad StartRoad { get; set; }
        public CTurn Turn { get; set; }

        public Car(int x, int y, int speed, Bitmap sprite,int nspr, Vector dir, int polosa, int src, int frc, CRoad cr,CTurn ct)
        {
            X = x;
            Y = y;
            Speed = speed;
            Sprite = sprite;
            Direct = dir;
            Polosa = polosa;
            StartRoadCount = src;
            FinishRoadCount = frc;
            StartRoad = cr;
            Turn = ct;
            NSprite = nspr;
        }
    }
}
