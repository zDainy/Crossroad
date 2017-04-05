using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace UNR_Crossroad.Core
{
    public class Road
    {
        public int VerticalRoadLeft { get; set; }
        public int VerticalRoadRight { get; set; }
        public int HorizontRoadUp { get; set; }
        public int HorizontRoadDown { get; set; }
        private Pen _myPen;

        public Road(int vertLeft, int vertRight,int horUp,int horDown)
        {
            VerticalRoadLeft = vertLeft;
            VerticalRoadRight = vertRight;
            HorizontRoadUp = horUp;
            HorizontRoadDown = horDown;
        }

        public void RenderRoad(Panel p, PaintEventArgs e)
        {
            _myPen = new Pen(Color.FromArgb(64, 64, 64), 1);

            _myPen.Width = VerticalRoadLeft * 40;
            e.Graphics.DrawLine(_myPen, p.Width / 2 - _myPen.Width / 2, 0, p.Width / 2 - _myPen.Width / 2, p.Height);
            _myPen.Width = VerticalRoadRight * 40;
            e.Graphics.DrawLine(_myPen, p.Width / 2 + _myPen.Width / 2, 0, p.Width / 2 + _myPen.Width / 2, p.Height);
            _myPen.Width = HorizontRoadUp * 40;
            e.Graphics.DrawLine(_myPen, 0, p.Height / 2 - _myPen.Width / 2, p.Width, p.Height / 2 - _myPen.Width / 2);
            _myPen.Width = HorizontRoadDown * 40;
            e.Graphics.DrawLine(_myPen, 0, p.Height / 2 + _myPen.Width / 2, p.Width, p.Height / 2 + _myPen.Width / 2);

            _myPen.Color = Color.White;

            _myPen.Width = 2;
            e.Graphics.DrawLine(_myPen, p.Width / 2, 0, p.Width / 2, p.Height / 2 - HorizontRoadUp * 40); //12:00 
            e.Graphics.DrawLine(_myPen, p.Width / 2, p.Height / 2 + HorizontRoadDown * 40, p.Width / 2, p.Height); //6:00
            e.Graphics.DrawLine(_myPen, 0, p.Height / 2, p.Width / 2 - VerticalRoadLeft * 40, p.Height / 2); //9:00
            e.Graphics.DrawLine(_myPen, p.Width / 2 + VerticalRoadRight * 40, p.Height / 2, p.Width, p.Height / 2);//3:00
            _myPen.Width = 1;
            for (int i = 1; i < VerticalRoadLeft; i++)
            {
                int penPositionUp = p.Height / 2 - HorizontRoadUp * 40;
                int penPositionDown = p.Height / 2 + HorizontRoadDown * 40;
                while (penPositionUp > 0)
                {
                    e.Graphics.DrawLine(_myPen, p.Width / 2 - i * 40, penPositionUp, p.Width / 2 - i * 40, penPositionUp - 30); //12:00
                    penPositionUp = penPositionUp - 50;
                }
                while (penPositionDown < p.Height)
                {
                    e.Graphics.DrawLine(_myPen, p.Width / 2 - i * 40, penPositionDown, p.Width / 2 - i * 40, penPositionDown + 30); //9:00
                    penPositionDown = penPositionDown + 50;
                }
            }

            for (int i = 1; i < VerticalRoadRight; i++)
            {
                int penPositionUp = p.Height / 2 - HorizontRoadUp * 40;
                int penPositionDown = p.Height / 2 + HorizontRoadDown * 40;
                while (penPositionUp > 0)
                {
                    e.Graphics.DrawLine(_myPen, p.Width / 2 + i * 40, penPositionUp, p.Width / 2 + i * 40, penPositionUp - 30); //12:00
                    penPositionUp = penPositionUp - 50;
                }
                while (penPositionDown < p.Height)
                {
                    e.Graphics.DrawLine(_myPen, p.Width / 2 + i * 40, penPositionDown, p.Width / 2 + i * 40, penPositionDown + 30); //9:00
                    penPositionDown = penPositionDown + 50;
                }
            }
            for (int i = 1; i < HorizontRoadUp; i++)
            {
                int penPositionLeft = p.Width / 2 - VerticalRoadLeft * 40;
                int penPositionRihgt = p.Width / 2 + VerticalRoadRight * 40;
                while (penPositionLeft > 0)
                {
                    e.Graphics.DrawLine(_myPen, penPositionLeft, p.Height / 2 - i * 40, penPositionLeft - 30, p.Height / 2 - i * 40); //12:00
                    penPositionLeft = penPositionLeft - 50;
                }
                while (penPositionRihgt < p.Width)
                {
                    e.Graphics.DrawLine(_myPen, penPositionRihgt, p.Height / 2 - i * 40, penPositionRihgt + 30, p.Height / 2 - i * 40); //9:00
                    penPositionRihgt = penPositionRihgt + 50;
                }
            }
            for (int i = 1; i < HorizontRoadDown; i++)
            {
                int penPositionLeft = p.Width / 2 - VerticalRoadLeft * 40;
                int penPositionRihgt = p.Width / 2 + VerticalRoadRight * 40;
                while (penPositionLeft > 0)
                {
                    e.Graphics.DrawLine(_myPen, penPositionLeft, p.Height / 2 + i * 40, penPositionLeft - 30, p.Height / 2 + i * 40); //12:00
                    penPositionLeft = penPositionLeft - 50;
                }
                while (penPositionRihgt < p.Width)
                {
                    e.Graphics.DrawLine(_myPen, penPositionRihgt, p.Height / 2 + i * 40, penPositionRihgt + 30, p.Height / 2 + i * 40); //9:00
                    penPositionRihgt = penPositionRihgt + 50;
                }
            }
        }
    }
}
