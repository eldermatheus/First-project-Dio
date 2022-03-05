using Pilares_Poo.Interfaces;

namespace Pilares_Poo.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }        

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}