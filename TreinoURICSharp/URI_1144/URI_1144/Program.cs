using System;

namespace URI_1144
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
                Console.WriteLine($"{primeiro} {segundo+1} {terceiro+1}");
            }
        }
    }
}

// Pode substituir o código abaixo pelo 2º for + o Console.WriteLine()
// int primeiro = i;
// int segundo = i * i;
// int terceiro = i * i * i;
// Console.WriteLine($"{primeiro} {segundo} {terceiro}");