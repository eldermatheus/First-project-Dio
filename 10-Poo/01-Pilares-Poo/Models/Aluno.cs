namespace Pilares_Poo.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public virtual void Apresentar()   
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}.");
        }
    }
}