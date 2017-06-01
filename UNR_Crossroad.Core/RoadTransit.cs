using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNR_Crossroad.Core
{
    public class RoadTransit
    {
        public bool UpRoad { get; set; }
        public bool DownRoad { get; set; }
        public bool LeftRoad { get; set; }
        public bool RightRoad { get; set; }

        public int VerticalRoadLeft { get; set; }
        public int VerticalRoadRight { get; set; }
        public int HorizontRoadUp { get; set; }
        public int HorizontRoadDown { get; set; }

        private Pen _myPen;

        public RoadTransit(bool upRoad, bool downRoad, bool leftRoad, bool rightRoad, int vertLeft, int vertRight, int horUp, int horDown)
        {
            UpRoad = upRoad;
            DownRoad = downRoad;
            LeftRoad = leftRoad;
            RightRoad = rightRoad;
            _myPen = new Pen(Color.White, 10);

            VerticalRoadLeft = vertLeft;
            VerticalRoadRight = vertRight;
            HorizontRoadUp = horUp;
            HorizontRoadDown = horDown;
        }

        public void RenderRoadTransit(Panel p, PaintEventArgs e)
        {
            int width = 9;
            if (RightRoad)
            {
                int beginTransitLeft = p.Width / 2 + VerticalRoadRight * 40 + 5 * width;
                int beginTransitRight = p.Width / 2 + VerticalRoadRight * 40 + 11 * width;
                int beginTransitUp = p.Height / 2 - HorizontRoadUp * 40;
                int beginTransitDown = p.Height / 2 + HorizontRoadDown * 40;

                for (int i = beginTransitUp + 10; i < beginTransitDown; i = i + 10)
                {
                    e.Graphics.DrawLine(_myPen, beginTransitLeft, i, beginTransitRight, i);
                    i = i + 10;
                }
            }

            if (LeftRoad)
            {
                int beginTransitLeft = p.Width / 2 - VerticalRoadLeft * 40 - 5 * width;
                int beginTransitRight = p.Width / 2 - VerticalRoadLeft * 40 - 11 * width;
                int beginTransitUp = p.Height / 2 - HorizontRoadUp * 40;
                int beginTransitDown = p.Height / 2 + HorizontRoadDown * 40;

                for (int i = beginTransitUp + 10; i < beginTransitDown; i = i + 10)
                {
                    e.Graphics.DrawLine(_myPen, beginTransitLeft, i, beginTransitRight, i);
                    i = i + 10;
                }
            }

            if (UpRoad)
            {
                int beginTransitLeft = p.Width / 2 - VerticalRoadLeft * 40;
                int beginTransitRight = p.Width / 2 + VerticalRoadRight * 40;
                int beginTransitUp = p.Height / 2 - HorizontRoadUp * 40 - 11 * width;
                int beginTransitDown = p.Height / 2 - HorizontRoadUp * 40 - 5 * width;

                for (int i = beginTransitLeft + 10; i < beginTransitRight; i = i + 10)
                {
                    e.Graphics.DrawLine(_myPen, i, beginTransitUp, i, beginTransitDown);
                    i = i + 10;
                }
            }

            if (DownRoad)
            {
                int beginTransitLeft = p.Width / 2 - VerticalRoadLeft * 40;
                int beginTransitRight = p.Width / 2 + VerticalRoadRight * 40;
                int beginTransitUp = p.Height / 2 + HorizontRoadDown * 40 + 11 * width;
                int beginTransitDown = p.Height / 2 + HorizontRoadDown * 40 + 5 * width;

                for (int i = beginTransitLeft + 10; i < beginTransitRight; i = i + 10)
                {
                    e.Graphics.DrawLine(_myPen, i, beginTransitUp, i, beginTransitDown);
                    i = i + 10;
                }
            }

        }
    }
}
