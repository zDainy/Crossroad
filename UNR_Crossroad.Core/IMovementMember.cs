using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UNR_Crossroad.Core
{
    public interface IMovementMember
    {
        int X { get; set; }
        int Y { get; set; }
        int Speed { get; set; }
        Bitmap Sprite { get; set; }
        Vector Direct { get; set; }
        
    }

    public enum Side
    {
        Right, Left, Up, Down
    }

    public enum CTurn
    {
        Right, Left, No
    }
}
