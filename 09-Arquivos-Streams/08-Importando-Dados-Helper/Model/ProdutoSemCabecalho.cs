using CsvHelper.Configuration.Attributes;

namespace Importando_Dados_Helper.Model

{
    public class ProdutoSemCabecalho
    {        
        [Index(0)]
         public string Nome { get; set; }

        [Index(1)]
        public string Marca { get; set; }

        [Index(2)]
        [CultureInfo("pt-BR")]
        public decimal Preco { get; set; }     
    }
}