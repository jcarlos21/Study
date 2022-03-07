using System;

namespace URI_1158 {
    internal class Program {
        static void Main(string[] args) {
            
            int testes = int.Parse(Console.ReadLine());
            string[] vet;
            int x, y, soma, a;

            for (int i = 0; i < testes; i++) {
                soma = 0;

                vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                a = 0;
                while (a < y) {
                    if (x % 2 != 0) {
                        soma += x;
                        a++;
                    }
                    x++;
                }            
                Console.WriteLine(soma);
            }
        }
    }
}
