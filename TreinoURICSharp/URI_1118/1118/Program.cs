using System;

namespace _1118
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 1;
            double x, y;

            while (menu != 2)
            {
                x = double.Parse(Console.ReadLine());
                while (x < 0 || x > 10)
                {
                    Console.WriteLine("nota invalida");
                    x = double.Parse(Console.ReadLine());
                }

                y = double.Parse(Console.ReadLine());
                while (y < 0 || y > 10)
                {
                    Console.WriteLine("nota invalida");
                    y = double.Parse(Console.ReadLine());
                }

                double media = (x + y) / 2.00;

                Console.WriteLine($"media = {media.ToString("F2")}");

                // Teste para continuação do programa

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                menu = int.Parse(Console.ReadLine());
                
                while(menu != 1 && menu != 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    menu = int.Parse(Console.ReadLine());
                }

            }            
        }
    }
}
