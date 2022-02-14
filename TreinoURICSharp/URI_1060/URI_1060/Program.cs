using System;

namespace URI_1060 {

    class Program {

        static void Main(string[] args) {

            double[] vet = new double[6];
            int cont = 0;

            //Console.WriteLine(vet.Length);

            for (int i = 0; i < vet.Length; i++) {
                vet[i] = double.Parse(Console.ReadLine());
                if (vet[i] > 0) {
                    cont++;
                }
            }

            Console.WriteLine($"{cont} valores positivos");
        }
    }
}
