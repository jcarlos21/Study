using System;

namespace URI_1155
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.00;

            for (double i = 1; i <= 100; i++)
            {
                soma += 1 / i;
            }

            Console.WriteLine(soma.ToString("F2"));
        }
    }
}
