using ConsoleXunitWorkshop;
using System;
using Xunit;

namespace XUnitTestWorkshop
{
    public class CalcTests
    {
        [Fact]
        public void testAdd2Plus2()
        {
            //Arrenge
            Calc calc = new Calc();
            double result;

            //Act
            result = calc.Add(2, 2);

            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void testAdd2Negetiv2()
        {
            //Arrenge
            Calc calc = new Calc();
            double result;

            //Act
            result = calc.Add(-2, -2);

            //Assert
            Assert.Equal(-4, result);
        }

        [Fact]
        public void testAdd2Plus2Double()
        {
            //Arrenge
            Calc calc = new Calc();
            double result;

            //Act
            result = calc.Add(2.5, 2.8);

            //Assert
            Assert.Equal(5.3, result);
        }
    }
}
