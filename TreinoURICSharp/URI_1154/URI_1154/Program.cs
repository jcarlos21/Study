using System;

namespace URI_1154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            double soma = 0, idade = 1;

            while (idade > 0)
            {
                idade = int.Parse(Console.ReadLine());
                
                if (idade >= 0)
                {
                    soma = soma + idade;
                    cont++;
                }
            }
            Console.WriteLine((soma / cont).ToString("F2"));
        }
    }
}
