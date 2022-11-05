using Rectangles;
using System.Drawing;

namespace RectanglesTest
{
    public class RectanglesTests
    {
        [Fact]
        public void RectangleCreationTest()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 4, 6, 4);
            rectAnalyzer.SecondRectangle = new Rectangle(4, 3, 5, 2);
            Assert.False(rectAnalyzer.FirstRectangle.IsEmpty);
            Assert.False(rectAnalyzer.FirstRectangle.IsEmpty);
        }

        [Fact]
        public void RectangleIntersection()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 4, 6, 4);
            rectAnalyzer.SecondRectangle = new Rectangle(4, 3, 5, 2);
            Assert.True(rectAnalyzer.CheckIntersection());
        }

        [Fact]
        public void RectangleNoIntersection()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 3, 5, 3);
            rectAnalyzer.SecondRectangle = new Rectangle(6, 3, 5, 3);
            Assert.False(rectAnalyzer.CheckIntersection());
        }

        [Fact]
        public void RectangleContainment()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 4, 6, 4);
            rectAnalyzer.SecondRectangle = new Rectangle(1, 3, 4, 2);
            Assert.True(rectAnalyzer.CheckContainment());
        }

        [Fact]
        public void RectangleNoContainment()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 3, 5, 3);
            rectAnalyzer.SecondRectangle = new Rectangle(6, 3, 5, 3);
            Assert.False(rectAnalyzer.CheckContainment());
        }

        [Fact]
        public void RectangleIntersectionNoContainment()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 4, 6, 4);
            rectAnalyzer.SecondRectangle = new Rectangle(4, 3, 6, 2);
            Assert.True(rectAnalyzer.CheckIntersection());
            Assert.False(rectAnalyzer.CheckContainment());
        }

        [Fact]
        public void RectangleAdjacentSubline()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 4, 6, 4);
            rectAnalyzer.SecondRectangle = new Rectangle(6, 3, 4, 2);
            Assert.True(rectAnalyzer.GetAdjacency() == RectangleAdjacency.Adjacent_SubLine);
        }

        [Fact]
        public void RectangleAdjacentProper()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 4, 6, 4);
            rectAnalyzer.SecondRectangle = new Rectangle(6, 4, 3, 4);
            Assert.True(rectAnalyzer.GetAdjacency() == RectangleAdjacency.Adjacent_Proper);
        }

        [Fact]
        public void RectangleAdjacentPartial()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 4, 6, 4);
            rectAnalyzer.SecondRectangle = new Rectangle(6, 6, 6, 5);
            Assert.True(rectAnalyzer.GetAdjacency() == RectangleAdjacency.Adjacent_Partial);
        }

        [Fact]
        public void RectangleNoAdjacent()
        {
            RectangleAnalyzer rectAnalyzer = new RectangleAnalyzer();
            rectAnalyzer.FirstRectangle = new Rectangle(0, 4, 6, 4);
            rectAnalyzer.SecondRectangle = new Rectangle(4, 3, 6, 2);
            Assert.True(rectAnalyzer.GetAdjacency() == RectangleAdjacency.Not_Adjacent);
        }

    }
}