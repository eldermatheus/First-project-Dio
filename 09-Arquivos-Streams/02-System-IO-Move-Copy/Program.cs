CriarDiretorioGlobo();
CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory,"Brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory,"Globo","America do Sul","Brasil","Brasil.txt");

MoverArquivo(origem, destino);

static void CriarArquivo() {

    var path = Path.Combine(Environment.CurrentDirectory,"Brasil.txt");

    if (!File.Exists(path)) {
        using var sw = File.CreateText(path);
        sw.WriteLine("População Atual: 220M");
        sw.WriteLine("Numero de Federações: 27");
        sw.WriteLine("Data da Última Contagem: 02/03/2022");                
    }
}

static void CopiarArquivo(string pathOrigem, string pathDestino) {

    if (!File.Exists(pathOrigem)) {        
        Console.WriteLine("O arquivo não existe na origem!");    
        return;        
    }
    else if (File.Exists(pathDestino)) {
        Console.WriteLine("O arquivo já existe no destino!");
        return;
    } else 
    
    File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino) {

    if (!File.Exists(pathOrigem)) {        
        Console.WriteLine("O arquivo não existe na origem!");    
        return;
    }
    else if (File.Exists(pathDestino)) {
        Console.WriteLine("O arquivo já existe no destino!");
        return;
    } else 
    
    File.Move(pathOrigem, pathDestino);
}

static void CriarDiretorioGlobo() {
    
    var path = Path.Combine(Environment.CurrentDirectory,"Globo");

    if (!Directory.Exists(path)) {      
        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("America do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("America Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("America do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Mexico");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Jamaica");
        dirAmCentral.CreateSubdirectory("Costa Rica");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Uruguai");
    }
}