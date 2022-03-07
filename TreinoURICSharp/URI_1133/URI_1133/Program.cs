using System;

namespace URI_1133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            if (X > Y)
            {
                int aux = X;
                X = Y;
                Y = aux;
            }

            for (int i = X+1; i < Y; i++)  // Foi adicionado +1 em int i = X+1 pois o valor inicial não entra na conta
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
