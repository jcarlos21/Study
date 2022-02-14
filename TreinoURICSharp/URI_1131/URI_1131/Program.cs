using System;

namespace URI_1131
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grenal = 1, contGrenal = 0, empate = 0, golsGremio = 0, golsInter = 0, contGremio = 0, contInter = 0;
            string[] gols;

            while (grenal != 2)
            {
                contGrenal++;

                gols = Console.ReadLine().Split(' ');

                golsInter = int.Parse(gols[0]);
                golsGremio = int.Parse(gols[1]);

                if (golsGremio > golsInter)
                {
                    contGremio++;
                }
                else if (golsInter > golsGremio)
                {
                    contInter++;
                }
                else
                {
                    empate++;
                }

                // Continuação do grenal
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                grenal = int.Parse(Console.ReadLine());
                while (grenal != 1 && grenal != 2)
                {
                    Console.WriteLine("Novo grenal (1-sim 2-nao)");
                    grenal = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine($"{contGrenal} grenais");
            Console.WriteLine($"Inter:{contInter}");
            Console.WriteLine($"Gremio:{contGremio}");
            Console.WriteLine($"Empates:{empate}");
            if(golsGremio > golsInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Inter venceu mais");
            }
        }
    }
}
