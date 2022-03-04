using CsvHelper.Configuration.Attributes;

namespace Importando_Dados_Helper.Model

{
    public class Produto
    {        
        [Name("nome")]
         public string Nome { get; set; }

        [Name("marca")]
        public string Marca { get; set; }

        [Name("preço")]
        [CultureInfo("pt-BR")]
        public decimal Preco { get; set; }     
    }
}