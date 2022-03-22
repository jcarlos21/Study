using System;

namespace _07 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());
            string[] nomeAluno = new string[N];
            double[] nota1 = new double[N]; 
            double[] nota2 = new double[N];
            double[] mediaNotas = new double[N];

            for (int i = 0; i < N; i++) {

                string[] nomesENotas = Console.ReadLine().Split(' ');

                nomeAluno[i] = nomesENotas[0];
                nota1[i] = double.Parse(nomesENotas[1]);
                nota2[i] = double.Parse(nomesENotas[2]);

                mediaNotas[i] = (nota1[i] + nota2[i]) / 2.0;
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++) {
                if (mediaNotas[i] >= 6.0) {
                    Console.WriteLine(nomeAluno[i]);
                }
            }
        }
    }
}
