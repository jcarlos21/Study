using System;

namespace URI_1159
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continuar = 0, soma = 0;
            int X = 1;
            X = int.Parse(Console.ReadLine());

            while (X != 0)
            {
                while (continuar < 5)
                {
                    if (X % 2 == 0)
                    {
                        soma = soma + X;
                        continuar++;
                    }
                    X++;
                }
                continuar = 0;
                Console.WriteLine(soma);
                soma = 0;
                X = int.Parse(Console.ReadLine());
            }
        }
    }
}
