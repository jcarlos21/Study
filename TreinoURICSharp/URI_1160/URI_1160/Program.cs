using System;

namespace URI_1160 {
    internal class Program {
        static void Main(string[] args)
        {
            int Testes, populacaoA, populacaoB, crescimentoPopA, crescimentoPopB, anos;
            double G1, G2;
            string[] vet;

            Testes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= Testes; i++) {
                vet = Console.ReadLine().Split(' ');
                populacaoA = int.Parse(vet[0]);
                populacaoB = int.Parse(vet[1]);
                G1 = double.Parse(vet[2]);
                G2 = double.Parse(vet[3]);

                crescimentoPopA = populacaoA;
                crescimentoPopB = populacaoB;

                anos = 0;
                while (crescimentoPopA <= crescimentoPopB) {
                    crescimentoPopA += (int)(crescimentoPopA * (G1 / 100));
                    crescimentoPopB += (int)(crescimentoPopB * (G2 / 100));
                    anos += 1;
                }

                if (anos > 100) {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else {
                    Console.WriteLine($"{anos} anos.");
                }
            }
        }
    }
}