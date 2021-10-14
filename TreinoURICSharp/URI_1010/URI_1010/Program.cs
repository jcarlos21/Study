using System;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            int codPeca1 = int.Parse(vet1[0]);
            int qtdePeca1 = int.Parse(vet1[1]);
            double precoPeca1 = double.Parse(vet1[2]);

            int codPeca2 = int.Parse(vet2[0]);
            int qtdePeca2 = int.Parse(vet2[1]);
            double precoPeca2 = double.Parse(vet2[2]);

            double totalPeca1 = qtdePeca1 * precoPeca1;
            double totalPeca2 = qtdePeca2 * precoPeca2;

            double total = totalPeca1 + totalPeca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2")}");
        }
    }
}
