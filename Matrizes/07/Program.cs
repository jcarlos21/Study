using System;

namespace _07 {
    internal class Program {
        static void Main(string[] args) {

            int filas = int.Parse(Console.ReadLine());
            int soldadosPorFilas = int.Parse(Console.ReadLine());

            int[,] pelotao = new int[filas, soldadosPorFilas];

            for (int i = 0; i < filas; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                for (int j = 0; j < soldadosPorFilas; j++) {
                    pelotao[i, j] = int.Parse(vet[j]);
                }
            }

            // Giro

            int[] vetAux = new int[soldadosPorFilas];
            int numFila = int.Parse(Console.ReadLine());

            vetAux[0] = pelotao[numFila - 1, soldadosPorFilas - 1];

            for (int i = 0; i < soldadosPorFilas - 1; i++) {
                vetAux[i+1] = pelotao[numFila - 1, i];
            }

            for (int i = 0; i < soldadosPorFilas; i++) {
                pelotao[numFila - 1, i] = vetAux[i];
            }

            for (int i = 0; i < filas; i++) {
                for (int j = 0; j < soldadosPorFilas; j++) {
                    Console.Write(pelotao[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
