using System.Diagnostics;
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
        public Side StartRoad { get; set; }
        public Side CurrRoad { get; set; }
        public CTurn Turn { get; set; }

        public Car(int x, int y, int speed, Bitmap sprite,int nspr, Vector dir, int polosa, int src, int frc, Side cr,CTurn ct)
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
            CurrRoad = cr;
        }

        public static int CanMove(Car c)
        {
            switch (c.StartRoad)
            {
                case Side.Down:
                    if ((Engine.TrafficLights[2].CurrLight == TrafficLight.Lights.Red || Engine.TrafficLights[2].CurrLight == TrafficLight.Lights.Yellow) &&
                        c.X <= Engine.UserPanel.Width/2 - Engine.CurrentRoad.VerticalRoadLeft*40 - 155 &&
                        c.X >= Engine.UserPanel.Width/2 - Engine.CurrentRoad.VerticalRoadLeft*40 - 160)
                        return 0;
                    if (Engine.TrafficLights[2].CurrLight == TrafficLight.Lights.Green)
                    {
                        return 3;
                    }
                    break;
                case Side.Up:
                    if ((Engine.TrafficLights[1].CurrLight == TrafficLight.Lights.Red || Engine.TrafficLights[1].CurrLight == TrafficLight.Lights.Yellow) &&
                        c.X >= Engine.UserPanel.Width / 2 + Engine.CurrentRoad.VerticalRoadRight * 40 + 97 &&
                        c.X <= Engine.UserPanel.Width / 2 + Engine.CurrentRoad.VerticalRoadRight * 40 + 102)
                        return 0;
                    if(Engine.TrafficLights[1].CurrLight == TrafficLight.Lights.Green)
                    {
                        return 3;
                    }
                    break;
                case Side.Left:
                    if ((Engine.TrafficLights[0].CurrLight == TrafficLight.Lights.Red || Engine.TrafficLights[0].CurrLight == TrafficLight.Lights.Yellow) &&
                        c.Y <= Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 155 &&
                        c.Y >= Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 160)
                        return 0;
                    if (Engine.TrafficLights[0].CurrLight == TrafficLight.Lights.Green)
                    {
                        return 3;
                    }
                    break;
                case Side.Right:
                    if ((Engine.TrafficLights[3].CurrLight == TrafficLight.Lights.Red || Engine.TrafficLights[3].CurrLight == TrafficLight.Lights.Yellow) &&
                        c.Y >= Engine.UserPanel.Height / 2 + Engine.CurrentRoad.HorizontRoadDown * 40 + 97 &&
                        c.Y <= Engine.UserPanel.Height / 2 + Engine.CurrentRoad.HorizontRoadDown * 40 + 102)
                        return 0;
                    if (Engine.TrafficLights[3].CurrLight == TrafficLight.Lights.Green)
                    {
                        return 3;
                    }
                    break;
            }
            return 3;
        }

        public static bool Check(Car c)
        {
            switch (c.CurrRoad)
            {
                case Side.Down:
                    if (!RoadPass.CenterFive(c) && Engine.Cars.Exists(
                        sc =>
                            sc.Y == c.Y &&
                            c.X + 60 >= sc.X && c.X + 10 <= sc.X) ||
                        (Engine.Peoples.Exists(
                            p => c.Y < p.Y + 40 && c.Y > p.Y - 40 && c.X + 60 >= p.X && c.X + 40 <= p.X) &&
                         c.X < Engine.UserPanel.Width/2 + Engine.CurrentRoad.VerticalRoadRight*40 + 100))
                        return true;
                    if (c.Turn == CTurn.Left && Engine.TrafficLights[1].CurrLight == TrafficLight.Lights.Green && c.X <= Engine.UserPanel.Width / 2 - 60 && c.X >= Engine.UserPanel.Width / 2 - 65)
                        return true;
                    if (c.Turn == CTurn.Right &&
                        c.X >= Engine.UserPanel.Width/2 - 50*(Engine.CurrentRoad.VerticalRoadLeft + 1) + 20 &&
                        c.X <= Engine.UserPanel.Width/2 - 50*Engine.CurrentRoad.VerticalRoadLeft - 25 &&
                        Engine.Cars.Exists(
                            sc =>
                                sc.X >= Engine.UserPanel.Width/2 - 50*Engine.CurrentRoad.VerticalRoadLeft &&
                                sc.X <= Engine.UserPanel.Width/2 - 50*(Engine.CurrentRoad.VerticalRoadLeft - 1) &&
                                sc.Y <= Engine.UserPanel.Height/2 + Engine.CurrentRoad.HorizontRoadDown*40 + 45 &&
                                sc.Y >= Engine.UserPanel.Height/2 + Engine.CurrentRoad.HorizontRoadDown*40 - 45 &&
                                sc != c))
                        return true;
                    break;
                case Side.Up:
                    if (!RoadPass.CenterFive(c) && Engine.Cars.Exists(
                        sc =>
                            sc.Y == c.Y &&
                            c.X - 60 <= sc.X && c.X - 10 >= sc.X) ||
                       ( Engine.Peoples.Exists(
                            p => c.Y < p.Y + 40 && c.Y > p.Y - 40 && c.X - 60 <= p.X && c.X - 40 >= p.X) && c.X > Engine.UserPanel.Width / 2 - Engine.CurrentRoad.VerticalRoadLeft * 40 - 100))
                        return true;
                    if (c.Turn == CTurn.Left && Engine.TrafficLights[1].CurrLight == TrafficLight.Lights.Green && c.X >= Engine.UserPanel.Width / 2 + 5 && c.X <= Engine.UserPanel.Width / 2 + 10)
                        return true;
                    if (c.Turn == CTurn.Right && c.X >= Engine.UserPanel.Width / 2 + 50 * (Engine.CurrentRoad.VerticalRoadRight - 1) &&
                                c.X <= Engine.UserPanel.Width / 2 + 50 * Engine.CurrentRoad.VerticalRoadRight - 45 &&
                        Engine.Cars.Exists(
                            sc =>
                                sc.X >= Engine.UserPanel.Width / 2 + 50 * (Engine.CurrentRoad.VerticalRoadRight - 2) &&
                                sc.X <= Engine.UserPanel.Width / 2 + 50 * (Engine.CurrentRoad.VerticalRoadRight - 1) &&
                                sc.Y <= Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 + 65 && 
                                sc.Y >= Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 65 &&
                                sc != c))
                        return true;
                    break;
                case Side.Right:
                    if (!RoadPass.CenterFive(c) && Engine.Cars.Exists(
                        sc =>
                            sc.X == c.X &&
                            c.Y - 60 <= sc.Y && c.Y - 10 >= sc.Y) ||
                      (  Engine.Peoples.Exists(
                            p => c.X < p.X + 40 && c.X > p.X - 40 && c.Y - 60 <= p.Y && c.Y - 40 >= p.Y) && c.Y > Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 100))
                        return true;
                    if (c.Turn == CTurn.Left && Engine.TrafficLights[3].CurrLight == TrafficLight.Lights.Green && c.Y  <= Engine.UserPanel.Height/2 + 15 && c.Y >= Engine.UserPanel.Height / 2 + 10)
                        return true;
                    if (c.Turn == CTurn.Right && c.Y >= Engine.UserPanel.Height / 2 + 50 * (Engine.CurrentRoad.HorizontRoadDown - 1) &&
                                c.Y <= Engine.UserPanel.Height / 2 + 50 * Engine.CurrentRoad.HorizontRoadDown - 45 &&
                        Engine.Cars.Exists(
                            sc =>
                                sc.Y >= Engine.UserPanel.Height/2 + 50*(Engine.CurrentRoad.HorizontRoadDown - 2) &&
                                sc.Y <= Engine.UserPanel.Height/2 + 50*(Engine.CurrentRoad.HorizontRoadDown - 1) &&
                                sc.X <= Engine.UserPanel.Width/2 + Engine.CurrentRoad.VerticalRoadRight*40 + 45 &&
                                sc.X >= Engine.UserPanel.Width/2 + Engine.CurrentRoad.VerticalRoadRight*40 - 45 &&
                                sc != c)) 
                        return true;
                    break;
                case Side.Left:
                    if (!RoadPass.CenterFive(c) && Engine.Cars.Exists(
                        sc =>
                            sc.X == c.X &&
                            c.Y + 60 >= sc.Y && c.Y + 10 <= sc.Y) ||
                       ( Engine.Peoples.Exists(
                            p => c.X < p.X + 40 && c.X > p.X - 40 && c.Y + 60 >= p.Y && c.Y + 40 <= p.Y) && c.Y < Engine.UserPanel.Height / 2 + Engine.CurrentRoad.HorizontRoadUp * 40 + 100))
                        return true;
                    if (c.Turn == CTurn.Left && Engine.TrafficLights[3].CurrLight == TrafficLight.Lights.Green && c.Y <= Engine.UserPanel.Height / 2 - 55 && c.Y >= Engine.UserPanel.Height / 2 - 60)
                        return true;
                    if (c.Turn == CTurn.Right  && c.Y >= Engine.UserPanel.Height / 2 - 50 * (Engine.CurrentRoad.HorizontRoadDown + 1) + 20 &&
                                c.Y <= Engine.UserPanel.Height / 2 - 50 * Engine.CurrentRoad.HorizontRoadDown - 25 &&
                       Engine.Cars.Exists(
                           sc =>
                               sc.Y >= Engine.UserPanel.Height / 2 - 50 * (Engine.CurrentRoad.HorizontRoadUp) &&
                               sc.Y <= Engine.UserPanel.Height / 2 - 50 * (Engine.CurrentRoad.HorizontRoadUp-1) &&
                               sc.X <= Engine.UserPanel.Width / 2 - Engine.CurrentRoad.VerticalRoadLeft * 40 + 45 &&
                               sc.X >= Engine.UserPanel.Width / 2 - Engine.CurrentRoad.VerticalRoadLeft * 40 - 80 &&
                               sc != c))
                        return true;
                    break;
            }
            return false;
        }
    }
}
