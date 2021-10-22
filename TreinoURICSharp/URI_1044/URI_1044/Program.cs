using System;

namespace URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            string[] vet = Console.ReadLine().Split();
            num1 = int.Parse(vet[0]);
            num2 = int.Parse(vet[1]);

            if (num1 % num2 == 0 || num2 % num1 == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
