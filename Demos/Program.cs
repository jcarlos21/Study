using static System.Console;
public class Program {

    // __________________________________________________Minhas Demos______________________________________________________________
    static void Demo1 () {
        int a = 2;
        a = Adicionar20(a);
        WriteLine($"O valor da variavel a é {a}");
    }

    static void Demo2 () {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1;  // O que p2 recebe é a referência de p1. Ou seja, tudo for alterado em p1 é alterado em p2.

        Pessoa p3 = new Pessoa();  // p3 é uma nova referência. Os valores de p1 foram copiados para os atributos de p3.
        p3.Documento = p1.Documento;
        p3.Nome = p1.Nome;
        p3.Idade = p1.Idade;

        Pessoa p4 = p1.Clone();

        TrocarNome(p1, "José");

        WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        O nome de p3 é: {p3.Nome}
        O nome de p4 é: {p4.Nome}
        ");
    }

    static void Demo3 () {
        StructPessoa p1 = new StructPessoa {
            Documento = "1234",
            Idade = 30,
            Nome = "Ricardo"
        };

        StructPessoa p = default;  // Outra possibilidade de construção da Struct
        p.Nome = "João";
        p.Idade = 50;
        p.Documento = "5678";

        var p2 = p1;

        p1 = TrocarNome(p2, "João");

        WriteLine($@"
            Nome do p1 {p1.Nome}
            Nome do p2 {p2.Nome}
        ");
    }

    static void Demo4 () {  
        string nome = "Ricardo";

        TrocarNome (nome, "José");

        WriteLine($"O novo nome é {nome}");      
    }
    
    static void Demo5 () {
        int[] pares = new int[]{0, 2, 4, 6, 8};

        // int pares1 = new int ();  coloquei isso aqui apenas para comparar o array com o int

        MudarParaImpar(pares);

        WriteLine($"Os ímpares {string.Join(",", pares)}");
    }

    static void Demo6 () {
        
        int[] numeros = new int[]{0, 2, 4, 6, 8};
        WriteLine($"Digite o número que gostaria de encontrar: ");
        var numero = int.Parse(ReadLine());

        var idxEncontrado = EncontrarNumero(numeros, numero);

        if (idxEncontrado >= 0){
            WriteLine($"O número digitado está na posição {idxEncontrado}");
        }
        else {
            WriteLine("O número digitado não foi encontrado.");
        }
    }

    static void Demo7 () {
        List<Pessoa> pessoas = new List<Pessoa>() {  // Forma de criar uma lista com o tipo (ou classe) que criamos (tipo pessoa)
            
            new Pessoa () {Nome = "Ricardo"},  // Poderíamos colocar também os outros atributos (Idade, Documento).
            new Pessoa () {Nome = "José"},
            new Pessoa () {Nome = "Maria"},
            new Pessoa () {Nome = "Fabiana"},
            new Pessoa () {Nome = "Eduardo"}

        };

        WriteLine("Digite a pessoa que gostaria de localizar: ");
        var nome = ReadLine();
        var pessoa = new Pessoa (){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if (encontrado) {
            WriteLine("Pessoa localizada!");
        }
        else {
            WriteLine("Pessoa não localizada!");
        }
    }

    // __________________________________________________Métodos pedidos___________________________________________________________
    static int Adicionar20 (int x) {  // x é uma cópia do que será passado como argumento da função Adiciona20
        return x + 20;
    }
    static void TrocarNome (Pessoa p1, string nomeNovo) {  // p1 é uma referência para a instânica. Tudo que for alterado aqui será alterado na referência que foi passada.
        p1.Nome = nomeNovo;
    }
    static StructPessoa TrocarNome (StructPessoa p1, string nomeNovo) {
        p1.Nome = nomeNovo;
        return p1;
    }
    static void TrocarNome (string nome, string nomeNovo) {
        nome = nomeNovo;
    }
    static void MudarParaImpar (int[] pares) {
        for (int i = 0; i < pares.Length; i++) {
            pares[i] = pares[i] + 1;
        }
    }
    static int EncontrarNumero (int[] numeros, int numero){
        for (int i = 0; i < numeros.Length; i++) {
            if (numeros[i] == numero) {
                return i;
            }
        }
        return -1;
    }

    static bool EncontrarPessoa (List<Pessoa> pessoas, Pessoa pessoa) {
        foreach (var item in pessoas) {
            if (item.Nome == pessoa.Nome) {  // A comparação é feita por referência também.
                return true;
            }
        }
        return false;
    }

    static bool EncontrarPessoa (List<StructPessoa> pessoas, StructPessoa pessoa) {
        foreach (var item in pessoas) {
            if (item.Equals(pessoa)) {
                return true;
            }
        }
        return false;
    }


    // __________________________________________________Programa principal________________________________________________________
    public static void Main() {

        List<StructPessoa> pessoas = new List<StructPessoa>() {  // Forma de criar uma lista com o tipo (ou classe) que criamos (tipo pessoa)
            
            new StructPessoa () {Nome = "Ricardo"},  // Poderíamos colocar também os outros atributos (Idade, Documento).
            new StructPessoa () {Nome = "José"},
            new StructPessoa () {Nome = "Maria"},
            new StructPessoa () {Nome = "Fabiana"},
            new StructPessoa () {Nome = "Eduardo"}

        };

        WriteLine("Digite a pessoa que gostaria de localizar: ");
        var nome = ReadLine();
        var pessoa = new StructPessoa (){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);

        if (encontrado) {
            WriteLine("Pessoa localizada!");
        }
        else {
            WriteLine("Pessoa não localizada!");
        }

    }
}