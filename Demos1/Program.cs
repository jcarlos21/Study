using System.Reflection;

namespace Demos1;

internal class Program {

    static void Demo1 () {
        int a = 5;
        Adicionar20(ref a);
        Console.WriteLine($"O valor de a é {a}");
    }

    static void Demo2 (){
        var nomes = new string[]{"José", "Maria", "Ricardo", "Alice", "Pedro"};
        Console.WriteLine($@"A lista de nomes é:
            {string.Join(", \n", nomes)}
        ");


        System.Console.WriteLine("Digite o nome a ser substituido: ");
        var nome = Console.ReadLine();
        System.Console.WriteLine("Digite o nome novo: ");
        var nomeNovo = Console.ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        Console.WriteLine($@"A lista de nomes alterada é:
            {string.Join(", \n", nomes)}
        ");
    }

    static void Adicionar20 (ref int a) {
        a += 20;
    }

    static void AlterarNome (string[] nomes, string nome, string nomeNovo) {
        // Algoritmo de busca linear
        for (int i = 0; i < nomes.Length; i++) {
            if (nomes[i] == nome) {
                nomes[i] = nomeNovo;
            }
        }
    }

    static ref string LocalizarNome (string[] nomes, string nome){
        for (int i = 0; i < nomes.Length; i++) {
            if (nomes[i] == nome){
                return ref nomes[i];
            }
        }
        throw new Exception("Nome não encontrado!");
    }

    static void Main(string[] args) {
        var nomes = new string[]{"José", "Maria", "Ricardo", "Alice", "Pedro"};
        Console.WriteLine($@"A lista de nomes é:
            {string.Join(", \n", nomes)}
        ");


        System.Console.WriteLine("Digite o nome a ser substituido: ");
        var nome = Console.ReadLine();
        System.Console.WriteLine("Digite o nome novo: ");
        var nomeNovo = Console.ReadLine();

        // AlterarNome(nomes, nome, nomeNovo);

        ref var nomeEncontrado = ref LocalizarNome(nomes, nome);

        if (!string.IsNullOrWhiteSpace(nomeEncontrado)) {
            nomeEncontrado = nomeNovo;

            Console.WriteLine($@"A lista de nomes alterada é:
                {string.Join(", \n", nomes)}
            ");
        }
        else{
            Console.WriteLine("Nome não localizado!");
        }
    }
}