using System;
using Xunit;
using ReversePolishCalculatorLib;

namespace ReversePolishCalulatorTesting
{
    public class ReversePolishCalculatorTests
    {
        [Fact]
        public void Compute_EmptyString_ReturnZero()
        {
            var calculator = new ReversePolishCalculator();

            var result = calculator.Compute("");
            Assert.Equal(0, result);
        }
    }
}
