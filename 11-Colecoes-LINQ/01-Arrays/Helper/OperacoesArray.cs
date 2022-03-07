namespace Arrays.Helper
{
    public class OperacoesArray
    {
        
        public void OrdenarBubbleShort(int[] array) {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        
        public void ImprimirArray(int[] array) {
            
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + ",");
            }
        }

        public void Ordenar(int[] array) {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino) {
            Array.Copy(array, arrayDestino, array.Length);

        }

        public bool Existe(int[] array, int valor) {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool TodosMaiorQue(int[] array, int valor) {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int Encontrar(int[] array, int valor) {
            return Array.Find(array, elemento => elemento == valor);
        }

        public int EncontrarIndice(int[] array, int valor) {
            return Array.IndexOf(array, valor);
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho) {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaArrayToString(int[] array) {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }

    }
}