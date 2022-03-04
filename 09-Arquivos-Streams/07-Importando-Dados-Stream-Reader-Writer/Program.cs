CriarCSV();

static void CriarCSV()
{
    var path = Path.Combine(Environment.CurrentDirectory,"src","Saida");

    var pessoas = new List<Pessoa>()
    {
        new Pessoa() 
        {
            Nome = "José da Silva",
            Email = "js@gmail.com",
            Telefone = 123456,
            Nascimento = new DateOnly(year: 1970, month: 2, day: 14)
        },

        new Pessoa() 
        {
            Nome = "Pedro Moura",
            Email = "pm@gmail.com",
            Telefone = 456789,
            Nascimento = new DateOnly(year: 202, month: 4, day: 20)
        },

        new Pessoa() 
        {
            Nome = "Maria Antonia",
            Email = "ma@gmail.com",
            Telefone = 123456,
            Nascimento = new DateOnly(year: 1982, month: 12, day: 4)
        },
    };

    var di = new DirectoryInfo(path);

    if (!di.Exists)
    {
        di.Create();
        path = Path.Combine(path,"users.csv");
    }

    using var sw = new StreamWriter(path);
    sw.WriteLine("nome, email, telefone, nascimento");

    foreach (var pessoa in pessoas)
    {
        var linha = $"{pessoa.Nome}, {pessoa.Email}, {pessoa.Telefone}, {pessoa.Nascimento}";
        sw.WriteLine(linha);
    }
    
}

static void LerCSV(){
    var path = Path.Combine(Environment.CurrentDirectory,"src","Entrada", "users.csv");

    if (File.Exists(path)) 
    {
        using var sr = new StreamReader(path);
        var cabecalho = sr.ReadLine()?.Split(',');

        while(true)
            {
                var registro = sr.ReadLine()?.Split(',');
                if (registro == null) 
                    break; //se a linha lida for nula encerra o loop

                for (int i = 0; i < registro.Length; i++)
                {
                    Console.WriteLine($"{cabecalho?[i]}:{registro[i]}");
                }
            }        
    }
    else 
    {
        Console.WriteLine("O arquivo não existe no diretório");
    }

    Console.WriteLine("Pressione Enter para finalizar");
    Console.ReadKey();
}
public class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Telefone { get; set; }
    public DateOnly Nascimento { get; set; }
}