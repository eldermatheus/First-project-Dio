namespace Pilares_Poo.Models
{
    public class Retangulo
    {
        private double _comprimento { get; set; }
        private double _largura { get; set; }
        private bool _valido { get; set; }

        public void DefinirMedidas( double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                this._comprimento = comprimento;
                this._largura = largura;
                _valido = true;
            }
            else
            {
                System.Console.WriteLine($"Valores inválidos!");
            }
        }
        public double ObterArea()
        {
            if(_valido)
            {
                return _comprimento * _largura;
            }
            else
            {
                System.Console.WriteLine($"Preencha valores válidos");
                return 0;
            }            
        }
    }
}