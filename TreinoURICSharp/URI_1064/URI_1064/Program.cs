using System;

namespace URI_1060 {

    class Program {

        static void Main(string[] args) {

            double[] vet = new double[6];
            int cont = 0;
            double soma = 0;

            //Console.WriteLine(vet.Length);

            for (int i = 0; i < vet.Length; i++) {
                vet[i] = double.Parse(Console.ReadLine());
                if (vet[i] > 0) {
                    cont++;
                    soma = soma + vet[i];
                }
            }

            Console.WriteLine($"{cont} valores positivos");
            Console.WriteLine((soma / cont).ToString("F1"));
        }
    }
}
