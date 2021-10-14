using System;

namespace URI_1011 {

    class Program {

        static void Main(string[] args) {

            double raio = double.Parse(Console.ReadLine());
            double numPi = 3.14159;
            double volumeEsfera = (4 / 3.0) * numPi * (Math.Pow(raio, 3));

            Console.WriteLine($"VOLUME = {volumeEsfera.ToString("F3")}");

        }
    }
}
