namespace Pilares_Poo.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);
        
        public void ExibirSado()
        {
            System.Console.WriteLine($"Seu saldo é : {saldo}");
        }

    }
}