using System;

namespace _04 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(vet[j]);
                }
            }

            int soma = 0;  // Variável responsável pela soma dos elementos acima da diagonal principal

            for (int linha = 0; linha < N; linha++) {
                for (int coluna = 0; coluna < N; coluna++) {
                    if (linha != coluna && coluna > linha) {
                        soma += matriz[linha, coluna];
                    }
                }            
            }
            Console.WriteLine(soma);
        }
    }
}
