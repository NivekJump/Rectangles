using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    public enum RectangleAdjacency
    {
        Not_Adjacent,
        Adjacent_Partial,
        Adjacent_Proper,
        Adjacent_SubLine
    }

    public class RectangleAnalyzer
    {
        public Rectangle FirstRectangle { get; set; }
        public Rectangle SecondRectangle { get; set; }
        
        public bool CheckIntersection() 
        {
            if (Rectangle.Intersect(FirstRectangle, SecondRectangle) != Rectangle.Empty)
            {
                return true;
            }
            return false;
        }

        public bool CheckContainment() 
        {
            if (FirstRectangle.Width > SecondRectangle.Width && FirstRectangle.Height > SecondRectangle.Height)
            {
                if (FirstRectangle.Top > SecondRectangle.Top && FirstRectangle.Bottom > SecondRectangle.Bottom) 
                {
                    if (FirstRectangle.Left < SecondRectangle.Left && FirstRectangle.Right > SecondRectangle.Right) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public RectangleAdjacency GetAdjacency() 
        {
            if (FirstRectangle.Right == SecondRectangle.Left || FirstRectangle.Left == SecondRectangle.Right) 
            {
                if (FirstRectangle.Top == SecondRectangle.Top && FirstRectangle.Bottom == SecondRectangle.Bottom)
                {
                    return RectangleAdjacency.Adjacent_Proper;
                }
                if (FirstRectangle.Top > SecondRectangle.Top && FirstRectangle.Bottom > SecondRectangle.Bottom)
                {
                    return RectangleAdjacency.Adjacent_SubLine;
                }
                return RectangleAdjacency.Adjacent_Partial;
            }
            return RectangleAdjacency.Not_Adjacent;
        }

    }
}
