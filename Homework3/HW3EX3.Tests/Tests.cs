namespace HW3EX3.Tests
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HW3EX3;
    using HW3EX3.Utilities;

    public class Tests
    {
        [TestClass]
        public class CalculateAreaShouldReturn
        {
            [TestMethod]
            public void SixFor2X3Rectangle()
            {
                var myRectangle = new Rectangle { Height = 2, Width = 3 };
                Assert.AreEqual(6, AreaCalculator.CalculateArea(myRectangle));
            }

            [TestMethod]
            public void NineFor3X3Square()
            {
                /*
                    Changed Height to SideLength for the square.
                    https://thinkdotnet.wordpress.com/2017/05/25/liskov-substitution-principle/
                    // In this case height equals 5 overwrites also width and as a result we get area is 25 instead of 20.
                */

                // var mySquare = new Square() { Height = 3 };
                var mySquare = new Square() { SideLength = 3 };
                Assert.AreEqual(9, AreaCalculator.CalculateArea(mySquare));
            }

            /*
                https://www.infragistics.com/community/blogs/b/dhananjay_kumar/posts/simplifying-the-liskov-substitution-principle-of-solid-in-c
                Even though the Square class is a subset of the Rectangle class,
                the Object of Rectangle class is not substitutable by the object
                of the Square class without causing a problem in the system.
            */

            //[TestMethod]
            //public void TwentyFor4X5RectangleFromSquare()
            //{
            //    Rectangle newRectangle = new Square();
            //    newRectangle.Width = 4;
            //    newRectangle.Height = 5;
            //    Assert.AreEqual(20, AreaCalculator.CalculateArea(newRectangle));
            //}

            [TestMethod]
            public void TwentyFor4X5ShapeFromRectangle()
            {
                Shape myShape = new Rectangle() { Height = 4, Width = 5 };
                Assert.AreEqual(20, myShape.Area());
            }

            [TestMethod]
            public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square()
            {
                var shapes = new List<Shape>
                {
                    new Rectangle {Height = 4, Width = 5},
                    new Square {SideLength = 3}
                };
                var areas = new List<int>();
                foreach (Shape shape in shapes)
                {
                    areas.Add(shape.Area());
                }
                Assert.AreEqual(20, areas[0]);
                Assert.AreEqual(9, areas[1]);
            }
        }
    }
}
