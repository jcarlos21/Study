using System;

namespace _02 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int[] vetor = new int[N];
            string[] vet = Console.ReadLine().Split(' ');
            int quantidadeVetoresPar = 0;

            for (int i = 0; i < N; i++) {
                vetor[i] = int.Parse(vet[i]);

                if (vetor[i] % 2 == 0) {
                    Console.Write(vetor[i] + " ");
                    quantidadeVetoresPar++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(quantidadeVetoresPar);
        }
    }
}
