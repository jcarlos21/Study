using System;

namespace URI_1101 {
    internal class Program {
        static void Main(string[] args) {
            int N = 1, M = 1;
            string[] vet;

            while (N > 0 && M > 0) {
                
                int soma = 0;
                vet = Console.ReadLine().Split(' ');
                N = int.Parse(vet[0]);
                M = int.Parse(vet[1]);

                if (N <= 0 || M <= 0) {
                    break;
                }
                if (N > M) {
                    int aux = M;
                    M = N;
                    N = aux;
                }
                for (int i = N; i <= M; i++) {
                    
                    soma += i;
                    Console.Write(i +" ");
                }
                Console.WriteLine($"Sum={soma}");
            }
        }
    }
}
