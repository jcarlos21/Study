using System;

namespace _04 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            double soma = 0.0;
            double[] numReais = new double[N];
            string[] vet = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                
                numReais[i] = double.Parse(vet[i]);
                soma += numReais[i];            
            }

            double media = soma / N;

            Console.WriteLine(media.ToString("F3"));
            foreach (double elemento in numReais) {
                if (elemento < media) {
                    Console.WriteLine(elemento.ToString("F2"));
                }
            }
        }
    }
}
