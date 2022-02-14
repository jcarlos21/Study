using System;

namespace teste_er {
    internal class Program {
        static void Main(string[] args) {

            int x, soma = 0;

            x = int.Parse(Console.ReadLine());

            while (x != 0) {
                soma += x;
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A soma é {soma}");
        }
    }
}
