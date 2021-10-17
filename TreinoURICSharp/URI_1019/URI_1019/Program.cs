using System;

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int hours = N / 3600;
            int resto = (N % 3600);
            int minutes = resto / 60;
            int seconds = resto % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");

        }
    }
}
