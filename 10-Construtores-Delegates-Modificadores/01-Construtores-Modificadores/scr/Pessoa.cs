namespace Construtores.scr
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        private readonly string _campoInalteravel; // Esse field só pode ser alterado no momento da instanciação ou no construtor
        public Pessoa () {
            Console.WriteLine("Este construtor pertece a classe Pessoa");
        }
        public Pessoa(string nome, string sobrenome)
        {
            this._nome = nome;
            this._sobrenome = sobrenome;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Olá meu nome é: {_nome} {_sobrenome}");
        }
    }
}
