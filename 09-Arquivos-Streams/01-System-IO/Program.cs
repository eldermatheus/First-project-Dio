/* static Demo_1 {

// Formas de criação de arquivo
var path = Environment.CurrentDirectory + "\\teste.txt";
var path2 = Path.Combine(Environment.CurrentDirectory,"teste.txt");
var path3 = Path.Combine("C:\\Users\\USUARIO\\Desktop","teste.txt");

//Criando arquivo
File.Create(path2);

// Criando arquivo e passando algo para ser escrito
var sw = File.CreateText(path2);
    sw.WriteLine("Linha 1 do arquivo");
    sw.WriteLine("Linha 2 do arquivo");
    sw.WriteLine("Linha 3 do arquivo");
    sw.Flush(); // Realiza a descarga de memória efetuando a escrita
}
*/

//* static Demo_2 {
Console.WriteLine("Digite o nome do arquivo: ");

var nome = Console.ReadLine();

nome = LimparNome(nome);

var path = Path.Combine(Environment.CurrentDirectory,$"{nome}.txt");

CriarArquivo(path);

Console.WriteLine("Digite enter para finalizar");
Console.ReadLine();

static string LimparNome(string nome){
    foreach (var caracter in Path.GetInvalidPathChars()){
        nome = nome.Replace(caracter,'-');
    }
    return nome;
}

static void CriarArquivo(string path) {
    try  {
        using var sw = File.CreateText(path);    
            sw.WriteLine("Linha 1 do arquivo");
            sw.WriteLine("Linha 2 do arquivo");
            sw.WriteLine("Linha 3 do arquivo");
            // O "using" descarta a necessidade do Flush();
    }
    catch {
        Console.WriteLine("Nome do arquivo inválido!");
    }
}