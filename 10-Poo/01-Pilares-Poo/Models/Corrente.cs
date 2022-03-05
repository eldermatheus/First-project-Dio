namespace Pilares_Poo.Models
{
    public class Corrente : Conta
    {        
        public override void Creditar(double valor)
        {
            this.saldo += valor;
        }
    }
}