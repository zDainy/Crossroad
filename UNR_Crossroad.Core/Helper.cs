using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UNR_Crossroad.Core
{
    public static class Helper 
    {
        private static string _user;
        private static string _pass;

        private static Bitmap bm;
        public static Bitmap DefaultSpriteRight { get; set; }
        public static Bitmap DefaultSpriteLeft { get; set; }
        public static Bitmap DefaultSpriteUp { get; set; }
        public static Bitmap DefaultSpriteDown { get; set; }

        public static void SetDefaultSprite()
        {
            bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
            DefaultSpriteUp = bm;
            bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
            bm.RotateFlip(RotateFlipType.Rotate90FlipNone);
            DefaultSpriteRight = bm;
            bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
            bm.RotateFlip(RotateFlipType.Rotate180FlipNone);
            DefaultSpriteDown = bm;
            bm = new Bitmap(Image.FromFile("img\\Car\\car1_blue.png"));
            bm.RotateFlip(RotateFlipType.Rotate270FlipNone);
            DefaultSpriteLeft = bm;
        }

        public static string EmptyCheck(string user, string pass)
        {
            _user = user;
            _pass = pass;
            if (_user == "")
            {
                return "Пустое имя пользователя";
            }
            if (_pass == "")
            {
                return "Пустой пароль";
            }
            return "OK";
        }
    }
}