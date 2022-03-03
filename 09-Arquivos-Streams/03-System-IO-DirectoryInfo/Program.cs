var path = @"C:\Users\elder\Documents\Workspace\Projetos-Dio-GFT\09-Arquivos-Streams\02-System-IO-Move-Copy";
//LerDiretorios(path);
LerArquivos(path);

static void LerDiretorios(string path) {

    if (Directory.Exists(path)) {

        var diretorios = Directory.GetDirectories(path,"*", SearchOption.AllDirectories);

        foreach (var item in diretorios)
        {
            var dirInfo = new DirectoryInfo(item);
            Console.WriteLine($"[Nome]:{dirInfo.Name}");
            Console.WriteLine($"[Raiz]:{dirInfo.Root}");
            
            // Verifica se o diretório pai é diferente de nulo antes de acessar a propriedade
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Parent]:{dirInfo.Parent}");
        }

    } else
        Console.WriteLine($"O diretório {path} informado não existe!");
}

static void LerArquivos(string path) {
    
    var arquivos = Directory.GetFiles(path,"*",SearchOption.AllDirectories);

    foreach (var arquivo in arquivos) {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]:{fileInfo.Name}");
        Console.WriteLine($"[Tamanho]:{fileInfo.Length}");
        Console.WriteLine($"[Ultimo Acesso]:{fileInfo.LastAccessTime}");
    }
}