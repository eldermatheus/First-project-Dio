//Passagem por valor. Resultado: 2
//static void Demonstracao1() {
       static void Adiciona20(int valor) {

              valor = valor + 20;
       }
       
       int valor1 = 2;

       Adiciona20(valor1);

       Console.WriteLine(valor1);
//}


/*
//Passagem por referência. Resultado: 22
static void Demonstracao2() {
       static int Adiciona20(int valor) {
              return valor + 20;
       }

       int valor2 = 2;
       
       valor2 = Adiciona20(valor2);
       
       Console.WriteLine(valor2);
}
*/

/*
//Passagem por referência. Troca um nome por outro.
static void TrocarNome(Pessoa p1, string nomeNovo) {
              p1.Nome = nomeNovo;
}

static void Demonstracao4() {

       Pessoa p1 = new Pessoa();
              p1.Nome = "1234";
              p1.Idade = 30;
              p1.Nome = "Elder";
       
       Pessoa p2 = p1.Clonar();

       TrocarNome(p1, "Matheus");
       
       Console.WriteLine($@"
       Nome do p1 {p1.Nome}
       Nome do p2 {p2.Nome}
       ");
}
*/

/*
//Exceção da String. É Reference Type mas se comporta como Value. Não troca o nome.
static void TrocarNome(string nome, string nomeNovo) {
              nome = nomeNovo;
}

static void Demonstracao5() {

       string nome = "Elder";

       TrocarNome(nome, "Lucas");       

       Console.WriteLine(nome);
}
*/

/* 
//Alterar de par para ímpar
static void MudarParaImpar(int[] pares) {       

       for (int i = 0; i < pares.Length; i++) {

              pares[i] = pares[i] + 1;
       }
}

static void Demonstracao6() {       
       int [] pares = new int[]{0,2,4,6,8};

       MudarParaImpar(pares);

       Console.WriteLine(string.Join(",", pares));
*/