using System;

namespace _06 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double[,] matriz = new double[N, N];

            for (int i = 0; i < N; i++) { 
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < vet.Length; j++) {
                    matriz[i, j] = double.Parse(vet[j]);
                }
            }

            // Soma dos positivos:

            double somaPositivos = 0.0;

            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] > 0) {
                        somaPositivos += matriz[i, j];
                    }
                }
            }
            Console.WriteLine($"SOMA DOS POSITIVOS: {somaPositivos.ToString("F1")}");

            // Linha escolhida:

            int linhaEscolhida = int.Parse(Console.ReadLine());

            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[linhaEscolhida, i].ToString("F1") + " ");
            }
            Console.WriteLine();

            // Coluna escolhida:

            int colunaEscolhida = int.Parse(Console.ReadLine());

            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, colunaEscolhida].ToString("F1") + " ");
            }
            Console.WriteLine();

            // Diagonal principal:

            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, i].ToString("F1") + " ");
            }
            Console.WriteLine();

            // Matriz alterada

            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        matriz[i, j] = Math.Pow(matriz[i, j], 2);
                    }
                    Console.Write(matriz[i, j].ToString("F1") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
