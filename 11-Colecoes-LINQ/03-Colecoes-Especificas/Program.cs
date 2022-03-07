
static void Pilha() {
    Stack<string> pilha = new Stack<string>();
    
    pilha.Push("Livro A");
    pilha.Push("Livro B");
    pilha.Push("Livro C");

    while (pilha.Count > 0)
    {
        System.Console.WriteLine($"Proximo livro a ser lido: {pilha.Peek()}");
        System.Console.WriteLine($"{pilha.Pop()} lido com sucesso");
    }
    
    System.Console.WriteLine($"Livros na pilha: {pilha.Count()}");
}

static void Fila() {
    Queue<string> fila = new Queue<string>();

    fila.Enqueue("Elder");
    fila.Enqueue("Leonardo");
    fila.Enqueue("Igor");

    System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

    while (fila.Count > 0)
    {
        System.Console.WriteLine($"Vez de {fila.Peek()}");
        System.Console.WriteLine($"{fila.Dequeue()}, atendido");
        System.Console.WriteLine("----------------------------");

    }

    System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
}