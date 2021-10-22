using System;

namespace URI_1046
{
    class Program
    {
        static void Main(string[] args)
        {

            int horaInicio, horaFinal, duracao;
            string[] vet = Console.ReadLine().Split();

            horaInicio = int.Parse(vet[0]);
            horaFinal = int.Parse(vet[1]);

            if (horaInicio < horaFinal)
            {
                duracao = horaFinal - horaInicio;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
            else
            {
                duracao = 24 - horaInicio + horaFinal;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
        }
    }
}
