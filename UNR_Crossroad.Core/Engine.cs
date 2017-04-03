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

                    int verticalRoad_Left = 4;
                    int verticalRoad_Right = 2;

                    int horizontRoad_Up = 2;
                    int horizontRoad_Down = 3;

                    System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.FromArgb(64, 64, 64), 1);

                    Panel p = (Panel)sender;
                    //Rectangle screenSize = p.Bounds;

                    myPen.Width = verticalRoad_Left * 40;
                    e.Graphics.DrawLine(myPen, p.Width / 2 - myPen.Width / 2, 0, p.Width / 2 - myPen.Width / 2, p.Height);
                    myPen.Width = verticalRoad_Right * 40;
                    e.Graphics.DrawLine(myPen, p.Width / 2 + myPen.Width / 2, 0, p.Width / 2 + myPen.Width / 2, p.Height);
                    myPen.Width = horizontRoad_Up * 40;
                    e.Graphics.DrawLine(myPen, 0, p.Height / 2 - myPen.Width / 2, p.Width, p.Height / 2 - myPen.Width / 2);
                    myPen.Width = horizontRoad_Down * 40;
                    e.Graphics.DrawLine(myPen, 0, p.Height / 2 + myPen.Width / 2, p.Width, p.Height / 2 + myPen.Width / 2);

                    myPen.Color = Color.White;

                    myPen.Width = 2;
                    e.Graphics.DrawLine(myPen, p.Width / 2, 0, p.Width / 2, p.Height / 2 - horizontRoad_Up * 40); //12:00
                    e.Graphics.DrawLine(myPen, p.Width / 2, p.Height / 2 + horizontRoad_Down * 40, p.Width / 2, p.Height); //6:00
                    e.Graphics.DrawLine(myPen, 0, p.Height / 2, p.Width / 2 - verticalRoad_Left * 40, p.Height / 2); //9:00
                    e.Graphics.DrawLine(myPen, p.Width / 2 + verticalRoad_Right * 40, p.Height / 2, p.Width, p.Height / 2);//3:00
                    myPen.Width = 1;
                    for (int i = 1; i < verticalRoad_Left; i++)
                    {
                        int penPosition_Up = p.Height / 2 - horizontRoad_Up * 40;
                        int penPosition_Down = p.Height / 2 + horizontRoad_Down * 40;
                        while (penPosition_Up > 0)
                        {
                            e.Graphics.DrawLine(myPen, p.Width / 2 - i * 40, penPosition_Up, p.Width / 2 - i * 40, penPosition_Up - 30); //12:00
                            penPosition_Up = penPosition_Up - 50;
                        }
                        while (penPosition_Down < p.Height)
                        {
                            e.Graphics.DrawLine(myPen, p.Width / 2 - i * 40, penPosition_Down, p.Width / 2 - i * 40, penPosition_Down + 30); //9:00
                            penPosition_Down = penPosition_Down + 50;
                        }
                    }

                    for (int i = 1; i < verticalRoad_Right; i++)
                    {
                        int penPosition_Up = p.Height / 2 - horizontRoad_Up * 40;
                        int penPosition_Down = p.Height / 2 + horizontRoad_Down * 40;
                        while (penPosition_Up > 0)
                        {
                            e.Graphics.DrawLine(myPen, p.Width / 2 + i * 40, penPosition_Up, p.Width / 2 + i * 40, penPosition_Up - 30); //12:00
                            penPosition_Up = penPosition_Up - 50;
                        }
                        while (penPosition_Down < p.Height)
                        {
                            e.Graphics.DrawLine(myPen, p.Width / 2 + i * 40, penPosition_Down, p.Width / 2 + i * 40, penPosition_Down + 30); //9:00
                            penPosition_Down = penPosition_Down + 50;
                        }
                    }
                    for (int i = 1; i < horizontRoad_Up; i++)
                    {
                        int penPosition_Left = p.Width / 2 - verticalRoad_Left * 40;
                        int penPosition_Rihgt = p.Width / 2 + verticalRoad_Right * 40;
                        while (penPosition_Left > 0)
                        {
                            e.Graphics.DrawLine(myPen, penPosition_Left, p.Height / 2 - i * 40, penPosition_Left - 30, p.Height / 2 - i * 40); //12:00
                            penPosition_Left = penPosition_Left - 50;
                        }
                        while (penPosition_Rihgt < p.Width)
                        {
                            e.Graphics.DrawLine(myPen, penPosition_Rihgt, p.Height / 2 - i * 40, penPosition_Rihgt + 30, p.Height / 2 - i * 40); //9:00
                            penPosition_Rihgt = penPosition_Rihgt + 50;
                        }
                    }
                    for (int i = 1; i < horizontRoad_Down; i++)
                    {
                        int penPosition_Left = p.Width / 2 - verticalRoad_Left * 40;
                        int penPosition_Rihgt = p.Width / 2 + verticalRoad_Right * 40;
                        while (penPosition_Left > 0)
                        {
                            e.Graphics.DrawLine(myPen, penPosition_Left, p.Height / 2 + i * 40, penPosition_Left - 30, p.Height / 2 + i * 40); //12:00
                            penPosition_Left = penPosition_Left - 50;
                        }
                        while (penPosition_Rihgt < p.Width)
                        {
                            e.Graphics.DrawLine(myPen, penPosition_Rihgt, p.Height / 2 + i * 40, penPosition_Rihgt + 30, p.Height / 2 + i * 40); //9:00
                            penPosition_Rihgt = penPosition_Rihgt + 50;
                        }
                    }
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
