namespace Trabalhando_com_Arquivos.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string caminho) {
            var retornoCaminho = Directory.GetDirectories(caminho,"*",SearchOption.AllDirectories); // Buscar em subpastas
            
            foreach (var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivos(string caminho) {
            var retornoArquivos = Directory.GetFiles(caminho,"*.txt",SearchOption.AllDirectories);

            foreach (var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarDiretorios(string caminho) {
            var retorno = Directory.CreateDirectory(caminho); 
            System.Console.WriteLine(retorno.FullName);
        }

        public void DeletarDiretorios(string caminho) {
            Directory.Delete(caminho);         
        }

    }
}