using System;

namespace URI_1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, hour, minute, seconds, horas, minutos, segundos;

            string[] incio = Console.ReadLine().Split(' ');
            string[] time1 = Console.ReadLine().Split(' ');         
                       
            string[] fim = Console.ReadLine().Split(' ');
            string[] time2 = Console.ReadLine().Split(' ');

            dias = int.Parse(fim[1]) - int.Parse(incio[1]);

            hour = int.Parse(time2[0]) - int.Parse(time1[0]);
            minute = int.Parse(time2[2]) - int.Parse(time1[2]);
            seconds = int.Parse(time2[4]) - int.Parse(time1[4]);

            // Horas:
            if (hour < 0) {
                horas = 24 + hour;
                dias = dias - 1;
            } else {
                horas = hour;
            }

            // Minutos:
            if (minute < 0) {
                minutos = 59 + minute;
            } else {
                minutos = minute;
            }

            // Segundos:
            if (seconds < 0) {
                segundos = 59 + seconds;
            } else {
                segundos = seconds;
            }

            Console.WriteLine($"{dias} dia(s)");
            Console.WriteLine($"{horas} hora(s)");
            Console.WriteLine($"{minutos} minuto(s)");
            Console.WriteLine($"{segundos} segundo(s)");

        }
    }
}
