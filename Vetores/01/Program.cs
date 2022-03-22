using System;

namespace _01 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double[] vetor = new double[N];
            string[] vet = Console.ReadLine().Split(' ');
            double maior = double.Parse(vet[0]);
            int indiceVetor = 0;

            for (int i = 0; i < N; i++) {
                vetor[i] = double.Parse(vet[i]);

                if (vetor[i] > maior) {
                    maior = vetor[i];
                    indiceVetor = i;
                }
            }
            Console.WriteLine(maior.ToString("F1"));
            Console.WriteLine(indiceVetor);
        }
    }
}
