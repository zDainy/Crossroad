using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UNR_Crossroad.Core
{
    public static class Engine
    {
        public static List<IMovementMember> Members { get; set; }
        public static bool IsReady { get; set; }
        private static Random r;

        public static void Start(Panel p)
        {
            IsReady = true;
            Members = new List<IMovementMember>();
            r = new Random();
            Timer move = new Timer { Interval = 1 };
            move.Tick += (sender, e) => Move_Tick(p);
            move.Start();
            Timer gen = new Timer { Interval = 1000 };
            gen.Tick += (sender, e) => GenerateMembers_Tick(p);
            gen.Start();
        }

        public static void Move_Tick(Panel p)
        {
            for (int i = 0; i < Members.Count; i++)
            {
                Members[i].Y += Members[i].Direct.Y * Members[i].Speed;
                Members[i].X += Members[i].Direct.X * Members[i].Speed;
            }
            p.Invalidate();
        }

        public static void RenderMovement(object sender, PaintEventArgs e)
        {
            if (IsReady)
            {
                foreach (var m in Members)
                {
                    e.Graphics.DrawImage(m.Sprite, new Point(m.X, m.Y));
                }
            }
        }

        // Тестовый
        // Илюх разберись
        public static void GenerateMembers_Tick(Panel p)
        {
            Point dirX = new Point(r.Next(-1, 2), 0);
            while (dirX.X == 0)
            {
                dirX.X = r.Next(-1, 2);
            }
            Point dirY = new Point(0, r.Next(-1, 2));
            while (dirY.Y == 0)
            {
                dirY.Y = r.Next(-1, 2);
            }
            Car cY = new Car(r.Next(10,p.Width-10), r.Next(10, p.Height - 10), r.Next(1, 5), "img\\Car\\car1_blue.png", dirY);
            Car cX = new Car(r.Next(10, p.Width - 10), r.Next(10, p.Height - 10), r.Next(1, 5), "img\\Car\\car1_blue.png", dirX);
            if (dirY.Y != -1)
            {
                cY.Sprite.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            Members.Add(cY);
            if (dirX.X == 1)
            {
                cX.Sprite.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }
            if (dirX.X == -1)
            {
                cX.Sprite.RotateFlip(RotateFlipType.Rotate270FlipNone);
            }
            Members.Add(cX);
        }
    }
}
