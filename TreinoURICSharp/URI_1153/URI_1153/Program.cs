using System;

namespace URI_1153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= N; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}
