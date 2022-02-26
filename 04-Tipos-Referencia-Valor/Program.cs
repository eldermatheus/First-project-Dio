//Passagem por valor. Resultado: 2
static void PrimeiroAdiciona20(int valor) {
       valor = valor + 20;
}
int valor1 = 2;

Adiciona20(valor1);
Console.WriteLine(valor1);

//Passagem por referência. Resultado: 22
static int Adiciona20(int valor) {
       return valor + 20;
}

int valor2 = 2;

valor2 = Adiciona20(valor2);
Console.WriteLine(valor2);


//Passagem por referência. Resultado: Troca Elder por Matheus
static void TrocarNome(Pessoa p1, string novoNome){
    p1.Nome = novoNome;
}

Pessoa p1 = new Pessoa();
p1.Nome = "Elder";
p1.Idade = 30;
p1.Documento = "1646545";

TrocarNome(p1, "Matheus");
Console.WriteLine(p1.Nome);