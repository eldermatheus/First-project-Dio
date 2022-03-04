namespace Pilares_Poo.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()   
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome} e tenho um salario de {Salario}.");
        }
    }
}