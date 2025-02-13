using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Egysegteszt_LakatosBotond;

namespace RectangleAreaTest
{
    [TestClass]
    public class RectangleAreaTest
    {
        [TestMethod]
        public void CalculateArea_ReturnTrue_NormalEset()
        {
            //Arrange

            var teglalap = new Rectangle();
            int width = 5;
            int height = 10;

            //Act

            int result = teglalap.CalculateArea(width, height);

            //Assert

            Assert.Equals(50, result);
        }
            
        [TestMethod]
        public void CalculateArea_ReturnTrue_PozitivSzamok()
        {
            //Arrange

            var teglalap = new Rectangle();
            int width = 0;
            int height = 10;

            //Act

            int result = teglalap.CalculateArea(width, height);

            //Assert

            Assert.Equals(0, result);
        }
        [TestMethod]
        public void CalculateArea_ReturnTrue_NullaHosszusag()
        {
            //Arrange

            var teglalap = new Rectangle();
            int width = 10;
            int height = 0;

            //Act

            int result = teglalap.CalculateArea(width, height);

            //Assert

            Assert.Equals(0, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateFactorial_ThrowException_NegativSzelesseg()
        {
            //Arrange
            var teglalap = new Rectangle();
            int width = -5;
            int height = 10;

            //Act
            int result = teglalap.CalculateArea(width, height);

            //Assert


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculateFactorial_ThrowException_NegativHosszusag()
        {
            //Arrange
            var teglalap = new Rectangle();
            int width = 10;
            int height = -5;

            //Act
            int result = teglalap.CalculateArea(width, height);

            //Assert

        }
        [TestMethod]
        public void CalculateArea_ReturnTrue_NagySzamok()
        {
            //Arrange

            var teglalap = new Rectangle();
            int width = 10000000;
            int height = 20000000;

            //Act

            int result = teglalap.CalculateArea(width, height);

            //Assert

            Assert.Equals(2000000000000, result);
        }
        [TestMethod]
        public void CalculateArea_ReturnTrue_NemEgeszSzamok()
        {
            //Arrange

            var teglalap = new Rectangle();
            double width = 4.5;
            double height = 8.2;

            //Act

            int result = teglalap.CalculateArea(width, height);

            //Assert
            Assert.Equals(36.9 , result);

        }
    }
}
