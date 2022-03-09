using App_Cadastro;

namespace App_Cadastro
{
    public class Serie : EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano) {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;            
        }
        public override string ToString()
        {
            return
                "G�nero: " + Genero + "\n" + 
                "T�tulo: " + Titulo + "\n" +
                "Descri��o: " + Descricao + "\n" +
                "Ano de In�cio: " + Ano + "\n" +
                "Exclu�do: " + Excluido; 
        }
        public string RetornarTitulo() {
            return this.Titulo;
        }
        public int RetornarId()
        {
            return this.Id;
        }
        public bool RetornarExcluido()
        {
            return this.Excluido;
        }

        public bool Excluir() {
            return this.Excluido = true;
        }
    }
}