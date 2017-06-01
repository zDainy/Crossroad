using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNR_Crossroad.Core
{
    public class People : IMovementMember
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public Bitmap Sprite { get; set; }
        public int NSprite { get; set; }
        public Vector Direct { get; set; }
        public Side Pside { get; set; }
        public bool IsRightLeg { get; set; }


        public People(int x, int y, int speed, Bitmap sprite,int ns, Vector dir, Side cr)
        {
            X = x;
            Y = y;
            Speed = speed;
            Sprite = sprite;
            Direct = dir;
            Pside = cr;
            IsRightLeg = true;
            NSprite = ns;
        }

        public static void ChangeLeg(People p)
        {
            switch (p.Pside)
            {
                case Side.Right:
                    p.Sprite = p.IsRightLeg ? Core.Sprite.SpriteLibRightPeople2[p.NSprite] : Core.Sprite.SpriteLibRightPeople1[p.NSprite];
                    p.IsRightLeg = !p.IsRightLeg;
                    break;
                case Side.Left:
                    p.Sprite = p.IsRightLeg ? Core.Sprite.SpriteLibLeftPeople2[p.NSprite] : Core.Sprite.SpriteLibLeftPeople1[p.NSprite];
                    p.IsRightLeg = !p.IsRightLeg;
                    break;
                case Side.Up:
                    p.Sprite = p.IsRightLeg ? Core.Sprite.SpriteLibUpPeople2[p.NSprite] : Core.Sprite.SpriteLibUpPeople1[p.NSprite];
                    p.IsRightLeg = !p.IsRightLeg;
                    break;
                case Side.Down:
                    p.Sprite = p.IsRightLeg ? Core.Sprite.SpriteLibDownPeople2[p.NSprite] : Core.Sprite.SpriteLibDownPeople1[p.NSprite];
                    p.IsRightLeg = !p.IsRightLeg;
                    break;
            }
        }
    }
}
