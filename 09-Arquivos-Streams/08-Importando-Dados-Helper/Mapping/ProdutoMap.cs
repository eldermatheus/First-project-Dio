using CsvHelper.Configuration;
using System.Globalization;
using Importando_Dados_Helper.Model;

namespace Importando_Dados_Helper.Mapping
{
    public class ProdutoMap : ClassMap<Produto>
    {
        public ProdutoMap()
        {
            Map(x => x.Nome).Name("nome");

            Map(x => x.Marca).Name("marca");
            
            Map(x => x.Preco).Name("preço").TypeConverterOption.CultureInfo(CultureInfo.GetCultureInfo("pt-BR"));
        }
    }
}