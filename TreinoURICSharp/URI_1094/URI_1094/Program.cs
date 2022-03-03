using System;

namespace URI_1094
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int coelhos = 0, ratos = 0, sapos = 0;
            string[] vet;
            double percCoelhos = 0, percRatos = 0, percSapos = 0, total = 0;

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');

                if (vet[1] == "C" || vet[1] == "c")
                {
                    coelhos += int.Parse(vet[0]);
                }
                else if(vet[1] == "R" || vet[1] == "r")
                {
                    ratos += int.Parse(vet[0]);
                }
                else if (vet[1] == "S" || vet[1] == "s")
                {
                    sapos += int.Parse(vet[0]);
                }
            }

            total = coelhos + ratos + sapos;

            percCoelhos = (coelhos / total) * 100;
            percRatos = (ratos / total) * 100;
            percSapos = (sapos / total) * 100;

            Console.WriteLine($"Total: {total} cobaias");
            Console.WriteLine($"Total de coelhos: {coelhos}");
            Console.WriteLine($"Total de ratos: {ratos}");
            Console.WriteLine($"Total de sapos: {sapos}");
            Console.WriteLine($"Percentual de coelhos: {percCoelhos.ToString("F2")} %");
            Console.WriteLine($"Percentual de ratos: {percRatos.ToString("F2")} %");
            Console.WriteLine($"Percentual de sapos: {percSapos.ToString("F2")} %");
        }
    }
}