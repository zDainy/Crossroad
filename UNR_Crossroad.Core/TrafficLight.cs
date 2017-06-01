using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UNR_Crossroad.Core
{
    public class TrafficLight
    {
        public Point Place { get; set; }
        public Lights CurrLight { get; set; }
        public Lights NextLight { get; set; }
        public int CurrInterval { get; set; }
        public Osb LightOsb { get; set; }

        public TrafficLight(Point pl, Lights lights, int interval, Osb osb)
        {
            Place = pl;
            CurrLight = lights;
            CurrInterval = interval;
            NextLight = CurrLight == Lights.Green ? Lights.Red : Lights.Green;
            LightOsb = osb;
        }

        public static void CreateLight()
        {
                Engine.TrafficLights[0] = new TrafficLight(new Point(Engine.UserPanel.Width / 2 - Engine.CurrentRoad.VerticalRoadLeft * 40 - 40, Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 215), Lights.Green,
                Engine.LightsInterval1, Osb.Up);
                Engine.TrafficLights[1] = new TrafficLight(new Point(Engine.UserPanel.Width / 2 + Engine.CurrentRoad.VerticalRoadRight * 40 + 114, Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 40), Lights.Red,
                Engine.LightsInterval1, Osb.Left);
                Engine.TrafficLights[2] = new TrafficLight(new Point(Engine.UserPanel.Width / 2 - Engine.CurrentRoad.VerticalRoadLeft * 40 - 215, Engine.UserPanel.Height / 2 + Engine.CurrentRoad.HorizontRoadDown * 40), Lights.Red,
                Engine.LightsInterval1, Osb.Right);
                Engine.TrafficLights[3] = new TrafficLight(new Point(Engine.UserPanel.Width / 2 + Engine.CurrentRoad.VerticalRoadRight * 40, Engine.UserPanel.Height / 2 + Engine.CurrentRoad.HorizontRoadDown * 40 + 114), Lights.Green,
                Engine.LightsInterval1, Osb.Down);
        }

        public static void RenderLight(TrafficLight tl, Panel p, PaintEventArgs e)
        {
            switch (tl.CurrLight)
            {
                case Lights.Red:
                    e.Graphics.DrawImage(ChoosenLight(tl.LightOsb, 0), tl.Place);
                    break;
                case Lights.Yellow:
                    e.Graphics.DrawImage(ChoosenLight(tl.LightOsb, 1), tl.Place);
                    break;
                case Lights.Green:
                    e.Graphics.DrawImage(ChoosenLight(tl.LightOsb, 2), tl.Place);
                    break;
            }
            
        }

        public static Bitmap ChoosenLight(Osb l, int i)
        {
            switch (l)
            {
                case Osb.Up:
                    return Sprite.SpriteLibUpLights[i];
                case Osb.Right:
                    return Sprite.SpriteLibLeftLights[i];
                case Osb.Down:
                    return Sprite.SpriteLibDownLights[i];
                case Osb.Left:
                    return Sprite.SpriteLibRightLights[i];
            }
            return Sprite.SpriteLibUpLights[i];
        }

        public static void SwitchLight()
        {
            foreach (var light in Engine.TrafficLights)
            {
                switch (light.CurrLight)
                {
                    case Lights.Red:
                        Engine.LightsTimer.Interval = 3000;
                        light.CurrLight = Lights.Yellow;
                        break;
                    case Lights.Yellow:
                        light.CurrInterval = light.CurrInterval == Engine.LightsInterval1 ? Engine.LightsInterval2 : Engine.LightsInterval1;
                        Engine.LightsTimer.Interval = light.CurrInterval;
                        light.CurrLight = light.NextLight;
                        light.NextLight = light.NextLight == Lights.Green ? Lights.Red : Lights.Green;
                        break;
                    case Lights.Green:
                        Engine.LightsTimer.Interval = 3000;
                        light.CurrLight = Lights.Yellow;
                        break;
                }
            }
        }

        public static void Clear()
        {
            for (int i = 0; i < Engine.TrafficLights.Length; i++)
            {
                Engine.TrafficLights[i] = null;
            }
        }

        public enum Lights
        {
            Red, Yellow, Green
        }
        public enum Osb
        {
            Up, Down, Left, Right
        }
    }
}