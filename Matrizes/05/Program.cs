using System;

namespace _05 {
    internal class Program {
        static void Main(string[] args) {
            
            string[] vet = Console.ReadLine().Split(' ');

            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);

            int[,] matrizA = new int[M, N];
            int[,] matrizB = new int[M, N];
            int[,] matrizC = new int[M, N];

            for (int i = 0; i < M; i++) {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matrizA[i, j] = int.Parse(vet[j]);
                }
            }

            for (int i = 0; i < M; i++) {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matrizB[i, j] = int.Parse(vet[j]);
                }
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(matrizC[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
