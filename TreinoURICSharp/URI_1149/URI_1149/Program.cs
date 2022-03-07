using System;

namespace URI_1149 {
    internal class Program {
        static void Main(string[] args) {

            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);
            int soma = 0, i;

            i = 1;
            while (N <= 0) {
                i = i + 1;
                N = int.Parse(vet[i]);
            }

            for (i = 0; i < N; i++) {
                soma = soma + A + i;
            }
            Console.WriteLine(soma);
        }
    }
}
