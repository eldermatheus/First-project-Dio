using Trabalhando_com_Arquivos.Helper;

var caminho = "C:\\Users\\USUARIO\\Documents\\Workspace\\Projetos-Dio-GFT\\10-Poo\\02-Trabalhando-com-Arquivos\\src";
var caminhoPathCombine = Path.Combine(caminho,"Pasta Teste 3");

FileHelper helper = new FileHelper();

//helper.ListarDiretorios(caminho);
//helper.ListarArquivos(caminho);
//helper.CriarDiretorios(caminhoPathCombine);

helper.DeletarDiretorios(caminhoPathCombine);