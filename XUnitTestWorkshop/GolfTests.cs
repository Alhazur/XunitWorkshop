using ConsoleXunitWorkshop;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;//eto chtobi ponyat [Fact]

namespace XUnitTestWorkshop
{
    public class GolfTests
    {
        [Fact] // eto Test
        public void TestOverAngle()
        {
            //Arrenge eto Raspolojenie,
            Golf golf = new Golf();
            bool result;

            //Act eto dejstvie, ili zakon. kotoroe doljno proishodit v klasse s metodom
            result = golf.VaildAngle(90);//Klass i metod dlya proverki

            //Assert eto Ytverjdeni, toest ybeditsya!!
            Assert.False(result);
        }

        [Fact]
        public void TestUnderAngle()
        {
            
            Golf golf = new Golf();
            bool result;

            
            result = golf.VaildAngle(0);

            
            Assert.False(result);
        }

        [Fact]
        public void TestUnderNegetivAngle()
        {

            Golf golf = new Golf();
            bool result;


            result = golf.VaildAngle(-0.00001);


            Assert.False(result);
        }

        [Fact]
        public void TestOverDecimalAngle()
        {

            Golf golf = new Golf();
            bool result;


            result = golf.VaildAngle(90.000001);


            Assert.False(result);
        }

        [Fact]
        public void TestAngleInsideRangeTo90()
        {

            Golf golf = new Golf();
            bool result;


            result = golf.VaildAngle(89.99);


            Assert.True(result);
        }

        [Fact]
        public void TestAngleInsideRangeCloseZero()
        {

            Golf golf = new Golf();
            bool result;


            result = golf.VaildAngle(0.99);


            Assert.True(result);
        }

        [Fact]
        public void TestRandomAngleInsideRange()
        {
            Random rng = new Random();
            double number = rng.NextDouble() + 0.0000001 + rng.Next(0,88);//nextdouble dast min 1 + 0001 + rng till 89 = Result

            Golf golf = new Golf();
            bool result;


            result = golf.VaildAngle(number);


            Assert.True(result);
        }
    }
}
