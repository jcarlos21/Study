using System;

namespace URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split();

            int A, B, C;
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            int maiorAB = (A + B + Math.Abs(A - B)) / 2;
            int maiorABC = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine($"{maiorABC} eh o maior");
        }
    }
}
