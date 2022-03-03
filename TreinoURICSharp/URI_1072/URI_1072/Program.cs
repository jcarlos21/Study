using System;

namespace URI_1072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int X, contIN = 0, contOUT = 0;

            for (int i = 0; i < N; i++)
            {
                X = int .Parse(Console.ReadLine());

                if (X >= 10 && X <= 20)
                {
                    contIN++;
                }
                else
                {
                    contOUT++;
                }
            }

            Console.WriteLine($"{contIN} in");
            Console.WriteLine($"{contOUT} out");
        }
    }
}
