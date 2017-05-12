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
        public static Bitmap[] SpriteLibVerticalLights = new Bitmap[3];
        public static Bitmap[] SpriteLibHorizontalLights = new Bitmap[3];
        public static Label Lb { get; set; }
        public static bool IsDone { get; set; }
        private static int _delay = 20;

        // public static void LoadCarSpriteLib(Label lb)
        public static void LoadCarSpriteLib()
        {
           // Lb = lb;
            LoadFileName();
            LoadUpSprite();
            LoadRightSprite();
            LoadDownSprite();
            LoadLeftSprite();
            LoadVerticalLightsSprite();
            LoadHorizontalLightsSprite();
           // Lb.Invoke(new Action(() => Lb.Text = "Loading complete"));
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
               // Lb.Invoke(new Action(() => Lb.Text = "Up ..   " + FileName[i]));
              //  Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(FileName[i]));
                SpriteLibUp[i] = _tmpBitmap;
            }
        }

        private static void LoadRightSprite()
        {
            for (int i = 0; i < SpriteLibRight.Length; i++)
            {
             //   Lb.Invoke(new Action(() => Lb.Text = "Right ..   " + FileName[i]));
              //  Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(FileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                SpriteLibRight[i] = _tmpBitmap;
            }
        }

        private static void LoadDownSprite()
        {
            for (int i = 0; i < SpriteLibDown.Length; i++)
            {
              //  Lb.Invoke(new Action(() => Lb.Text = "Down ..   " + FileName[i]));
               // Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(FileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                SpriteLibDown[i] = _tmpBitmap;
            }
        }

        private static void LoadLeftSprite()
        {
            for (int i = 0; i < SpriteLibLeft.Length; i++)
            {
             //   Lb.Invoke(new Action(() => Lb.Text = "Left ..   " + FileName[i]));
             //   Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(FileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                SpriteLibLeft[i] = _tmpBitmap;
            }
        }

        private static void LoadVerticalLightsSprite()
        {
            //   Lb.Invoke(new Action(() => Lb.Text = "TrafficLights ..   " + img\\Lights\\VerticalLights.spr));
            SpriteLibVerticalLights[0] = new Bitmap(Image.FromFile("img\\Lights\\Red.png"));
            SpriteLibVerticalLights[1] = new Bitmap(Image.FromFile("img\\Lights\\Yellow.png"));
            SpriteLibVerticalLights[2] = new Bitmap(Image.FromFile("img\\Lights\\Green.png"));
            //   Thread.Sleep(_delay);
        }
        private static void LoadHorizontalLightsSprite()
        {
            //   Lb.Invoke(new Action(() => Lb.Text = "TrafficLights ..   " + img\\Lights\\HorizontalLights.spr));
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Red.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SpriteLibHorizontalLights[0] = _tmpBitmap;
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Yellow.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SpriteLibHorizontalLights[1] = _tmpBitmap;
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Green.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SpriteLibHorizontalLights[2] = _tmpBitmap;
            //   Thread.Sleep(_delay);
        }
    }
}
