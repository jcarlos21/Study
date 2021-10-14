using System;

namespace URI_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;
            double n = 3.14159;
            raio = double.Parse(Console.ReadLine());

            double A = n * raio * raio;

            Console.WriteLine("A=" + A.ToString("F4"));
        }
    }
}
