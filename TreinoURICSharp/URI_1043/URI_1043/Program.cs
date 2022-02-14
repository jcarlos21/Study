using System;

namespace URI_1043 {

    class Program {

        static void Main(string[] args) {

            double n1, n2, n3;

            string[] vet = Console.ReadLine().Split();

            n1 = double.Parse(vet[0]);
            n2 = double.Parse(vet[1]);
            n3 = double.Parse(vet[2]);

            if ((n1 >= (n2 + n3)) || (n2 >= (n1 + n3)) || (n3 >= (n1 + n2))) {
                // Aqui não forma triângulo
                Console.WriteLine($"Area = {((n1 + n2) * n3 / 2.0).ToString("F1")}");
            }
            else {
                Console.WriteLine($"Perimetro = {(n1 + n2 + n3).ToString("F1")}");
            }
        }
    }
}
