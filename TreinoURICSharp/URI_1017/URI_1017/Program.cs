using System;

namespace URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            double litros = (velocidade * tempo) / 12.0;

            Console.WriteLine(litros.ToString("F3"));
        }
    }
}
