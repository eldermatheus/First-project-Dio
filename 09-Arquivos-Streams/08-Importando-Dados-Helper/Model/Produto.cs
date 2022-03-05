using CsvHelper.Configuration.Attributes;

namespace Importando_Dados_Helper.Model

{
    public class Produto
    {                
        public string Nome { get; set; }
        
        public string Marca { get; set; }

        public decimal Preco { get; set; }     
    }
}