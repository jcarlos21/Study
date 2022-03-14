using System;
using System.Linq;

namespace DESAFIO3_DIO {
    internal class Program {
        static void Main(string[] args) {           
            
            int testes = int.Parse(Console.ReadLine());            

            for (int i = 0; i < testes; i++) {

                string[] vet = Console.ReadLine().Split(' ');
                string[] listaCompras = vet.Distinct().ToArray();

                Array.Sort(listaCompras);
                string lista = String.Join(" ", listaCompras);
                Console.WriteLine(lista);

            }
        }
    }
}
