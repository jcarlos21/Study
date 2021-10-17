using System;
using System.Globalization;

namespace URI_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            int nota100, nota50, nota20, nota10, nota5, nota2, moeda1;
            int moeda050, moeda025, moeda010, moeda005, moeda001;
            double resto;

            nota100 = (int) N / 100;
            nota50 = (int) (N % 100) / 50;
            nota20 = (int) ((N % 100) % 50) / 20;
            nota10 = (int) (((N % 100) % 50) % 20) / 10;
            nota5 = (int) ((((N % 100) % 50) % 20) % 10) / 5;
            nota2 = (int) (((((N % 100) % 50) % 20) % 10) % 5) / 2;

            moeda1 = (int) ((((((N % 100) % 50) % 20) % 10) % 5) % 2) / 1;
            moeda050 = (int)((((((((N % 100) % 50) % 20) % 10) % 5) % 2) % 1) / 0.50);
            moeda025 = (int)(((((((((N % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) / 0.25);
            moeda010 = (int)((((((((((N % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) % 0.25) / 0.10);
            resto = ((((((((((N % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) % 0.25) % 0.10);
            //moeda005 = (int)(double.Parse(resto.ToString("F2")) / 0.05);
            moeda005 = (int)(((((((((((N % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) % 0.25) % 0.10) / 0.05);
            moeda001 = (int)((((((((((((N % 100) % 50) % 20) % 10) % 5) % 2) % 1) % 0.50) % 0.25) % 0.10) % 0.05) / 0.01);

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2.00");

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
            Console.WriteLine($"{moeda050} moeda(s) de R$ 0.50");
            Console.WriteLine($"{moeda025} moeda(s) de R$ 0.25");
            Console.WriteLine($"{moeda010} moeda(s) de R$ 0.10");
            Console.WriteLine($"{moeda005} moeda(s) de R$ 0.05");
            Console.WriteLine($"{moeda001} moeda(s) de R$ 0.01");
        }
    }
}
