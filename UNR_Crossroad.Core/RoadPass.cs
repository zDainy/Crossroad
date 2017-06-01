using System.Collections;
using System.Collections.Generic;

namespace UNR_Crossroad.Core
{
    public static class RoadPass
    {
        public static CTurn WhatIsTurn(int pol,int maxpol)
        {
            if (maxpol == 4 || maxpol == 3 || maxpol == 2)
            {
                if (pol == maxpol)
                {
                    int r = Engine.R.Next(0, 2);
                    return r == 0 ? CTurn.Right : CTurn.No;
                }
                if (pol == 1)
                {
                    int r = Engine.R.Next(0, 2);
                    return r == 0 ? CTurn.Left : CTurn.No;
                }
                return CTurn.No;
            }
            int rr = Engine.R.Next(0, 3);
            switch (rr)
            {
                case 0:
                    return CTurn.Left;
                case 1:
                    return  CTurn.Right;
                case 2: 
                    return CTurn.No;
            }
            return CTurn.No;
        }

        public static bool CenterFive(Car c)
        {
            return c.Y <= Engine.UserPanel.Height/2 + 40 && c.Y >= Engine.UserPanel.Height / 2 - 40 && c.X <= Engine.UserPanel.Width / 2 + 40 && c.X >= Engine.UserPanel.Width / 2 - 40;
        }
    }
    
}