namespace Construtores.scr
{
    public class Data
    {
        //Private fields
        private int _mes;
        private bool _mesValido;

        //Auto-Implemented Properties
        public int Mes { get; set; }
        public int MesValido { get; set; }

        //Getters e Setters
        public int GetMes() 
        {
            return this._mes;
        }

        public void SetMes(int mes)
        {
            if (mes > 0 && mes <= 12) 
            {
                this._mes = mes;
                this._mesValido = true;
            }
        }
        
        public void Imprimir()
        {
            Console.WriteLine(this._mes);
        }
    }
}