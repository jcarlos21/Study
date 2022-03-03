using System;

namespace URI_1079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            float n1, n2, n3, media;
            string[] vet;

            for (int i = 0; i < N; i++)
            {
                vet = Console.ReadLine().Split(' ');
                n1 = float.Parse(vet[0]);
                n2 = float.Parse(vet[1]);
                n3 = float.Parse(vet[2]);

                media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;

                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}
