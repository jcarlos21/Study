using System;

namespace URI_1156
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0, den = 1.0;

            for (int i = 1; i <= 39; i += 2)
            {
                soma = soma + i / den;
                den = den * 2.0;
            }

            Console.WriteLine(soma.ToString("F2"));
        }
    }
}
