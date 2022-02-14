using System;

namespace URI_1041
{
    class Program
    {
        static void Main(string[] args)
        {

            double p1, p2;
            string[] vet = Console.ReadLine().Split();

            p1 = double.Parse(vet[0]);
            p2 = double.Parse(vet[1]);

            if (p1 == 0 || p2 == 0)
            {
                if (p1 == 0 && p2 == 0)
                {
                    Console.WriteLine("Origem");
                }
                else if (p1 == 0)
                {
                    Console.WriteLine("Eixo Y");
                }
                else
                {
                    Console.WriteLine("Eixo X");
                }
            }
            else if (p1 > 0 && p2 > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (p1 < 0 && p2 > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (p1 < 0 && p2 < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
