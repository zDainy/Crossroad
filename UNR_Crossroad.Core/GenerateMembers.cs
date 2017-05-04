using System;
using System.Drawing;

namespace UNR_Crossroad.Core
{
    public static class GenerateMembers
    {
        public static void VerticalRightCar()
        {
            int polosa = Engine.R.Next(0, Engine.CurrentRoad.VerticalRoadRight);
            int sprite = Engine.R.Next(0, 42);
            if (
                !Engine.Cars.Exists(
                    c =>
                        c.X >= Engine.UserPanel.Width / 2 + 50 * (polosa - 1) &&
                        c.X <= Engine.UserPanel.Width / 2 + 50 * polosa &&
                        c.Y + 70 >= Engine.UserPanel.Height))
            {
                Engine.Cars.Add(new Car(Engine.UserPanel.Width / 2 - 8 + polosa * 40, Engine.UserPanel.Height, 3,
                    CarSprite.SpriteLibUp[sprite], sprite,
                    new Vector(0, -1), polosa + 1, Engine.CurrentRoad.VerticalRoadRight,
                    Engine.CurrentRoad.HorizontRoadUp, CRoad.Right, CTurn.Left));
            }
        }

        public static void VerticalLeftCar()
        {
            int polosa = Engine.R.Next(0, Engine.CurrentRoad.VerticalRoadLeft);
            int sprite = Engine.R.Next(0, 42);
            if (
                !Engine.Cars.Exists(
                    c =>
                        c.X >= Engine.UserPanel.Width / 2 - 50 * (polosa + 1) && c.X <= Engine.UserPanel.Width / 2 - 50 * polosa &&
                        c.Y - 70 <= 0))
            {
                Engine.Cars.Add(new Car(Engine.UserPanel.Width / 2 - 50 - polosa * 40, 0, 3, CarSprite.SpriteLibDown[sprite], sprite,
                    new Vector(0, 1), polosa + 1,
                    Engine.CurrentRoad.VerticalRoadLeft, Engine.CurrentRoad.HorizontRoadDown, CRoad.Left, CTurn.Left));
            }
        }

        public static void HorizontalUpCar()
        {
            int polosa = Engine.R.Next(0, Engine.CurrentRoad.HorizontRoadUp);
            int sprite = Engine.R.Next(0, 42);
            if (
                !Engine.Cars.Exists(
                    c =>
                        c.Y >= Engine.UserPanel.Height / 2 - 50 * (polosa + 1) &&
                        c.Y <= Engine.UserPanel.Height / 2 - 50 * polosa &&
                        c.X + 70 >= Engine.UserPanel.Width))
            {
                Engine.Cars.Add(new Car(Engine.UserPanel.Width, Engine.UserPanel.Height / 2 - 50 - polosa * 40, 3,
                    CarSprite.SpriteLibLeft[sprite], sprite,
                    new Vector(-1, 0), polosa + 1, Engine.CurrentRoad.HorizontRoadUp, Engine.CurrentRoad.VerticalRoadLeft, CRoad.Up, CTurn.Left));
            }
        }

        public static void HorizontalDownCar()
        {
            int polosa = Engine.R.Next(0, Engine.CurrentRoad.HorizontRoadDown);
            int sprite = Engine.R.Next(0, 42);
            if (!Engine.Cars.Exists(
                c =>
                    c.Y >= Engine.UserPanel.Height / 2 + 50 * (polosa - 1) && c.Y <= Engine.UserPanel.Height / 2 + 50 * polosa &&
                    c.X - 70 <= 0))
            {
                Engine.Cars.Add(new Car(0, Engine.UserPanel.Height / 2 - 8 + polosa * 40, 3, CarSprite.SpriteLibRight[sprite], sprite,
                    new Vector(1, 0), polosa + 1,
                    Engine.CurrentRoad.HorizontRoadDown, Engine.CurrentRoad.VerticalRoadRight, CRoad.Down, CTurn.Left));
            }
        }
    }
}
