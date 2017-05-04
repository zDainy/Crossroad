using System.Drawing;

namespace UNR_Crossroad.Core
{
    public abstract class Turn
    {
        public abstract void StartTurn(Car c);
        public abstract void PovorotU(Car c);
        public abstract void PovorotD(Car c);
        public abstract void PovorotL(Car c);
        public abstract void PovorotR(Car c);

        public static Bitmap RotateImage(Bitmap input, float angle)
        {
            Bitmap result = new Bitmap(input.Height, input.Height);
            Graphics g = Graphics.FromImage(result);
            g.TranslateTransform((float)input.Width / 2, (float)input.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)input.Width / 2, -(float)input.Height / 2);
            g.DrawImage(input, new Point(0, 0));
            return result;
        }

        public abstract int CheckLanes(int polosa, int start, int finish);
    }
}
