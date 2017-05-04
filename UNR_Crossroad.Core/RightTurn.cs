
namespace UNR_Crossroad.Core
{
    public class RightTurn : Turn
    {

        public override void StartTurn(Car c)
        {
            int t = CheckLanes(c.Polosa, c.StartRoadCount, c.FinishRoadCount);
            switch (c.StartRoad)
            {
                case CRoad.Right:
                    if (c.X <= Engine.UserPanel.Width / 2 + 40 * (t + c.StartRoadCount - c.FinishRoadCount) && c.X >= Engine.UserPanel.Width / 2 - 40 * (t + 2) - 17 &&
                        c.Y >= Engine.UserPanel.Height / 2 - 40 * t - 6 &&
                        c.Y <= Engine.UserPanel.Height / 2 + 40 * t)
                    {
                        c.Speed = 1;
                        PovorotR(c);
                    }
                    break;
                case CRoad.Down:
                    if (c.X <= Engine.UserPanel.Width / 2 + 40 * t && c.X >= Engine.UserPanel.Width / 2 - 40 * (t + 1) - 17 &&
                        c.Y >= Engine.UserPanel.Height / 2 - 40 * t - 6 &&
                        c.Y <= Engine.UserPanel.Height / 2 + 40 * (t + c.StartRoadCount - c.FinishRoadCount))
                    {
                        c.Speed = 1;
                        PovorotD(c);
                    }
                    break;
                case CRoad.Left:
                    if (c.X <= Engine.UserPanel.Width / 2 + 40 * (t + c.StartRoadCount - c.FinishRoadCount) && c.X >= Engine.UserPanel.Width / 2 - 40 * (t + 4) - 17 &&
                        c.Y >= Engine.UserPanel.Height / 2 - 40 * t - 56 &&
                        c.Y <= Engine.UserPanel.Height / 2 + 40 * t)
                    {
                        c.Speed = 1;
                        PovorotL(c);
                    }
                    break;
                case CRoad.Up:
                    if (c.X <= Engine.UserPanel.Width / 2 + 40 * t && c.X >= Engine.UserPanel.Width / 2 - 40 * (t + 4) - 17 &&
                        c.Y >= Engine.UserPanel.Height / 2 - 40 * t - 206 &&
                        c.Y <= Engine.UserPanel.Height / 2 + 40 * (t + c.StartRoadCount - c.FinishRoadCount))
                    {
                        c.Speed = 1;
                        PovorotU(c);
                    }
                    break;
            }
        }

        public override void PovorotU(Car c)
        {
            c.Direct = new Vector(c.Direct.X - 0.007, c.Direct.Y - 0.12);
            c.Y += (int)c.Direct.Y * c.Speed;
            c.X += (int)c.Direct.X * c.Speed;
            if (!(c.Y <= Engine.UserPanel.Height / 2 - 40 * c.Polosa - 50))
            {
                c.Sprite = RotateImage(c.Sprite, 3);
            }
            else
            {
                c.Speed = 3;
                c.Direct = new Vector(0, -1);
                c.Sprite = CarSprite.SpriteLibUp[c.NSprite];
            }
        }

        public override void PovorotL(Car c)
        {
            c.Direct = new Vector(c.Direct.X - 0.12, c.Direct.Y + 0.007);
            c.Y += (int)c.Direct.Y * c.Speed;
            c.X += (int)c.Direct.X * c.Speed;
            if (!(c.X <= Engine.UserPanel.Width / 2 - 40 * c.Polosa - 50))
            {
                c.Sprite = RotateImage(c.Sprite, 3);
            }
            else
            {
                c.Speed = 3;
                c.Direct = new Vector(-1, 0);
                c.Sprite = CarSprite.SpriteLibLeft[c.NSprite];
            }
        }

        public override void PovorotD(Car c)
        {
            c.Direct = new Vector(c.Direct.X + 0.007, c.Direct.Y + 0.12);
            c.Y += (int)c.Direct.Y * c.Speed;
            c.X += (int)c.Direct.X * c.Speed;
            if (!(c.Y >= Engine.UserPanel.Height / 2 + 40 * c.Polosa - 2))
            {
                c.Sprite = RotateImage(c.Sprite, 3);
            }
            else
            {
                c.Speed = 3;
                c.Direct = new Vector(0, 1);
                c.Sprite = CarSprite.SpriteLibDown[c.NSprite];
            }
        }

        public override void PovorotR(Car c)
        {
            c.Direct = new Vector(c.Direct.X + 0.12, c.Direct.Y - 0.007);
            c.Y += (int)c.Direct.Y * c.Speed;
            c.X += (int)c.Direct.X * c.Speed;
            if (!(c.X >= Engine.UserPanel.Width / 2 + 40 * c.Polosa))
            {
                c.Sprite = RotateImage(c.Sprite, 3);
            }
            else
            {
                c.Speed = 3;
                c.Direct = new Vector(1, 0);
                c.Sprite = CarSprite.SpriteLibRight[c.NSprite];
            }
        }

        public override int CheckLanes(int polosa, int start, int finish)
        {
            if (finish < start && polosa >= start + (finish - start) + 1)
            {
                return finish;
            }
            if (finish > start)
            {
                return polosa + finish - start;
            }
            return polosa;
        }
    }
}
