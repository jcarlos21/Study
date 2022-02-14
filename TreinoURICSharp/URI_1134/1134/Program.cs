using System;

namespace _1134
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int combustivel = 0, contAlcool = 0, contGasolina = 0, contDiesel = 0;

            while (combustivel != 4)
            {
                if (combustivel == 1) {
                    contAlcool++;
                }
                else if (combustivel == 2) {
                    contGasolina++;
                }
                else if (combustivel == 3) {
                    contDiesel++;
                }

                combustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {contAlcool}");
            Console.WriteLine($"Gasolina: {contGasolina}");
            Console.WriteLine($"Diesel: {contDiesel}");
        }
    }
}
