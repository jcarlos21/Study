using System;

namespace URI_1061_Professor
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1, x1, y1, z1, w2, x2, y2, z2, w, x, y, z, inicio, fim, duracao, resto;

            // Primeira linha de dados das primeiras informações
            string[] dados = Console.ReadLine().Split(' ');
            w1 = int.Parse(dados[1]);

            // Segunda linha de dados das primeiras informações
            dados = Console.ReadLine().Split();
            x1 = int.Parse(dados[0]);
            y1 = int.Parse(dados[2]);
            z1 = int.Parse(dados[4]);

            // Primeira linha de dados das segundas informações
            dados = Console.ReadLine().Split(' ');
            w2 = int.Parse(dados[1]);

            // Segunda linha de dados das segundas informações
            dados = Console.ReadLine().Split();
            x2 = int.Parse(dados[0]);
            y2 = int.Parse(dados[2]);
            z2 = int.Parse(dados[4]);

            inicio = (w1-1) * 24 * 60 * 60 + x1 * 60 * 60 + y1 * 60 + z1; // Também dá certo apenas com w1 e w2 sem o -1.
            fim = (w2-1) * 24 * 60 * 60 + x2 * 60 * 60 + y2 * 60 + z2;

            duracao = fim - inicio;

            w = duracao / (24 * 60 * 60);
            resto = duracao % (24 * 60 * 60);
            x = resto / (60 * 60);
            resto = resto % (60 * 60);
            y = resto / 60;
            z = resto % 60;

            Console.WriteLine(w + " dia(s)");
            Console.WriteLine(x + " hora(s)");
            Console.WriteLine(y + " minuto(s)");
            Console.WriteLine(z + " segundo(s)");

        }
    }
}
