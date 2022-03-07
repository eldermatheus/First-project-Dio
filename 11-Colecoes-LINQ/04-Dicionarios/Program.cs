AcessarTratado();

//Escrevendo os valores do dicionario
static void Escrever() {

    Dictionary<int,string> estados = new Dictionary<int, string>() {{1,"SE"}, {2,"MG"}, {3,"SP"}};
    
    foreach (var item in estados)
    {
        System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
    }
}

//Localizando valores no dicionario
static void Localizar() {

    Dictionary<int,string> estados = new Dictionary<int, string>() {{1,"SE"}, {2,"MG"}, {3,"SP"}};
    estados.Add(4,"BA");

    int valorProcurado = 2;
    System.Console.WriteLine(estados[valorProcurado]);    
}

//Atualizar valor pela chave
static void Atualizar() {

    Dictionary<int,string> estados = new Dictionary<int, string>() {{1,"SE"}, {2,"MG"}, {3,"SP"}};
    estados.Add(4,"BA");

    int valorProcurado = 2;

    estados[valorProcurado] = "AL";

    foreach (var item in estados)
    {
        System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
    }    
}

//Remover valor pela chave
static void Remover() {
    
    Dictionary<int,string> estados = new Dictionary<int, string>() {{1,"SE"}, {2,"MG"}, {3,"SP"}};
    estados.Add(4,"BA");

    int valorProcurado = 2;

    estados.Remove(valorProcurado);    

    foreach (var item in estados)
    {
        System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
    }
}

//Acessando chave inexistente tratando exception
static void AcessarTratado() {

    Dictionary<int,string> estados = new Dictionary<int, string>() {{1,"SE"}, {2,"MG"}, {3,"SP"}};
    estados.Add(4,"BA");

    int valorProcurado = 7;

    //var teste = estados[7];

    if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
    {
        System.Console.WriteLine(estadoEncontrado);
    } 
    else   {
        System.Console.WriteLine($"A chave {valorProcurado} não existe nesse dicionário!");
    }
}