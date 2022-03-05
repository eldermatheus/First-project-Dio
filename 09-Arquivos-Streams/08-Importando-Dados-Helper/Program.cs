using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using Importando_Dados_Helper.Mapping;
using Importando_Dados_Helper.Model;

EscreverCsv();


static void EscreverCsv()
{
    var path = Path.Combine(Environment.CurrentDirectory,"Saida");

    var dir = new DirectoryInfo(path);

    if (!dir.Exists)
    {
        dir.Create();
    }
    
    path = Path.Combine(path, "Lista de Produtos Exportada.csv");    

    var Produtos = new List<Produto>()
    {
        new Produto()
        {
            Nome = "Fritadeira Eletrica",
            Marca = "Mondial",
            Preco = 350,
        },

        new Produto()
        {
            Nome = "Batedeira",
            Marca = "Britania",
            Preco = 120,
        },

        new Produto()
        {
            Nome = "Geladeira",
            Marca = "Consul",
            Preco = 2800,
        }
    };

    using var sr = new StreamWriter(path);

    var csvConfig = new CsvConfiguration(CultureInfo.InstalledUICulture)
    {
        Delimiter = "|"
    }; 
    
    using var CsvWriter = new CsvWriter(sr,csvConfig);
    CsvWriter.WriteRecords(Produtos);
}


static void LerCSVSemCabecalho()
{
    var path = Path.Combine(Environment.CurrentDirectory,"Entrada","Lista de Produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
    {
        throw new FileNotFoundException($"O arquivo {path} não existe!");
    }

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);

    csvReader.Context.RegisterClassMap<ProdutoMap>();

    var registros = csvReader.GetRecords<ProdutoSemCabecalho>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Nome}");
        Console.WriteLine($"marca:{registro.Marca}");
        Console.WriteLine($"preço:{registro.Preco}");
    }
    Console.WriteLine("Pressione Enter para finalizar");
    Console.ReadKey();
}

static void LerCSVComOutroDelimitador()
{
    var path = Path.Combine(Environment.CurrentDirectory,"Entrada","Lista de Produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
    {
        throw new FileNotFoundException($"O arquivo {path} não existe!");
    }

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
        Delimiter = ";"
    };
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Produto>().ToList();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Nome}");
        Console.WriteLine($"marca:{registro.Marca}");
        Console.WriteLine($"preço:{registro.Preco}");
    }
    Console.WriteLine("Pressione Enter para finalizar");
    Console.ReadKey();
}

static void LerCSVComClasse()
{
    var path = Path.Combine(Environment.CurrentDirectory,"Entrada","Produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
    {
        throw new FileNotFoundException($"O arquivo {path} não existe!");
    }

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<Usuario>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.Nome}");
        Console.WriteLine($"email:{registro.Email}");
        Console.WriteLine($"telefone:{registro.Telefone}");
    }
    Console.WriteLine("Pressione Enter para finalizar");
    Console.ReadKey();
}

static void LerCSVComDynamic()
{
    var path = Path.Combine(Environment.CurrentDirectory,"Entrada","Produtos.csv");

    var fi = new FileInfo(path);

    if (!fi.Exists)
    {
        throw new FileNotFoundException($"O arquivo {path} não existe!");
    }

    using var sr = new StreamReader(fi.FullName);
    var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture);
    using var csvReader = new CsvReader(sr, csvConfig);

    var registros = csvReader.GetRecords<dynamic>();

    foreach (var registro in registros)
    {
        Console.WriteLine($"nome:{registro.produto}");
        Console.WriteLine($"marca:{registro.Marca}");
        Console.WriteLine($"preço:{registro.Preco}");
    }
    Console.WriteLine("Pressione Enter para finalizar");
    Console.ReadKey();
}