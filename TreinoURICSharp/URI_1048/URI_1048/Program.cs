using System;

namespace URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario = 0, percentual;

            salario = double.Parse(Console.ReadLine());

            if (salario >= 0 && salario <= 400.00)
            {
                percentual = 15;
            }
            else if (salario <= 800.00)
            {
                percentual = 12;
            }
            else if (salario <= 1200.00)
            {
                percentual = 10;
            }
            else if (salario <= 2000.00)
            {
                percentual = 7;
            }
            else
            {
                percentual = 4;
            }

            reajuste = salario * (percentual / 100.00);
            novoSalario = salario + reajuste;

            Console.WriteLine($"Novo salario: {novoSalario.ToString("F2")}");
            Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");
            Console.WriteLine($"Em percentual: {percentual} %");
        }
    }
}
