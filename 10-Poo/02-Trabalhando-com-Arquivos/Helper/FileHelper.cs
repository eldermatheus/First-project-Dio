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
            if (Directory.Exists(caminho)) 
            {
                Directory.Delete(caminho);         
            }
        }

        public void CriarArquivo(string caminho, string conteudo) {
            if (!File.Exists(caminho)) 
            {
                File.WriteAllText(caminho, conteudo);
            }            
        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)  {
            using (var stream = File.CreateText(caminho))
            {
                 foreach (var linha in conteudo)
                {
                    stream.WriteLine(linha);
                }                    
            }
        }    

        public void AdicionarTexto(string caminho, string conteudoAdicionar)
        {
            File.AppendAllText(caminho, conteudoAdicionar);
        }

        public void AdicionarTextoStream(string caminho, List<string> conteudoAdicionar)
        {
            using (var stream = File.AppendText(caminho))
            {
                 foreach (var linha in conteudoAdicionar)
                {
                    stream.WriteLine(linha);
                }                    
            }
        }
    
        public void LerAquivo(string caminho) {
            var conteudo = File.ReadAllLines(caminho);
            
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);        
            }
        }

        public void LerAquivoStream(string caminho) {

            string linha = string.Empty;

            using (var conteudoStream = File.OpenText(caminho))
            {
                while ((linha = conteudoStream.ReadLine())
                != null)
                {
                    System.Console.WriteLine(linha);
                }
            }
        }

        public void MoverArquivo(string caminho, string novoCaminho, bool sobrescrever){
            if (sobrescrever) {
                File.Move(caminho, novoCaminho);
            }
        }
        
        public void CopiarArquivo(string caminho, string novoCaminho, bool sobrescrever){
            if (sobrescrever) {
                File.Copy(caminho, novoCaminho, sobrescrever);
            }            
        }

        public void DeletarArquivo(string caminho, string nome) {

            if ((File.Exists(caminho)) && Path.GetFileName(caminho).Equals(nome)) {
                File.Delete(caminho);
            }
        }
        
    }
}