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
                    Sprite.SpriteLibUp[sprite], sprite,
                    new Vector(0, -1), polosa + 1, Engine.CurrentRoad.VerticalRoadRight,
                    Engine.CurrentRoad.HorizontRoadUp, Side.Right, RoadPass.WhatIsTurn(polosa + 1, Engine.CurrentRoad.VerticalRoadRight)));
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
                Engine.Cars.Add(new Car(Engine.UserPanel.Width / 2 - 50 - polosa * 40, 0, 3, Sprite.SpriteLibDown[sprite], sprite,
                    new Vector(0, 1), polosa + 1,
                    Engine.CurrentRoad.VerticalRoadLeft, Engine.CurrentRoad.HorizontRoadDown, Side.Left, RoadPass.WhatIsTurn(polosa + 1, Engine.CurrentRoad.VerticalRoadLeft)));
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
                    Sprite.SpriteLibLeft[sprite], sprite,
                    new Vector(-1, 0), polosa + 1, Engine.CurrentRoad.HorizontRoadUp, Engine.CurrentRoad.VerticalRoadLeft, Side.Up, RoadPass.WhatIsTurn(polosa + 1, Engine.CurrentRoad.HorizontRoadUp)));
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
                Engine.Cars.Add(new Car(0, Engine.UserPanel.Height / 2 - 8 + polosa * 40, 3, Sprite.SpriteLibRight[sprite], sprite,
                    new Vector(1, 0), polosa + 1,
                    Engine.CurrentRoad.HorizontRoadDown, Engine.CurrentRoad.VerticalRoadRight, Side.Down, RoadPass.WhatIsTurn(polosa + 1, Engine.CurrentRoad.HorizontRoadDown)));
            }
        }

        public static void DownPeople()
        {
            int sprite = Engine.R.Next(0, 18);
            int pol = Engine.R.Next(0, 2);
            if (pol == 1)
            {
                Engine.Peoples.Add(new People(Engine.UserPanel.Width/2 - Engine.CurrentRoad.VerticalRoadLeft*40 - 80, Engine.UserPanel.Height/2 + Engine.CurrentRoad.HorizontRoadDown * 40 + 44, 8,
                    Sprite.SpriteLibRightPeople1[sprite], sprite, new Vector(1, 0), Side.Right));
            }
            else if (pol == 0)
            {
                Engine.Peoples.Add(new People(Engine.UserPanel.Width / 2 + Engine.CurrentRoad.VerticalRoadRight * 40 + 80, Engine.UserPanel.Height / 2 + Engine.CurrentRoad.HorizontRoadDown * 40 + 73, 8, Sprite.SpriteLibRightPeople1[sprite],sprite, new Vector(-1, 0), Side.Left));
            }
        }
        public static void UpPeople()
        {
            int sprite = Engine.R.Next(0, 18);
            int pol = Engine.R.Next(0, 2);
            if (pol == 1)
            {
                Engine.Peoples.Add(new People(Engine.UserPanel.Width / 2 - Engine.CurrentRoad.VerticalRoadLeft * 40 - 80, Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 72, 8,
                    Sprite.SpriteLibRightPeople1[sprite], sprite, new Vector(1, 0), Side.Right));
            }
            else if (pol == 0)
            {
                Engine.Peoples.Add(new People(Engine.UserPanel.Width / 2 + Engine.CurrentRoad.VerticalRoadRight * 40 + 80, Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 101, 8, Sprite.SpriteLibRightPeople1[sprite], sprite, new Vector(-1, 0), Side.Left));
            }
        }
        public static void RightPeople()
        {
            int sprite = Engine.R.Next(0, 18);
            int pol = Engine.R.Next(0, 2);
            if (pol == 1)
            {
                Engine.Peoples.Add(new People(Engine.UserPanel.Width / 2 + Engine.CurrentRoad.VerticalRoadRight * 40 + 44, Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 80, 8,
                    Sprite.SpriteLibRightPeople1[sprite], sprite, new Vector(0, 1), Side.Down));
            }
            else if (pol == 0)
            {
                Engine.Peoples.Add(new People(Engine.UserPanel.Width / 2 + Engine.CurrentRoad.VerticalRoadRight * 40 + 73, Engine.UserPanel.Height / 2 + Engine.CurrentRoad.HorizontRoadDown * 40 + 80, 8, Sprite.SpriteLibRightPeople1[sprite], sprite, new Vector(0, -1), Side.Up));
            }
        }
        public static void LeftPeople()
        {
            int sprite = Engine.R.Next(0, 18);
            int pol = Engine.R.Next(0, 2);
            if (pol == 1)
            {
                Engine.Peoples.Add(new People(Engine.UserPanel.Width / 2 - Engine.CurrentRoad.VerticalRoadLeft * 40 - 66, Engine.UserPanel.Height / 2 - Engine.CurrentRoad.HorizontRoadUp * 40 - 80, 8,
                    Sprite.SpriteLibRightPeople1[sprite], sprite, new Vector(0, 1), Side.Down));
            }
            else if (pol == 0)
            {
                Engine.Peoples.Add(new People(Engine.UserPanel.Width / 2 - Engine.CurrentRoad.VerticalRoadLeft * 40 - 95, Engine.UserPanel.Height / 2 + Engine.CurrentRoad.HorizontRoadDown * 40 + 80, 8, Sprite.SpriteLibRightPeople1[sprite], sprite, new Vector(0, -1), Side.Up));
            }
        }
    }
}
