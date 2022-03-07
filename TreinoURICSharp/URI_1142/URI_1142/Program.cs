using System;

namespace URI_1142
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int contador = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    if (contador % 4 == 0)
                    {
                        contador++;
                        Console.Write(contador + " ");
                    }
                    else
                    {
                        Console.Write(contador + " ");
                        if (j == 3)
                        {
                            Console.Write("PUM");
                            Console.WriteLine();
                        }
                    }
                    contador++;
                }
            }
        }
    }
}
