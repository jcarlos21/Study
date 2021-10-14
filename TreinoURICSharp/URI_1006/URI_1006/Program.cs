using System;

namespace URI_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());
            double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

            Console.WriteLine($"MEDIA = {media.ToString("F1")}");
        }
    }
}
