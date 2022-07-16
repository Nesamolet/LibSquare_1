using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using LibSquare;

namespace UnitTestProject1
{
    [TestClass]
    public class LibSquareUnitTest
    {
        [TestMethod]
        public void CircleInputValidation()
        {

            Assert.ThrowsException<Exception>(() => LibSquare.Circle.InputValidation(-3));
            Assert.ThrowsException<Exception>(() => LibSquare.Circle.InputValidation(0));
        }

        [TestMethod]
        public void CircleGetArea()
        {

            int r = 3;
          
            Assert.AreEqual(Math.PI * r * r, Circle.GetArea(r));
        }


        [TestMethod]
        public void TriangleInputValidation()
        {

            Assert.ThrowsException<Exception>(() => LibSquare.Triangle.InputValidation(-3,1,1));
            Assert.ThrowsException<Exception>(() => LibSquare.Triangle.InputValidation(1, -3, 1));
            Assert.ThrowsException<Exception>(() => LibSquare.Triangle.InputValidation(1, 1, -3));

            Assert.ThrowsException<Exception>(() => LibSquare.Triangle.InputValidation(0, 1, 1));
            Assert.ThrowsException<Exception>(() => LibSquare.Triangle.InputValidation(1, 0, 1));
            Assert.ThrowsException<Exception>(() => LibSquare.Triangle.InputValidation(1, 1, 0));
        }

        [TestMethod]
        public void TriangleGetArea()
        {

            int result = 6;
            Assert.AreEqual(6, Triangle.GetArea(3,4,5));

        }


    }
}
