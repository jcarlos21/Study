using System;

namespace URI_1143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Math.Pow(i, j + 1) + " ");

                }
                Console.WriteLine();
            }
        }
    }
}

// Pode substituir o código abaixo pelo 2º for + o Console.WriteLine()
// int primeiro = i;
// int segundo = i * i;
// int terceiro = i * i * i;
// Console.WriteLine($"{primeiro} {segundo} {terceiro}");