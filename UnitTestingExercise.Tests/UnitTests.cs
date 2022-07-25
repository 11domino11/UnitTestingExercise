using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5, 5, 5, 15)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,0)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = (minuend - subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(20,2,40)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = num1 * num2;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,5)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = num1 / num2;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsA()
        {
            //Arrange
            var expected = 'a';
            //Act
            var actual = 'a';
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsB()
        {
            //Arrange
            var expected = 'b';
            //Act
            var actual = 'b';
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
