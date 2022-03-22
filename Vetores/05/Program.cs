using System;

namespace _05 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int soma = 0;
            int contador = 0;
            string[] vet = Console.ReadLine().Split(' ');
            int[] vetorInt = new int[N];

            for (int i = 0; i < N; i++) {
                vetorInt[i] = int.Parse(vet[i]);
                if (vetorInt[i] % 2 == 0) {
                    soma += int.Parse(vet[i]);
                    contador++;
                }
            }

            double media = soma / contador;
            Console.WriteLine(media.ToString("F1"));
        }
    }
}