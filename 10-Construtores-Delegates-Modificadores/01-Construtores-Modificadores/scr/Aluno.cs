namespace Construtores.scr
{
    public class Aluno : Pessoa
    {        
        /*Esse construtor segue as regras da classe mãe ou base
        porém implementa outras regras*/
        public Aluno(string nome, string sobrenome) : base(nome, sobrenome) 
        {
            Console.WriteLine("Este construtor pertece a classe Aluno");
        }
    }
}