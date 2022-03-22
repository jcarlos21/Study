using System;

namespace _08 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            double[] altura = new double[N];
            string[] sexo = new string[N];

            int contHomens = 0;
            int contMulheres = 0;
            double somaAlturaMulheres = 0;
            double mediaAlturaMulheres = 0;
            

            for (int i = 0; i < N; i++) {
                string[] idadeSexo = Console.ReadLine().Split(' ');
                altura[i] = double.Parse(idadeSexo[0]);
                sexo[i] = idadeSexo[1];           
            }

            double menorAltura = altura[0];
            double maiorAltura = altura[0];

            for (int i = 0; i < N; i++) {

                if (altura[i] > maiorAltura) {
                    maiorAltura = altura[i];                
                }

                if (altura[i] < menorAltura) {
                    menorAltura = altura[i];
                }

                if(sexo[i] == "F") {
                    somaAlturaMulheres += altura[i];
                    contMulheres++;
                }
                else {
                    contHomens++;
                }
            }

            mediaAlturaMulheres = somaAlturaMulheres / contMulheres;

            Console.WriteLine($"Menor altura = {menorAltura.ToString("F2")}");
            Console.WriteLine($"Maior altura = {maiorAltura.ToString("F2")}");
            Console.WriteLine($"Media das alturas das mulheres = {mediaAlturaMulheres.ToString("F2")}");
            Console.WriteLine($"Numero de homens = {contHomens}");
        }
    }
}
