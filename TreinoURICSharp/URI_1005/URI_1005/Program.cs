using System;

namespace URI_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double media = ((nota1 * 3.5) + (nota2 * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {media.ToString("F5")}");
        }
    }
}
