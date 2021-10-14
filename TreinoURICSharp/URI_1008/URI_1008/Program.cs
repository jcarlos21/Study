using System;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFunc = int.Parse(Console.ReadLine());
            int horasTrab = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine());

            double salary = horasTrab * valorHora;

            Console.WriteLine($"NUMBER = {numFunc}");
            Console.WriteLine($"SALARY = U$ {salary.ToString("F2")}");
        }
    }
}
