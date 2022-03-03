using System;

namespace URI_1116
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double X, Y;
            string[] vet;

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                X = double.Parse(vet[0]);
                Y = double.Parse(vet[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine((X / Y).ToString("F1"));
                }
            }
        }
    }
}
