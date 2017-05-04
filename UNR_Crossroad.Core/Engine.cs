using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace UNR_Crossroad.Core
{
    public static class Engine
    {
        public static List<Car> Cars { get; set; }
        public static bool IsReady { get; set; }
        public static List<Car> Deleter { get; set; }
        public static Random R { get; set; }
        public static Road CurrentRoad { get; set; }
        public static Timer GenTimer { get; set; }
        public static Timer MoveTimer { get; set; }
        public static Timer WorkTimer { get; set; }
        public static Panel UserPanel { get; set; }
        public static RightTurn RightTurn { get; set; }
        public static LeftTurn LeftTurn { get; set; }
        public static TextBox CarCount { get; set; }
        public static TextBox CurrentlyCarCount { get; set; }
        public static TextBox WorkTime { get; set; }
        public static TextBox Cpm { get; set; }
        public static int WorkTm { get; set; }
        

        public static void Start()
        {
            MoveTimer.Start();
            GenTimer.Start();
            WorkTimer.Start();
        }

        public static void Pause()
        {
            MoveTimer.Stop();
            GenTimer.Stop();
            WorkTimer.Stop();
        }
        public static void Stop()
        {
            Cars.Clear();
            Deleter.Clear();
            MoveTimer.Stop();
            GenTimer.Stop();
            WorkTimer.Stop();
            CarCount.Text= "0";
            CurrentlyCarCount.Text = "0";
            WorkTime.Text = "0 c";
            Cpm.Text = "0";
            WorkTm = 0;
            UserPanel.ResetBackColor();
            UserPanel.Invalidate();
        }

        public static void Initialization()
        {
            CurrentRoad = new Road(4, 4, 4, 4);
            Cars = new List<Car>();
            Deleter = new List<Car>();
            R = new Random();
            RightTurn = new RightTurn();
            LeftTurn = new LeftTurn();
            MoveTimer = new Timer { Interval = 10 };
            MoveTimer.Tick += (sender, e) => Move_Tick();
            GenTimer = new Timer { Interval = 100 };
            GenTimer.Tick += (sender, e) => GenerateMembers_Tick();
            WorkTimer = new Timer {Interval = 1000};
            WorkTimer.Tick += (sender, e) => Work_tick();
        }

        public static void Work_tick()
        {
            WorkTm++;
            WorkTime.Text = WorkTm + " c";
            Cpm.Text = Math.Round(Convert.ToDouble(CarCount.Text) * (60/ (double)WorkTm)).ToString(CultureInfo.InvariantCulture);
        }

        public static void Move_Tick()
        {
            CurrentlyCarCount.Text = Cars.Count.ToString();
            foreach (var c in Cars)
            {
                if (c.Turn == CTurn.Right)
                {
                    RightTurn.StartTurn(c);
                }

                if (c.Turn == CTurn.Left)
                {
                    LeftTurn.StartTurn(c);
                }
                Move(c);
                if (c.X < -50 || c.X > UserPanel.Width + 50 || c.Y < -50 || c.Y > UserPanel.Height + 50)
                {
                    Deleter.Add(c);
                }
            }
            if (Deleter.Count != 0)
            {
                foreach (var c in Deleter)
                {
                    Cars.Remove(c);
                }
            }
            UserPanel.Invalidate();
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
                CurrentRoad.RenderRoad(sender as Panel, e);
                foreach (var c in Cars)
                {
                    e.Graphics.DrawImage(c.Sprite, new Point(c.X, c.Y));
                }
            }
        }


        public static void GenerateMembers_Tick()
        {
            CarCount.Text = (Convert.ToInt32(CarCount.Text) + 1).ToString();
            switch (R.Next(1, 5))
            {
                case 1:
                    GenerateMembers.VerticalLeftCar();
                    break;
                case 2:
                    GenerateMembers.VerticalRightCar();
                    break;
                case 3:
                    GenerateMembers.HorizontalUpCar();
                    break;
                case 4:
                    GenerateMembers.HorizontalDownCar();
                    break;
            }
        }
    }
}
