using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNR_Crossroad.Core
{
    public static class CarSprite
    {
        private static Bitmap _tmpBitmap;
        public static string[] CarColor = {
            "blue","green","orange","purple","red","yellow"
        };

        public static string[] FileName  = new string[42];
        public static Bitmap[] SpriteLibUp  = new Bitmap[42];
        public static Bitmap[] SpriteLibDown  = new Bitmap[42];
        public static Bitmap[] SpriteLibLeft  = new Bitmap[42];
        public static Bitmap[] SpriteLibRight  = new Bitmap[42];
        public static Label Lb { get; set; }
        public static bool IsDone { get; set; }
        private static int _delay = 20;

        public static void LoadCarSpriteLib(Label lb)
        {
            Lb = lb;
            LoadFileName();
            LoadUpSprite();
            LoadRightSprite();
            LoadDownSprite();
            LoadLeftSprite();
            Lb.Invoke(new Action(() => Lb.Text = "Loading complete"));
            Thread.Sleep(1000);
            IsDone = true;
        }
        

        private static void LoadFileName()
        {
            for (int i = 0; i < FileName.Length;)
            {
                foreach (var clr in CarColor)
                {
                    for (int k = 1; k < 8; k++)
                    {
                        FileName[i] = "img\\Car\\car" + k + "_" + clr + ".png";
                        i++;
                    }
                }
            }
        }
        private static void LoadUpSprite()
        {
            for (int i = 0; i < SpriteLibUp.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Up ..   " + FileName[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(FileName[i]));
                SpriteLibUp[i] = _tmpBitmap;
            }
        }

        private static void LoadRightSprite()
        {
            for (int i = 0; i < SpriteLibRight.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Right ..   " + FileName[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(FileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                SpriteLibRight[i] = _tmpBitmap;
            }
        }

        private static void LoadDownSprite()
        {
            for (int i = 0; i < SpriteLibDown.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Down ..   " + FileName[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(FileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                SpriteLibDown[i] = _tmpBitmap;
            }
        }

        private static void LoadLeftSprite()
        {
            for (int i = 0; i < SpriteLibLeft.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Left ..   " + FileName[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(FileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                SpriteLibLeft[i] = _tmpBitmap;
            }
        }
    }
}
