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
    //Enums for the Adjacency types
    public enum RectangleAdjacency
    {
        Not_Adjacent,
        Adjacent_Partial,
        Adjacent_Proper,
        Adjacent_SubLine
    }

    public class RectangleAnalyzer
    {
        //Property that represents the First Rectangle
        public Rectangle FirstRectangle { get; set; }
        //Property that represents the second Rectangle
        public Rectangle SecondRectangle { get; set; }
        
        //Function that checks for intersection between First and Second Rectangle
        public bool CheckIntersection() 
        {
            //Calling the Drawing function to check if there is any resulting intersection rectangle and if it's not empty
            if (Rectangle.Intersect(FirstRectangle, SecondRectangle) != Rectangle.Empty)
            {
                return true;
            }
            return false;
        }

        //Function that checks for containment between First and Second Rectangle
        public bool CheckContainment() 
        {
            //Check first if the Width and Height of the First rectangle is bigger than the second
            if (FirstRectangle.Width > SecondRectangle.Width && FirstRectangle.Height > SecondRectangle.Height)
            {
                //Check for top and bottom validations for the First rectangle, since they must be bigger
                if (FirstRectangle.Top > SecondRectangle.Top && FirstRectangle.Bottom > SecondRectangle.Bottom) 
                {
                    //Check for Left and Right Validations, since them bust be lower and higher than the Second rectangle
                    if (FirstRectangle.Left < SecondRectangle.Left && FirstRectangle.Right > SecondRectangle.Right) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Function that checks for getting the adjacency type between First and Second Rectangle
        public RectangleAdjacency GetAdjacency() 
        {
            //Check first if the edges of first or second rectangle are touching each other
            if (FirstRectangle.Right == SecondRectangle.Left || FirstRectangle.Left == SecondRectangle.Right) 
            {
                //Check if the Top and Bottom values are the same, to check if its a proper adjacency
                if (FirstRectangle.Top == SecondRectangle.Top && FirstRectangle.Bottom == SecondRectangle.Bottom)
                {
                    return RectangleAdjacency.Adjacent_Proper;
                }
                //Check if the Top and Bottom values are bigger, so we can confirm that is a subline (Similar approach to containment)
                if (FirstRectangle.Top > SecondRectangle.Top && FirstRectangle.Bottom > SecondRectangle.Bottom)
                {
                    return RectangleAdjacency.Adjacent_SubLine;
                }
                //If is not any of the already mentioned adjacencies, then it's partial
                return RectangleAdjacency.Adjacent_Partial;
            }
            //If the edges are not touching, we don't have an adjacency at all
            return RectangleAdjacency.Not_Adjacent;
        }

    }
}
