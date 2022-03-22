using System;

namespace _06 {
    internal class Program {
        static void Main(string[] args) {
            
            int N = int.Parse(Console.ReadLine());
            string[] nome = new string[N];
            int[] idade = new int[N];
            int maiorIdade = 0;
            int indice = 0;

            for (int i = 0; i < N; i++) {

                string[] nomeEIdade = Console.ReadLine().Split(' ');
                nome[i] = nomeEIdade[0];
                idade[i] = int.Parse(nomeEIdade[1]);

                if (idade[i] > maiorIdade) {
                    maiorIdade = idade[i];
                    indice = i;
                }
            }
            Console.WriteLine($"Pessoa mais velha: {nome[indice]}");
        }
    }
}
