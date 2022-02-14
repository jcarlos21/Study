using System;

namespace URI_1070 {

    class Program {

        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            int cont = 1;

            while (cont <= 6) {
                if (n % 2 != 0) {
                    Console.WriteLine(n);
                    cont++;
                }
                n++;
            }
        }
    }
}
