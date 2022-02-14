using System;

namespace URI_1065 {

    class Program {

        static void Main(string[] args) {

            double[] vet = new double[5];
            int cont = 0;
            double soma = 0;

            //Console.WriteLine(vet.Length);

            for (int i = 0; i < vet.Length; i++) {
                vet[i] = double.Parse(Console.ReadLine());
                if (vet[i] % 2 == 0) {
                    cont++;
                }
            }

            Console.WriteLine($"{cont} valores pares");
        }
    }
}
