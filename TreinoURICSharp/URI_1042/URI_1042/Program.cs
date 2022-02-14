using System;

namespace URI_1042 {

    class Program {

        static void Main(string[] args) {

            int num1, num2, num3;

            String[] vet = Console.ReadLine().Split();

            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);
            num3 = int.Parse(vet[2]);

            if ((num1 <= num2) && (num1 <= num3)) {
                if (num2 <= num3) {
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                }
                else {
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                }
            }
            else if ((num2 < num1) && (num2 < num3)) {
                if (num1 <= num3) {
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                    Console.WriteLine(num3);
                }
                else {
                    Console.WriteLine(num2);
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                }
            }
            else {
                if (num1 <= num2) {
                    Console.WriteLine(num3);
                    Console.WriteLine(num1);
                    Console.WriteLine(num2);
                }
                else {
                    Console.WriteLine(num3);
                    Console.WriteLine(num2);
                    Console.WriteLine(num1);
                }
            }

            Console.WriteLine();
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
        }
    }
}
