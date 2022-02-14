using System;

namespace URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            string[] vet = Console.ReadLine().Split();

            A = double.Parse(vet[0]);
            B = double.Parse(vet[1]);
            C = double.Parse(vet[2]);

            if (A >= (B + C) || B >= (A + C) || C >= (A + B))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                if ((A * A == B * B + C * C) || (B * B == A * A + C * C) || (C * C == A * A + B * B))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if ((A * A > B * B + C * C) || (B * B > A * A + C * C) || (C * C > A * A + B * B))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if ((A * A < B * B + C * C) || (B * B < A * A + C * C) || (C * C < A * A + B * B))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
            }

            if (A == B && A == C) {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            else if (A == B || A == C || B == C) {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }

        }
    }
}
