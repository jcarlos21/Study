using System;

namespace URI_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, raiz1, raiz2;

            string[] cf = Console.ReadLine().Split(' ');

            a = double.Parse(cf[0]);
            b = double.Parse(cf[1]);
            c = double.Parse(cf[2]);

            delta = Math.Pow(b, 2) - 4 * a * c;

            if (a == 0 || delta < 0) {

                Console.WriteLine("Impossivel calcular");

            }
            else { 
                
                raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine($"R1 = {raiz1.ToString("F5")}");
                Console.WriteLine($"R2 = {raiz2.ToString("F5")}");

            }
        }
    }
}
