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
    public static class Sprite
    {
        private static Bitmap _tmpBitmap;

        public static string[] Color =
        {
            "blue", "green", "orange", "purple", "red", "yellow"
        };

        public static string[] Hair =
        {
            "Blond", "Brown", "Black"
        };

        public static string[] CarFileName = new string[42];
        public static Bitmap[] SpriteLibUp = new Bitmap[42];
        public static Bitmap[] SpriteLibDown = new Bitmap[42];
        public static Bitmap[] SpriteLibLeft = new Bitmap[42];
        public static Bitmap[] SpriteLibRight = new Bitmap[42];
        public static Bitmap[] SpriteLibDownLights = new Bitmap[3];
        public static Bitmap[] SpriteLibLeftLights = new Bitmap[3];
        public static Bitmap[] SpriteLibUpLights = new Bitmap[3];
        public static Bitmap[] SpriteLibRightLights = new Bitmap[3];
        public static string[] PeopleFileName1 = new string[18];
        public static string[] PeopleFileName2 = new string[18];
        public static Bitmap[] SpriteLibRightPeople1 = new Bitmap[18];
        public static Bitmap[] SpriteLibRightPeople2 = new Bitmap[18];
        public static Bitmap[] SpriteLibUpPeople1 = new Bitmap[18];
        public static Bitmap[] SpriteLibUpPeople2 = new Bitmap[18];
        public static Bitmap[] SpriteLibDownPeople1 = new Bitmap[18];
        public static Bitmap[] SpriteLibDownPeople2 = new Bitmap[18];
        public static Bitmap[] SpriteLibLeftPeople1 = new Bitmap[18];
        public static Bitmap[] SpriteLibLeftPeople2 = new Bitmap[18];

        public static Label Lb { get; set; }
        public static bool IsDone { get; set; }
        private static int _delay = 20;

         public static void LoadCarSpriteLib(Label lb) 
        {
            Lb = lb; 
            LoadCarFileName();
            LoadUpSprite();
            LoadRightSprite();
            LoadDownSprite();
            LoadLeftSprite();
            LoadDownLightsSprite();
            LoadLeftLightsSprite();
            LoadRightLightsSprite();
            LoadUpLightsSprite();
            LoadPeopleFileName();
            LoadPeopleLibDown();
            LoadPeopleLibLeft();
            LoadPeopleLibRight();
            LoadPeopleLibUp();
            Lb.Invoke(new Action(() => Lb.Text = "Loading complete")); 
            Thread.Sleep(1000);
            IsDone = true;
        }


        private static void LoadCarFileName()
        {
            for (int i = 0; i < CarFileName.Length;)
            {
                foreach (var clr in Color)
                {
                    for (int k = 1; k < 8; k++)
                    {
                        CarFileName[i] = "img\\Car\\car" + k + "_" + clr + ".png";
                        i++;
                    }
                }
            }
        }
        private static void LoadPeopleFileName()
        {
            for (int i = 0; i < PeopleFileName1.Length;)
            {
                foreach (var clr in Color)
                {
                    foreach (var h in Hair)
                    {
                        PeopleFileName1[i] = "img\\People\\Person_" + clr + h + "1" + ".png";
                        PeopleFileName2[i] = "img\\People\\Person_" + clr + h + "2" + ".png";
                        i++;
                    }
                }
            }
        }

        private static void LoadUpSprite()
        {
            for (int i = 0; i < SpriteLibUp.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Up .. " + CarFileName[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(CarFileName[i]));
                SpriteLibUp[i] = _tmpBitmap;
            }
        }

        private static void LoadRightSprite()
        {
            for (int i = 0; i < SpriteLibRight.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Right .. " + CarFileName[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(CarFileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                SpriteLibRight[i] = _tmpBitmap;
            }
        }

        private static void LoadDownSprite()
        {
            for (int i = 0; i < SpriteLibDown.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Down .. " + CarFileName[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(CarFileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                SpriteLibDown[i] = _tmpBitmap;
            }
        }

        private static void LoadLeftSprite()
        {
            for (int i = 0; i < SpriteLibLeft.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Left .. " + CarFileName[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(CarFileName[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                SpriteLibLeft[i] = _tmpBitmap;
            }
        }

        private static void LoadDownLightsSprite()
        {
            Lb.Invoke(new Action(() => Lb.Text = "TrafficLights .. " + "img\\Lights\\DownLights.spr"));
            SpriteLibDownLights[0] = new Bitmap(Image.FromFile("img\\Lights\\Red.png"));
            SpriteLibDownLights[1] = new Bitmap(Image.FromFile("img\\Lights\\Yellow.png"));
            SpriteLibDownLights[2] = new Bitmap(Image.FromFile("img\\Lights\\Green.png"));
            Thread.Sleep(_delay * 5);
        }
        private static void LoadUpLightsSprite()
        {
            Lb.Invoke(new Action(() => Lb.Text = "TrafficLights .. " + "img\\Lights\\UpLights.spr"));
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Red.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            SpriteLibUpLights[0] = _tmpBitmap;
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Yellow.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            SpriteLibUpLights[1] = _tmpBitmap;
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Green.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            SpriteLibUpLights[2] = _tmpBitmap;
            Thread.Sleep(_delay * 5);
        }

        private static void LoadRightLightsSprite()
        {
            Lb.Invoke(new Action(() => Lb.Text = "TrafficLights .. " + "img\\Lights\\RightLights.spr"));
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Red.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            SpriteLibRightLights[0] = _tmpBitmap;
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Yellow.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            SpriteLibRightLights[1] = _tmpBitmap;
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Green.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            SpriteLibRightLights[2] = _tmpBitmap;
            Thread.Sleep(_delay * 5);
        }

        private static void LoadLeftLightsSprite()
        {
            Lb.Invoke(new Action(() => Lb.Text = "TrafficLights .. " + "img\\Lights\\LeftLights.spr")); 
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Red.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SpriteLibLeftLights[0] = _tmpBitmap;
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Yellow.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SpriteLibLeftLights[1] = _tmpBitmap;
            _tmpBitmap = new Bitmap(Image.FromFile("img\\Lights\\Green.png"));
            _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SpriteLibLeftLights[2] = _tmpBitmap;
            Thread.Sleep(_delay * 5); 
        }

        private static void LoadPeopleLibLeft()
        {
            for (int i = 0; i < SpriteLibLeftPeople1.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Left .. " + PeopleFileName1[i]));
                Thread.Sleep(_delay);
                SpriteLibLeftPeople1[i] = new Bitmap(Image.FromFile(PeopleFileName1[i]));
                SpriteLibLeftPeople2[i] = new Bitmap(Image.FromFile(PeopleFileName2[i]));
            }
        }

        private static void LoadPeopleLibRight()
        {
            for (int i = 0; i < SpriteLibLeftPeople1.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Right .. " + PeopleFileName1[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(PeopleFileName1[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                SpriteLibRightPeople1[i] = _tmpBitmap;
                _tmpBitmap = new Bitmap(Image.FromFile(PeopleFileName2[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                SpriteLibRightPeople2[i] = _tmpBitmap;
            }
        }
        private static void LoadPeopleLibUp()
        {
            for (int i = 0; i < SpriteLibLeftPeople1.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Up .. " + PeopleFileName1[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(PeopleFileName1[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                SpriteLibUpPeople1[i] = _tmpBitmap;
                _tmpBitmap = new Bitmap(Image.FromFile(PeopleFileName2[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                SpriteLibUpPeople2[i] = _tmpBitmap;
            }
        }

        private static void LoadPeopleLibDown()
        {
            for (int i = 0; i < SpriteLibLeftPeople1.Length; i++)
            {
                Lb.Invoke(new Action(() => Lb.Text = "Down .. " + PeopleFileName1[i]));
                Thread.Sleep(_delay);
                _tmpBitmap = new Bitmap(Image.FromFile(PeopleFileName1[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                SpriteLibDownPeople1[i] = _tmpBitmap;
                _tmpBitmap = new Bitmap(Image.FromFile(PeopleFileName2[i]));
                _tmpBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                SpriteLibDownPeople2[i] = _tmpBitmap;
            }
        }
    }
}