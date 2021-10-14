using System;

namespace ReversePolishCalculatorLib
{
    public class ReversePolishCalculator
    {
        public int Compute(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var tokens = input.Split(' ');

            if (tokens.Length == 1)
                return int.Parse(input);

            var val1 = int.Parse(tokens[0]);
            var val2 = int.Parse(tokens[1]);

            if(tokens[2] == "+")
                return val1 + val2;
            return val1 * val2;
        }
    }
}
