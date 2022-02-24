public class Pilha
{
    Posicao topo;

    public void Empilha(object item) 
    {
        topo = new Posicao(topo,item);
    }

    public object Desempilha()
    {
        if(topo == null)
        {
            throw new InvalidOperationException();
        }

        object resultado = topo.item;
        topo = topo.proximo;
        return resultado;
    }


    class Posicao 
    {
        public Posicao proximo;
        public object item;

        public Posicao(Posicao proximo, object item)
        {
            this.proximo = proximo;
            this.item = item;
        }
    }
}