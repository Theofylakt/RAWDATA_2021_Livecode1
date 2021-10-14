using System;

namespace ExtensionMethodExample
{
    static class MyEXt
    {
        public static string ReverseWords(this string s, string delimiter = " ")
        {
            var words = s.Split(' ');
            var result = "";
            for (var i = words.Length - 1; i >= 0; i--)
            {
                if (result.Length > 0)
                    result += delimiter;
                result += words[i];
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var s = "This is a string";
            Console.WriteLine(s);

            Console.WriteLine(s.ReverseWords("#"));
        }
    }
}
