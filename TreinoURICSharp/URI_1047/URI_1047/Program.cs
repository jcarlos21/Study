using System;

namespace URI_1047
{
    class Program
    {
        static void Main(string[] args)
        {

            int horaInicio, horaFinal, duracaoHora, minutoInicio, minutoFinal, duracaoMinuto, duracaoTotal, hora, minuto;
            string[] vet = Console.ReadLine().Split(' ');

            horaInicio = int.Parse(vet[0]);
            minutoInicio = int.Parse(vet[1]);
            horaFinal = int.Parse(vet[2]);
            minutoFinal = int.Parse(vet[3]);

            if (horaInicio < horaFinal)
            {
                duracaoHora = horaFinal - horaInicio;

                duracaoMinuto = minutoFinal - minutoInicio;

                duracaoHora *= 60;
                duracaoMinuto *= 60;

                duracaoTotal = duracaoHora + duracaoMinuto;

                hora = duracaoTotal / 3600;
                minuto = (duracaoTotal % 3600) / 60;
            }
            else
            {
                duracaoHora = 24 - horaInicio + horaFinal;

                duracaoMinuto = minutoFinal - minutoInicio;

                duracaoHora *= (60 * 60);
                duracaoMinuto *= 60;

                duracaoTotal = duracaoHora + duracaoMinuto;

                hora = duracaoTotal / 3600;
                minuto = (duracaoTotal % 3600) / 60;
            }
            
            Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {minuto} MINUTO(S)");
        }
    }
}
