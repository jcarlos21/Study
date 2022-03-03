using System;

namespace URI_1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, soma = 0;            
            int MIN, MAX;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X < Y)
            {
                MIN = X;
                MAX = Y;
            }
            else
            {
                MIN = Y;
                MAX = X;
            }

            for (int i = MIN+1; i < MAX; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
;                }
            }

            Console.WriteLine(soma);

        }
    }
}
