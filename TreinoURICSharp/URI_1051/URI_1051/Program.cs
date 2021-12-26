using System;

namespace URI_1051 {
    class Program {
        static void Main(string[] args) {
            double salario = double.Parse(Console.ReadLine());
            double totalDevido = 0, auxiliar;

            if (salario < 2000.01) {
                Console.WriteLine("Isento");
            }
            else if (salario < 3000.01) {

                auxiliar = salario - 2000.00;
                totalDevido = (auxiliar * 0.08);
                Console.WriteLine("R$ " + totalDevido.ToString("F2"));

            }
            else if (salario < 4500.01) {

                auxiliar = salario - 3000.00;
                totalDevido = (auxiliar * 0.18);
                salario = salario - auxiliar;
                auxiliar = salario - 2000.00;
                totalDevido = totalDevido + (auxiliar * 0.08);
                Console.WriteLine("R$ " + totalDevido.ToString("F2"));
            }
            else {

                auxiliar = salario - 4500.00;
                totalDevido = (auxiliar * 0.28);
                salario = salario - auxiliar;
                auxiliar = salario - 3000.00;
                totalDevido = totalDevido + (auxiliar * 0.18);
                salario = salario - auxiliar;
                auxiliar = salario - 2000.00;
                totalDevido = totalDevido + (auxiliar * 0.08);

                Console.WriteLine("R$ " + totalDevido.ToString("F2"));
            }
        }
    }
}
