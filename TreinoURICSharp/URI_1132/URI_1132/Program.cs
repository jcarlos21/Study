using System;

namespace URI_1132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, soma = 0;
            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());
            
            if (X < Y)
            {
                for (int i = X; i <= Y; i++)
                {
                    if ((i % 13) != 0)
                    {
                        soma += i;
                    }
                }
            }
            else
            {
                for (int j = Y; j <= X; j++)
                {
                    if ((j % 13) != 0)
                    {
                        soma += j;
                    }
                }
            }

            Console.WriteLine(soma);
        }
    }
}
