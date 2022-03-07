using System;

namespace URI_1150 {
    internal class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int cont = 0, soma = 0;

            while (z <= x) {
                z = int.Parse(Console.ReadLine());
            }

            while (soma <= z) {
                soma += x;
                x++;
                cont++;
            }
            Console.WriteLine(cont);
        }
    }
}
