using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapeAreaLib.Tests
{
    [TestClass]
    public class ShapeAreaTests
    {
        [TestMethod]
        public void GetArea_Circle()
        {
            //arrange
            Shape circle = new Shape();
            double expected = 12.566370614359172;
            //act
            double actual = circle.GetArea(2);
            //asset
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetArea_Triangle()
        {
            //arrange
            Shape triangle = new Shape();
            double expected = 6;
            //act
            double actual = triangle.GetArea(3, 4, 5);
            //asset
            Assert.AreEqual(expected, actual);
        }
    }
}

