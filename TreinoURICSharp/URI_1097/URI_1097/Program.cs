using System;

namespace URI_1097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 7, aux = 0, cont = 1;

            for (int i = 1; i < 10; i += 2)
            {
                while (cont <= 3)
                {
                    Console.WriteLine($"I={i} J={j}");

                    if (cont == 3)
                    {
                        j = aux;
                    }
                    else
                    {
                        j = j - 1;
                        aux = j + 4;
                    }
                    cont++;
                }
                cont = 1;
            }
        }
    }
}
