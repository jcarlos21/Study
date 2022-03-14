using System;

namespace Desafio2DIO {
    internal class Program {
        static void Main(string[] args) {

            int testes = int.Parse(Console.ReadLine());
            int cont = 0;

            for (int i = 0; i < testes; i++) {

                int clientes = int.Parse(Console.ReadLine());
                string[] vet = Console.ReadLine().Split(' ');

                int[] vetor = new int[vet.Length];
                int[] vetor2 = new int[vet.Length];

                for (int j = 0; j < vetor.Length; j++) {
                    vetor[j] = int.Parse(vet[j]);
                    vetor2[j] = int.Parse(vet[j]);
                }

                Array.Sort(vetor);
                Array.Reverse(vetor);

                for (int j = 0; j < vetor2.Length; j++) {

                    if (vetor2[j] == vetor[j]) {
                        cont++;
                    }
                }

                Console.WriteLine(cont);
                cont = 0;
            }


        }
    }
}
