var path = @"C:\Users\elder\Documents\Workspace\Projetos-Dio-GFT\09-Arquivos-Streams\02-System-IO-Move-Copy\Globo";
using var fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine("Pressione Enter para finalizar...");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"Arquivo renomeado de {e.OldName} para {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi deletado o arquivo {e.Name}");
}
