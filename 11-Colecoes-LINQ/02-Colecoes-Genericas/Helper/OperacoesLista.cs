namespace Colecoes_Genericas
{
    public class OperacoesLista
    {
        public void ImprimirListaString(List<String> lista) {
            
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Indice: {i}, elemento: {lista[i]}");
            }            
        }











        
    }
}