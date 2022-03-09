using App_Cadastro;

string opcaoEscolhida = ObterOpcaoUsuario();

SerieRepositorio repositorio = new SerieRepositorio();

while (opcaoEscolhida != "X")
{

    switch (opcaoEscolhida)
    {
        case "1": Listar(repositorio); break;
        case "2": Inserir(repositorio); break;
        case "3": Atualizar(repositorio); break;
        case "4": Excluir(repositorio); break;
        case "5": Visualizar(repositorio); break;
        case "C": Console.Clear(); break;

        default:
            throw new Exception("Escolha uma opção válida!");
    }
    opcaoEscolhida = ObterOpcaoUsuario();
}

//Métodos implementados
static void Listar(SerieRepositorio repositorio)
{
    var lista = repositorio.Listar();

    if (lista.Count == 0)
    {
        Console.Clear();
        Console.WriteLine("Lista de séries vazia!");
    }
    else
        foreach (var serie in lista)
        {
            if (!serie.RetornarExcluido())
            {
                Console.Write("Excluído! -- ");
            }
            Console.WriteLine($"ID: {serie.RetornarId()} Título: {serie.RetornarTitulo()}");
        }
}

static void Inserir(SerieRepositorio repositorio)
{
    Console.WriteLine("Vamos inserir uma nova série! ");

    int countEnum = Enum.GetValues(typeof(Genero)).Length;

    for (int i = 1; i <= countEnum; i++)
    {
        Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
    }

    Console.WriteLine("Digite o gênero dentre as opções passadas");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o título da série");
    string entradaTitulo = Console.ReadLine();

    Console.WriteLine("Digite o ano da série");
    int novoAno = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a descriçao da série");
    string entradaDescricao = Console.ReadLine();

    Serie novaSerie = new Serie(
        id: repositorio.GetProximoId(),
        genero: (Genero)entradaGenero,
        titulo: entradaTitulo,
        ano: novoAno,
        descricao: entradaDescricao);

    repositorio.Inserir(novaSerie);
}

static void Atualizar(SerieRepositorio repositorio)
{
    Console.WriteLine("Digite o ID da série:");

    int indiceSerie = int.Parse(Console.ReadLine());

    int countEnum = Enum.GetValues(typeof(Genero)).Length;

    for (int i = 1; i <= countEnum; i++)
    {
        Console.WriteLine($"{i}-{Enum.GetName(typeof(Genero), i)}");
    }

    Console.WriteLine("Digite o gênero dentre as opções passadas");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o título da série");
    string entradaTitulo = Console.ReadLine();

    Console.WriteLine("Digite o ano da série");
    int novoAno = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite a descriçao da série");
    string entradaDescricao = Console.ReadLine();

    Serie novaSerie = new Serie(
        id: indiceSerie,
        genero: (Genero)entradaGenero,
        titulo: entradaTitulo,
        ano: novoAno,
        descricao: entradaDescricao);

    repositorio.Atualizar(indiceSerie, novaSerie);
}

static void Excluir(SerieRepositorio repositorio)
{
    Console.WriteLine("Digite o ID da série:");

    int indiceSerie = int.Parse(Console.ReadLine());

    repositorio.Excluir(indiceSerie);
}

static void Visualizar(SerieRepositorio repositorio)
{
    Console.WriteLine("Digite o ID da série:");
    
    int indiceSerie = int.Parse(Console.ReadLine());

    var serie = repositorio.RetornarPorId(indiceSerie);

    Console.WriteLine(serie);
}

static string ObterOpcaoUsuario()
{
    Console.WriteLine();
    Console.WriteLine("=== Lista de Séries ===");
    Console.WriteLine("Informe o opção escolhida:");

    Console.WriteLine("1 - Lista séries");
    Console.WriteLine("2 - Inserir nova série");
    Console.WriteLine("3 - Atualizar série");
    Console.WriteLine("4 - Excluir séries");
    Console.WriteLine("5 - Visualizar séries");
    Console.WriteLine("L - Limpar Tela");
    Console.WriteLine("X - Sair");
    Console.WriteLine();

    string opcaoUsuario = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return opcaoUsuario;
}