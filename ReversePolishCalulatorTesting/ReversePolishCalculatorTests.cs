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

        [Fact]
        public void Compute_OneInteger_ReturnThatInteger()
        {
            var calculator = new ReversePolishCalculator();

            var result = calculator.Compute("4");
            Assert.Equal(4, result);
        }

        [Fact]
        public void Compute_AdditionWithTwoIntegers_ReturnTheSum()
        {
            var calculator = new ReversePolishCalculator();

            var result = calculator.Compute("5 6 +");
            Assert.Equal(11, result);
        }
    }
}
