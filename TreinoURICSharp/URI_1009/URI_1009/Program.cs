using System;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double salary = double.Parse(Console.ReadLine());
            double totalVendas = double.Parse(Console.ReadLine());

            double comission = totalVendas * 0.15;

            double total = salary + comission;

            Console.WriteLine($"TOTAL = R$ {total.ToString("F2")}");
        }
    }
}
