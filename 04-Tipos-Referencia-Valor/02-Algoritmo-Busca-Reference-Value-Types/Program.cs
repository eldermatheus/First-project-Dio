/* Demostração de busca número
//Buscar linear
static int Buscar(int[] numeros, int numeroBuscado) {
    for (int i = 0; i < numeros.Length; i++) {
        if (numeros[i] == numeroBuscado) {
            return i;
        }        
    }
    return -1;
}

int[] numeros = new int[] {0,2,4,6,8};
Console.WriteLine($"Digite o número que deseja buscar");
int numeroBuscado = int.Parse(Console.ReadLine());

//Armezena posicao retornada pelo algoritmo de busca
int posicao = Buscar(numeros, numeroBuscado);

//Tratamento para o índice negativo não encontrado
if (posicao < 0) {
    Console.WriteLine($"O número não está no array!");
} else
    Console.WriteLine($"O número está na posicao {posicao}");

*/

//Demonstração de busca pessoa por nome
//Buscar linear
static int Buscar(List<Pessoa> pessoas, Pessoa pessoa) {
    
    foreach (var item in pessoas)
    {
        if (item.Nome == pessoa.Nome){            
              return pessoas.IndexOf(item);
        }
    }
    return -1;

}

List<Pessoa> pessoas = new List<Pessoa>() {
    new Pessoa() {Nome = "Maria"},
    new Pessoa() {Nome = "Joao"},
    new Pessoa() {Nome = "Elder"},
    new Pessoa() {Nome = "Julia"},    
};

Console.WriteLine($"Digite a pessoa que deseja buscar");
var nome = Console.ReadLine();
var pessoa = new Pessoa(){Nome = nome};
var posicao = Buscar(pessoas, pessoa);

if (posicao < 0) {
    Console.WriteLine($"A pessoa não está na lista!");
} else
    Console.WriteLine($"A pessoa está localizada na posição {posicao} da lista.");
