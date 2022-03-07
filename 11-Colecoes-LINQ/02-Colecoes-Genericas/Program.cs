using Colecoes_Genericas;

AdicionarNoComeco();

static void AdicionarNoComeco() {
    OperacoesLista opLista = new OperacoesLista();    
    List<string> estados = new List<string>() {"AL", "MT"};

    estados.Insert(1,"RJ");
    opLista.ImprimirListaString(estados);
}

static void AdicionarColecao() {
    OperacoesLista opLista = new OperacoesLista();    
    List<string> estados = new List<string>() {"AL", "MT"};
    string[] estadosArray = new string[2] {"SC","MG"};

    estados.AddRange(estadosArray);
    opLista.ImprimirListaString(estados);
}

static void Remover(){
    
    OperacoesLista opLista = new OperacoesLista();    
    List<string> estados = new List<string>();
    
    estados.Add("SE");
    estados.Add("SP");
    estados.Add("BA");
    opLista.ImprimirListaString(estados);

    estados.Remove("SP");
    System.Console.WriteLine("Nova lista:");
    opLista.ImprimirListaString(estados);
}