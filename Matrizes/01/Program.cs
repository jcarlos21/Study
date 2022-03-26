using System;

namespace _01 {
    internal class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            int M = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);

            int[,] matriz = new int[M, N];
            // var matriz2 = new float[M, N];  outra possibilidade de se criar uma matriz em C#

            for (int i = 0; i < M; i++) {
                vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {                
                    matriz[i, j] = int.Parse(vet[j]);                
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            foreach (int elemento in matriz) {
                if (elemento < 0) {
                    Console.WriteLine(elemento);
                }
            }
        }
    }
}
