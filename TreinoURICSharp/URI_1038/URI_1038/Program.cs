using System;

namespace URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtde;

            string[] vet = Console.ReadLine().Split();
            cod = int.Parse(vet[0]);
            qtde = int.Parse(vet[1]);

            switch (cod)
            {
                case 1:
                    Console.WriteLine($"Total: R$ {(qtde * 4.00).ToString("F2")}");
                    break;

                case 2:
                    Console.WriteLine($"Total: R$ {(qtde * 4.50).ToString("F2")}");
                    break;

                case 3:
                    Console.WriteLine($"Total: R$ {(qtde * 5.00).ToString("F2")}");
                    break;

                case 4:
                    Console.WriteLine($"Total: R$ {(qtde * 2.00).ToString("F2")}");
                    break;

                case 5:
                    Console.WriteLine($"Total: R$ {(qtde * 1.50).ToString("F2")}");
                    break;
            }
        }
    }
}
