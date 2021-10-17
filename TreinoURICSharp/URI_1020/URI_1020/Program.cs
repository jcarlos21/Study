using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeDias = int.Parse(Console.ReadLine());
            int ano, mes, dia, resto;

            ano = idadeDias / 365;
            resto = idadeDias % 365;
            mes = resto / 30;
            dia = resto % 30;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");

        }
    }
}
