using System;

namespace URI_1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine());

            double consumeMedio = X / Y;

            Console.WriteLine($"{consumeMedio.ToString("F3")} km/l");
        }
    }
}
