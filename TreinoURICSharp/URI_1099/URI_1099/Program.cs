using System;

namespace URI_1099
{
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            int X, Y, aux, soma = 0;
            string[] vet;

            for (int i = 0; i < N; i++) {

                vet = Console.ReadLine().Split(' ');
                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);

                if (X > Y) {
                    aux = Y;
                    Y = X;
                    X = aux;
                }

                for (int j = X + 1; j < Y; j++) {
                    if (j % 2 != 0) {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
                soma = 0;
            }
        }
    }
}
