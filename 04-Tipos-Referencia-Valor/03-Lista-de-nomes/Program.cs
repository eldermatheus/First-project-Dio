/* 
static Demo1() {
    void AnterarNome(string[] nomes, string nomeAtual ,string novoNome) {

        for (int i = 0; i < nomes.Length; i++) {
            if (nomes[i] == nomeAtual ) {
                nomes[i] = novoNome;
            }   
        }
    }

    var nomes = new string[] {"José","Maria","Ricardo","Alice","Pedro"};
    Console.WriteLine($@"Lista de nomes inicial: {string.Join(", ",nomes)}");

    Console.WriteLine("Digite o nome que deseja substituir: ");
    var nomeAtual = Console.ReadLine();

    Console.WriteLine("Digite o nome a ser inserido: ");
    var novoNome = Console.ReadLine();

    AnterarNome(nomes, nomeAtual, novoNome);

    Console.WriteLine($@"Lista de nomes inicial: {string.Join(", ",nomes)}");
    }
*/

/*
// Refatorando código. Deixando código mais limpo e localizando pelo índice do array
static Demo1() {

    int LocalizarNome(string[] nomes, string nomeDesejado) {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeDesejado) {
                return i;
            }
        }
        return -1;
    }

    var nomes = new string[] {"José","Maria","Ricardo","Alice","Pedro"};
    Console.WriteLine($@"Lista de nomes inicial: {string.Join(", ",nomes)}");

    Console.WriteLine("Digite o nome que deseja substituir: ");
    var nomeDesejado = Console.ReadLine();

    Console.WriteLine("Digite o nome a ser inserido: ");
    var novoNome = Console.ReadLine();

    int indice = LocalizarNome(nomes, nomeDesejado);

    if (indice >= 0 ) {    
        nomes[indice] = novoNome;
        Console.WriteLine($@"Lista de nomes inicial: {string.Join(", ",nomes)}");
    }
    else 
        Console.WriteLine("O nome não foi localizado!");
}
*/

//Refatorando código. Localizando pelo nome no array

ref string LocalizarNome(string[] nomes, ref string nomeDesejado) {
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeDesejado) {
                return ref nomes[i];
            }
        }
    throw new Exception("Referência não existe!");
}

var nomes = new string[] {"José","Maria","Ricardo","Alice","Pedro"};
Console.WriteLine($@"Lista de nomes inicial: {string.Join(", ",nomes)}");

Console.WriteLine("Digite o nome que deseja substituir: ");
var nomeDesejado = Console.ReadLine();

Console.WriteLine("Digite o nome a ser inserido: ");
var novoNome = Console.ReadLine();

ref string nomeAchado = ref LocalizarNome(nomes, ref nomeDesejado);

if (!string.IsNullOrWhiteSpace(nomeAchado)) {    
    nomeAchado = novoNome;
    Console.WriteLine($@"Lista de nomes inicial: {string.Join(", ",nomes)}");
}
else 
    Console.WriteLine("O nome não foi localizado!");