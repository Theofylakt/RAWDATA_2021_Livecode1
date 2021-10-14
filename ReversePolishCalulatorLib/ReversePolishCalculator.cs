using System;
using System.Collections.Generic;

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

            var stack = new Stack<int>();


            foreach (var token in tokens)
            {
                if (int.TryParse(token, out var number))
                {
                    stack.Push(number);
                }
                else
                {
                    if (token == "+")
                    {
                        var val2 = stack.Pop();
                        var val1 = stack.Pop();
                        stack.Push(val1 + val2);
                    }

                    else if (token == "*")
                    {
                        var val2 = stack.Pop();
                        var val1 = stack.Pop();
                        stack.Push(val1 * val2);
                    }

                }
            }

            return stack.Pop();
        }
    }
}
