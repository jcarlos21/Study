using System;

namespace _09 {
    internal class Program {
        static void Main(string[] args) {

            int N = int.Parse(Console.ReadLine());

            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            int lucroAbaixo10PorCento = 0;
            int lucro10E20PorCento = 0;
            int lucroAcima20PorCento = 0;

            double precoTotalCompra = 0.0;
            double precoTotalVenda = 0.0;

            for (int i = 0; i < N; i++) {

                string[] produtosEPrecos = Console.ReadLine().Split(' ');
                precoCompra[i] = double.Parse(produtosEPrecos[1]);
                precoVenda[i] = double.Parse(produtosEPrecos[2]);

                double precoPercentualLucro = (precoVenda[i] - precoCompra[i]) / precoCompra[i];

                if (precoPercentualLucro < 0.10) {
                    lucroAbaixo10PorCento++;
                }
                else if (precoPercentualLucro <= 0.20 && precoPercentualLucro >= 0.10) {
                    lucro10E20PorCento++;
                }
                else {
                    lucroAcima20PorCento++;
                }

                precoTotalCompra += precoCompra[i];
                precoTotalVenda += precoVenda[i];

            }

            double lucroTotal = precoTotalVenda - precoTotalCompra;

            Console.WriteLine($"Lucro abaixo de 10%: {lucroAbaixo10PorCento}");
            Console.WriteLine($"Lucro entre 10% e 20%: {lucro10E20PorCento}");
            Console.WriteLine($"Lucro acima de 20%: {lucroAcima20PorCento}");
            Console.WriteLine($"Valor total de compra: {precoTotalCompra.ToString("F2")}");
            Console.WriteLine($"Valor total de venda: {precoTotalVenda.ToString("F2")}");
            Console.WriteLine($"Lucro total: {lucroTotal.ToString("F2")}");
        }
    }
}
