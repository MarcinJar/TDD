using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Test
{
    public class Theory
    {
        [Datapoint]
        public int Negative = -1;
        [Datapoint]
        public int Positive = 1;

        [Theory]
        public void WhenDividendIsPositiveAndDivisorIsNegativ_TheQuotientIsNegativ(int dividend, int divisor)
        {
            Assume.That(dividend > 0);
            Assume.That(divisor < 0);

            var calculator = new Calculator();

            float quotient = calculator.Divide(dividend, divisor);

            Assert.That(quotient < 0);
        }
    }
}
