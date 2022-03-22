using System;

namespace _03 {
    internal class Program {
        static void Main(string[] args) {
            
            int N = int.Parse(Console.ReadLine());
            int[] vetorSoma = new int[N];
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vetorSoma[i] = int.Parse(vet1[i]) + int.Parse(vet2[i]);
            }

            foreach (int elemento in vetorSoma) {
                Console.Write(elemento + " ");
            }
        }
    }
}
