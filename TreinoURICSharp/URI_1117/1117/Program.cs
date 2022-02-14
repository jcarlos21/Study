using System;

namespace _1117
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            while (x < 0 || x > 10){
                Console.WriteLine("nota invalida");
                x = double.Parse(Console.ReadLine());
            }

            double y = double.Parse(Console.ReadLine());
            while (y < 0 || y > 10)
            {
                Console.WriteLine("nota invalida");
                y = double.Parse(Console.ReadLine());
            }

            double media = (x + y) / 2.00;

            Console.WriteLine($"media = {media.ToString("F2")}");
        }
    }
}
