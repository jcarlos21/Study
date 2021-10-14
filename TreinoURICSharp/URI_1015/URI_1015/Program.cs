using System;

namespace URI_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            float x1, x2, y1, y2;
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            x1 = float.Parse(vet1[0]);
            y1 = float.Parse(vet1[1]);
            x2 = float.Parse(vet2[0]);
            y2 = float.Parse(vet2[1]);

            float distancia = (float)Math.Sqrt(Math.Pow((x2 - x1), 2) + 
                Math.Pow((y2 - y1), 2)); // Aqui foi feito o casting

            Console.WriteLine(distancia.ToString("F4"));
        }
    }
}
