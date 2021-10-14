using System;

namespace ReversePolishCalculatorLib
{
    public class ReversePolishCalculator
    {
        public int Compute(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            return int.Parse(input);
        }
    }
}
