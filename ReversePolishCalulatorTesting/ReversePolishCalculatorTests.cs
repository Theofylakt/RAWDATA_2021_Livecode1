using System;
using Xunit;

namespace ReversePolishCalulatorTesting
{
    public class ReversePolishCalculatorTests
    {
        [Fact]
        public void Compute_EmptyString_ReturnZero()
        {
            var calculator = new ReversePolishCalulator();

            var result = calculator.Compute("");
            Assert.Equal(0, result);
        }
    }
}
