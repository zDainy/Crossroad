using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

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

        public static void Start(Panel p)
        {
            IsReady = true;
            _mainRoad = new Road(1, 1, 1, 1);
            Members = new List<IMovementMember>();
            r = new Random();
            Timer move = new Timer { Interval = 1 };
            move.Tick += (sender, e) => Move_Tick(p);
            move.Start();
            gen = new Timer { Interval = 100 };
            gen.Tick += (sender, e) => GenerateMembers_Tick(p);
            gen.Start();
            lb = new Label {Location = new Point(0, 0)};
            p.Controls.Add(lb);
        }

        public static void Move_Tick(Panel p)
        {
            for (int i = 0; i < Members.Count; i++)
            {
                Members[i].Y += Members[i].Direct.Y * Members[i].Speed;
                Members[i].X += Members[i].Direct.X * Members[i].Speed;
                // Освобождение памяти
                if (Members[i].X < 0 || Members[i].X > p.Width || Members[i].Y < 0 || Members[i].Y > p.Height)
                {
                    Members.RemoveAt(i);
                }
            }
            // Кол-во машин (левый верхний угол)
            lb.Text = Members.Count.ToString();
            p.Invalidate();
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

        // Тестовый
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
            Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"), 28, 50);
            int newR = r.Next(0, _mainRoad.VerticalRoadRight);
            if (!Members.Exists(c => c.X == p.Width/2 + 6 + newR*40 && c.Y + 55 >= p.Height))
            {
                Members.Add(new Car(p.Width / 2 + 6 + newR * 40, p.Height, 3, bm, new Point(0, -1)));
            }
        }

        public static void GenVerticalLeftCar(Panel p)
        {
            Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"), 28, 50);
            bm.RotateFlip(RotateFlipType.Rotate180FlipNone);
            int newR = r.Next(0, _mainRoad.VerticalRoadLeft);
            if (!Members.Exists(c => c.X == p.Width / 2 - 34 - newR * 40 && c.Y - 55 <= 0))
            {
                Members.Add(new Car(p.Width / 2 - 34 - newR * 40, 0, 3, bm, new Point(0, 1)));
            }
        }

        public static void GenHorizontalUpCar(Panel p)
        {
            Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"), 28, 50);
            bm.RotateFlip(RotateFlipType.Rotate270FlipNone);
            int newR = r.Next(0, _mainRoad.HorizontRoadUp);
            if (!Members.Exists(c => c.Y == p.Height/2 - 34 - newR*40 && c.X + 55 >= p.Width))
            {
                Members.Add(new Car(p.Width, p.Height / 2 - 34 - newR * 40, 3, bm, new Point(-1, 0)));
            }
        }

        public static void GenHorizontalDownCar(Panel p)
        {
            Bitmap bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"), 28, 50);
            bm.RotateFlip(RotateFlipType.Rotate90FlipNone);
            int newR = r.Next(0, _mainRoad.HorizontRoadDown);
            if (!Members.Exists(c => c.Y == p.Height / 2 + 6 + newR * 40 && c.X - 55 <= 0))
            {
                Members.Add(new Car(0, p.Height / 2 + 6 + newR*40, 3, bm, new Point(1, 0)));
            }
        }
    }
}
