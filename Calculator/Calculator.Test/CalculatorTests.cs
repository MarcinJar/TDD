using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Add_AddsTowPositiveNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(2, 2);
            Assert.AreEqual(4, sum);
        }

        [Test]
        public void Add_AddsOnePositivAndSecendNegativNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(2, -3);
            Assert.AreEqual(-1, sum);
        }

        [Test]
        public void Add_AddsOneNegativAndSecendPositivNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(-2, 3);
            Assert.AreEqual(1, sum);
        }

        [Test]
        public void Add_AddsTowNegativeNumbers_Calculated()
        {
            var calc = new Calculator();
            int sum = calc.Add(-2, -2);
            Assert.AreEqual(-4, sum);
        }

        [TestCase(4, 2, 2.0f)]
        [TestCase(-4, 2, -2.0f)]
        [TestCase(4, -2, -2.0f)]
        [TestCase(0, 3, 0.0f)]
        [TestCase(5, 2, 2.5f)]
        [TestCase(1, 3, 0.333333343f)]
        public void Divide_ReturnsProperValue(int dividend, int divisor, float expectedQuotient)
        {
            var calc = new Calculator();
            var quotient = calc.Divide(dividend, divisor);
            Assert.AreEqual(expectedQuotient, quotient);
        }

        [Test]
        public void Divide_DivisonByZero_ThrowsException()
        {
            var calc = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calc.Divide(2, 0));
        }

        [Test]
        public void Divide_OnCalculatedEventIsCalled()
        {
            var calc = new Calculator();

            bool wasEventCalled = false;
            calc.CalculatedEvent += (sender, args) => wasEventCalled = true;

            calc.Divide(1, 2);

            Assert.IsTrue(wasEventCalled);
        }
    }
}
