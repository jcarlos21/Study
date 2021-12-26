using System;

namespace URI_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[3];

            vet[0] = Console.ReadLine();
            vet[1] = Console.ReadLine();
            vet[2] = Console.ReadLine();

            switch (vet[0]) {
                case "vertebrado":

                    switch (vet[1])
                    {
                        case "ave":

                            if (vet[2] == "carnivoro")
                            {
                                Console.WriteLine("aguia");
                            }
                            else if (vet[2] == "onivoro")
                            {
                                Console.WriteLine("pomba");
                            }
                            break;

                        case "mamifero":

                            if (vet[2] == "onivoro")
                            {
                                Console.WriteLine("homem");
                            }
                            else if (vet[2] == "herbivoro")
                            {
                                Console.WriteLine("vaca");
                            }
                            break;
                    }
                    
                    break;

                case "invertebrado":

                    switch (vet[1])
                    {
                        case "inseto":

                            if (vet[2] == "hematofago")
                            {
                                Console.WriteLine("pulga");
                            }
                            else if (vet[2] == "herbivoro")
                            {
                                Console.WriteLine("lagarta");
                            }
                            break;

                        case "anelideo":

                            if (vet[2] == "hematofago")
                            {
                                Console.WriteLine("sanguessuga");
                            }
                            else if (vet[2] == "onivoro")
                            {
                                Console.WriteLine("minhoca");
                            }
                            break;
                    }

                    break;
            }
        }
    }
}
