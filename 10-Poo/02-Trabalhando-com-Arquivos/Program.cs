using Trabalhando_com_Arquivos.Helper;

var caminho = @"C:\Users\elder\Documents\Workspace\Projetos-Dio-GFT\10-Poo\02-Trabalhando-com-Arquivos\src";
var caminhoPathCombine = Path.Combine(caminho,"Pasta Teste 3");
var caminhoArquivo = Path.Combine(caminho,"Criando aquivo de teste.txt");
var listaString = new List<string> {"linha 1","linha 2","linha 3"};
var listaStringAdicionada = new List<string> {"linha 4","linha 5","linha 6"};
var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 1", "Criando aquivo de teste.txt");


FileHelper helper = new FileHelper();
//helper.ListarDiretorios(caminho);
//helper.ListarArquivos(caminho);
//helper.CriarDiretorios(caminhoPathCombine);
//helper.DeletarDiretorios(caminhoPathCombine);
//helper.CriarArquivo(caminhoArquivo, "|Ola|o|teste|deu|certo|");
//helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
//helper.AdicionarTextoStream(caminhoArquivo, listaStringAdicionada);
//helper.LerAquivoStream(caminhoArquivo);
//helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);
//helper.CopiarArquivo(caminhoArquivo, novoCaminhoArquivo, true);


helper.DeletarArquivo(novoCaminhoArquivo, "Criando aquivo de teste.txt");