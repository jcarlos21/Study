using System;

namespace URI_1066 {

    class Program {

        static void Main(string[] args) {

            double[] vet = new double[5];
            int par = 0, impar = 0, positivo = 0, negativo = 0;

            for (int i = 0; i < vet.Length; i++) {
                vet[i] = double.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0) {
                    par++;
                }
                else {
                    impar++;
                }

                if (vet[i] > 0) {
                    positivo++;
                }
                else {
                    if (vet[i] < 0) {
                        negativo++;
                    }
                }
            }
            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{positivo} valor(es) positivo(s)");
            Console.WriteLine($"{negativo} valor(es) negativo(s)");
        }
    }
}
