using System;

namespace URI_1096
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1, j = 7;

            while (i <= 9)
            {
                Console.WriteLine($"I={i} J={j}");
                if (j == 5)
                {
                    j = 7;
                    i = i + 2;
                }
                else
                {
                    j = j - 1;
                }
            }
        }
    }
}
