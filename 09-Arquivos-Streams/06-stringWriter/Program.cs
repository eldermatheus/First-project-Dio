using System.Text;

string textReaderText = "TextReader é a classe base abstrata " +
        "de StreamReader e StringReader, que lê caracteres " +
        "de streams e string, respectivamente. \n\n" +

        "Crie uma instância de TextReader para abrir um arquivo de texto " +
        "para ler um intervalo especificado de carateres " +
        "ou para criar um leitor baseador em um fluxo existente. \n\n";

string linha, paragrafo = null;

var sr = new StringReader(textReaderText);

while(true)
{
    linha = sr.ReadLine();
    if (linha != null)
    {
        paragrafo += linha + " ";
    }
    else 
    {
        paragrafo += '\n';
        break;
    }
}

Console.WriteLine($"Texto modificado: {paragrafo}");

int caractereLido;
char caractereConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while (true) 
{
    caractereLido = sr.Read();

    if (caractereLido == -1) 
        break;
    caractereConvertido = Convert.ToChar(caractereLido);

    if (caractereConvertido == '.')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caractereConvertido);
    }
    
    Console.WriteLine($"Texto armazenado no StringWriter: {sw.ToString()}");
    Console.ReadKey();
}