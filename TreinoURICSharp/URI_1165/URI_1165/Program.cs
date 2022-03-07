using System;

namespace URI_1165 {
    internal class Program {
        static void Main(string[] args) {

            int testes = int.Parse(Console.ReadLine());
            int numero, cont;

            for (int i = 0; i < testes; i++) {

                numero = int.Parse(Console.ReadLine());
                cont = 0;

                for (int j = 1; j <= numero; j++) {
                    if (numero % j == 0) {
                        cont++;
                    }
                }

                if (cont == 2) {
                    Console.WriteLine($"{numero} eh primo");
                }
                else {
                    Console.WriteLine($"{numero} nao eh primo");
                }

            }
        }
    }
}
