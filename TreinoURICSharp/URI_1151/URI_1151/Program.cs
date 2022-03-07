using System;

namespace URI_1151
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int numeroAnterior = 0;
            int numeroAtual = 1;
            int novoNumero;
            int fib;

            for (int i = 0; i < N; i++)
            {

                
                if (i == 0 || i == 1)
                {
                    if(i == 0)
                    {
                        Console.Write(0 + " ");
                    }
                    else
                    {
                        Console.Write(1 + " ");
                    }
                }
                else
                {
                    fib = numeroAnterior + numeroAtual;
                    Console.Write(fib + " ");
                    numeroAnterior = numeroAtual;
                    numeroAtual = fib;
                }
                
            }

        }
    }
}

//int a = 0;
//int b = 1;

//for (int i = 0; i < n; i = i + 1)
//{
//    if (i == n - 1)
//    {
//        Console.WriteLine(a);
//    }
//    else
//    {
//        Console.Write(a + " ");
//    }
//    int aux = b;
//    b = a;
//    a = aux + b;
//}