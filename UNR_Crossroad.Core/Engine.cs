using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace UNR_Crossroad.Core
{
    public static class Engine
    {
        public static List<IMovementMember> Members { get; set; }
        public static bool IsReady { get; set; }
        private static Random r;
        private static Road _mainRoad;
        private static Label lb;
        public static Timer gen;

        private static Label lbOption;

        public static void Start(Panel p)
        {
            IsReady = true;
            _mainRoad = new Road(3, 4, 4, 4);
            Members = new List<IMovementMember>();
            r = new Random();
            //
            //
            Members.Add(new Car(p.Width/2 - 8+40, p.Height-350, 3, new Bitmap(Image.FromFile("img\\Car\\car1_blue.png")), new Vector(0, -1),2));  // Для теста
            Members.Add(new Car(p.Width / 2 - 8, p.Height - 50, 3, new Bitmap(Image.FromFile("img\\Car\\car1_blue.png")), new Vector(0, -1),1));  // Для теста
            Members.Add(new Car(p.Width / 2 - 8+80, p.Height - 150, 3, new Bitmap(Image.FromFile("img\\Car\\car1_blue.png")), new Vector(0, -1), 3));  // Для теста
            Members.Add(new Car(p.Width / 2 - 8 + 120, p.Height - 250, 3, new Bitmap(Image.FromFile("img\\Car\\car1_blue.png")), new Vector(0, -1), 4));  // Для теста


            lbOption = new Label {Location = new Point(700, 550)};
            //
            //
            Timer move = new Timer { Interval = 10};
            move.Tick += (sender, e) => Move_Tick(p);
            move.Start();
            gen = new Timer { Interval = 100 };
            gen.Tick += (sender, e) => GenerateMembers_Tick(p);
            gen.Start();
            lb = new Label {Location = new Point(0, 0)};
            p.Controls.Add(lb);
            p.Controls.Add(lbOption);
        }

        public static void Move_Tick(Panel p)
        {
            foreach (var m in Members)
            {
                if (m.X <= p.Width/2 + 200 && m.X >= p.Width/2 - 126 && m.Y >= p.Height/2 - 86 &&
                    m.Y <= p.Height/2 + 40*m.SomeTt)
                {
                    m.Speed = 1;
                    Povorot((Car) m, p);
                }
                Move((Car) m);
            }
            // Кол-во машин (левый верхний угол)
            lb.Text = Members.Count.ToString();
            p.Invalidate();
        }

        public static void Povorot(Car c, Panel p)
        {
            c.Direct = new Vector(c.Direct.X + 0.12 , c.Direct.Y - 0.007);
            c.Y += (int) c.Direct.Y*c.Speed;
            c.X += (int) c.Direct.X*c.Speed;
            c.Sprite = RotateImage(c.Sprite, 4);
            if (PovorotEndCheck(c, p.Width/2 + 40*(c.SomeTt)))
            {
                c.Direct = new Vector(1, 0);
                Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
                bm.RotateFlip(RotateFlipType.Rotate90FlipNone);
                c.Sprite = bm;
            }
        }

        private static Bitmap RotateImage(Bitmap input, float angle)
        {
            Bitmap result = new Bitmap(input.Height, input.Height);
            Graphics g = Graphics.FromImage(result);
            g.TranslateTransform((float)input.Width / 2, (float)input.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-(float)input.Width / 2, -(float)input.Height / 2);
            g.DrawImage(input, new Point(0, 0));
            return result;
        }

        public static bool PovorotEndCheck(Car c, int g)
        {
            return c.X >= g;
        }

        public static void Move(Car c)
        {
            c.Y += (int)c.Direct.Y * c.Speed;
            c.X += (int)c.Direct.X * c.Speed;
        }

        public static void RenderMap(object sender, PaintEventArgs e)
        {
            if (IsReady)
            {
                _mainRoad.RenderRoad(sender as Panel, e);
                foreach (var m in Members)
                {
                    e.Graphics.DrawImage(m.Sprite, new Point(m.X, m.Y));
                }
            }
        }


        public static void GenerateMembers_Tick(Panel p)
        {
            switch (r.Next(1, 5))
            {
                case 1:
                    GenVerticalLeftCar(p);
                    break;
                case 2:
                    GenVerticalRightCar(p);
                    break;
                case 3:
                    GenHorizontalUpCar(p);
                    break;
                case 4:
                    GenHorizontalDownCar(p);
                    break;
            }
        }

        public static void GenVerticalRightCar(Panel p)
        {
            Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
            int newR = r.Next(0, _mainRoad.VerticalRoadRight);
            if (!Members.Exists(c => c.X == p.Width / 2 - 8 + newR * 40 && c.Y + 55 >= p.Height))
            {
                Members.Add(new Car(p.Width / 2 - 8 + newR * 40, p.Height, 3, bm, new Vector(0, -1),newR+1));
            }
        }

        public static void GenVerticalLeftCar(Panel p)
        {
            Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
            bm.RotateFlip(RotateFlipType.Rotate180FlipNone);
            int newR = r.Next(0, _mainRoad.VerticalRoadLeft);
            if (!Members.Exists(c => c.X == p.Width / 2 - 34 - newR * 40 && c.Y - 55 <= 0))
            {
                Members.Add(new Car(p.Width / 2 - 50 - newR * 40, 0, 3, bm, new Vector(0, 1), newR + 1));
            }
        }

        public static void GenHorizontalUpCar(Panel p)
        {
            Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
            bm.RotateFlip(RotateFlipType.Rotate270FlipNone);
            int newR = r.Next(0, _mainRoad.HorizontRoadUp);
            if (!Members.Exists(c => c.Y == p.Height / 2 - 34 - newR * 40 && c.X + 55 >= p.Width))
            {
                Members.Add(new Car(p.Width, p.Height / 2 - 50 - newR * 40, 3, bm, new Vector(-1, 0), newR + 1));
            }
        }

        public static void GenHorizontalDownCar(Panel p)
        {
            Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
            bm.RotateFlip(RotateFlipType.Rotate90FlipNone);
            int newR = r.Next(0, _mainRoad.HorizontRoadDown);
            if (!Members.Exists(c => c.Y == p.Height / 2 + 6 + newR * 40 && c.X - 55 <= 0))
            {
                Members.Add(new Car(0, p.Height / 2 - 8 + newR * 40, 3, bm, new Vector(1, 0), newR + 1));
            }
        }
    }
}
