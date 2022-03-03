using System;

namespace URI_1080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, posicao = 0, maior = 0;

            for (int i = 0; i < 100; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x > maior)
                {
                    maior = x;
                    posicao = i + 1;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}