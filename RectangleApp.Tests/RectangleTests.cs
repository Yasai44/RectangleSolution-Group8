using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RectangleApp.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        //GetLength() Tests

        [Test]
        public void GetLength_DefaultConstructor_Returns1()
        {
            //Arrange
            var rect = new Rectangle();

            //Act
            int result = rect.GetLength();

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetLength_AfterSettingLengthTo500_Returns500()
        {
            //Arrange
            var rect = new Rectangle();
            rect.SetLength(500);
            //Act
            int result = rect.GetLength();
            //Assert
            Assert.That(result, Is.EqualTo(500));
        }

        //SetLength() Tests
        [Test]
        public void SetLength_SetTo1_Returns1()
        {
            //Arrange
            var rect = new Rectangle();
            //Act
            int result = rect.SetLength(1);
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetLength_SetTo1500_Returns1500()
        {
            //Arrange
            var rect = new Rectangle();
            //Act
            int result = rect.SetLength(1500);
            //Assert
            Assert.That(result, Is.EqualTo(1500));
        }

        [Test]
        public void SetLength_SetTo750_Returns750()
        {
            //Arrange
            var rect = new Rectangle();
            //Act
            int result = rect.SetLength(750);
            //Assert
            Assert.That(result, Is.EqualTo(750));
        }

        //GetWidth() Tests

        [Test]
        public void GetWidth_DefaultConstructor_Returns1()
        {
            //Arrange
            var rect = new Rectangle();
            //Act
            int result = rect.GetWidth();
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetWidth_AfterSettingWidthTo1500_Returns1500()
        {
            //Arrange
            var rect = new Rectangle();
            rect.SetWidth(1500);
            //Act
            int result = rect.GetWidth();
            //Assert
            Assert.That(result, Is.EqualTo(1500));
        }

        [Test]
        public void GetWidth_AfterSettingWidthTo300_Returns300()
        {
            //Arrange
            var rect = new Rectangle();
            rect.SetWidth(300);
            //Act
            int result = rect.GetWidth();
            //Assert
            Assert.That(result, Is.EqualTo(300));
        }

        //SetWidth() Tests
        [Test]
        public void Setwidth_SetTo1_Returns1()
        {
            //Arrange
            var rect = new Rectangle();
            //Act
            int result = rect.SetWidth(1);
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void SetWidth_SetTo1500_Returns1500()
        {
            //Arrange
            var rect = new Rectangle();
            //Act
            int result = rect.SetWidth(1500);
            //Assert
            Assert.That(result, Is.EqualTo(1500));
        }

        [Test]
        public void SetWidth_SetTo600_Returns600()
        {
            //Arrange
            var rect = new Rectangle();
            //Act
            int result = rect.SetWidth(600);
            //Assert
            Assert.That(result, Is.EqualTo(600));
        }

        //GetPerimeter() Tests
        [Test]
        public void GetPerimeter_Length1Width1_Returns4()
        {
            //Arrange
            var rect = new Rectangle(1,1);
            //Act
            int result = rect.GetParimeter();
            //Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void GetPerimeter_Length1500Width1500_Returns6000()
        {
            //Arrange
            var rect = new Rectangle(1500, 1500);
            //Act
            int result = rect.GetParimeter();
            //Assert
            Assert.That(result, Is.EqualTo(6000));
        }

        [Test]  
        public void GetPerimeter_Length500Width300_Returns1600()
        {
            //Arrange
            var rect = new Rectangle(500, 300);
            //Act
            int result = rect.GetParimeter();
            //Assert
            Assert.That(result, Is.EqualTo(1600));
        }

        //GetArea() Tests
        [Test]
        public void GetArea_Length1Width1_Returns1()
        {
            //Arrange
            var rect = new Rectangle(1, 1);
            //Act
            int result = rect.GetArea();
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void GetArea_Length1500Width1500_Returns2250000()
        {
            //Arrange
            var rect = new Rectangle(1500, 1500);
            //Act
            int result = rect.GetArea();
            //Assert
            Assert.That(result, Is.EqualTo(2250000));
        }

        [Test]
        public void GetArea_Length300Width500_Returns150000()
        {
            //Arrange
            var rect = new Rectangle(300, 500);
            //Act
            int result = rect.GetArea();
            //Assert
            Assert.That(result, Is.EqualTo(150000));
        }

    }
}
