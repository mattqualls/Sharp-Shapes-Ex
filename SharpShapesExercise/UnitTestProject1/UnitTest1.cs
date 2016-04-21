

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SharpShapeTests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestShapeType()
        {
            Shape simple = new Shape();
            Assert.IsInstanceOfType(simple, typeof(Shape));
        }

        [TestMethod]
        public void TestCircleType()
        {
            Circle circle = new Circle();
            Assert.IsInstanceOfType(circle, typeof(Circle));
        }

        [TestMethod]
        public void TestSquareType()
        {
            Square square = new Square();
            Assert.IsInstanceOfType(square, typeof(Square));
        }

        [TestMethod]
        public void TestCylinderType()
        {
            Cylinder cylinder = new Cylinder();
            Assert.IsInstanceOfType(cylinder, typeof(Cylinder));
        }

        [TestMethod]
        public void TestCubeType()
        {
            Cube cube = new Cube();
            Assert.IsInstanceOfType(cube, typeof(Cube));
        }

        [TestMethod]
        public void TestPyramidType()
        {
            Pyramid pyramid = new Pyramid();
            Assert.IsInstanceOfType(pyramid, typeof(Pyramid));
        }
        //End of shapes and start of calculations

        [TestMethod]
        public void TestShapeVolume()
        {
            Shape simple = new Shape();
            simple.width = 2;
            simple.height = 3;
            simple.depth = 5;
            Assert.IsTrue(simple.calculateVolume() == 30);
        }

        [TestMethod]
        public void TestShapeArea()
        {
            Shape simple = new Shape();
            simple.width = 2;
            simple.height = 2;
            Assert.IsTrue(simple.calculateArea() == 4);
        }

        [TestMethod]
        public void TestSquareArea()
        {
            Square simple = new Square();
            Assert.IsTrue(square.calculateArea() == 4);
        }

        [TestMethod]
        public void TestCircleArea()
        {
            Circle simple = new Circle();
            Assert.IsTrue(cirlce.calculateArea() == Math.PI);
        }
    }
}
