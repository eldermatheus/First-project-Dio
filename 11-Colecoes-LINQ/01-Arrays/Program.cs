using Arrays.Helper;




static void ConverterParaArrayToString() {
    OperacoesArray op = new OperacoesArray();

    int[] array = new int[5] {6, 3, 8, 1, 9};

    string[] arrayString = op.ConverterParaArrayToString(array);
}

static void RedimensionarArray() {
    OperacoesArray op = new OperacoesArray();

    int[] array = new int[5] {6, 3, 8, 1, 9};

    op.RedimensionarArray(ref array, array.Length * 2);
    
    System.Console.WriteLine($"O array foi aumentado para {array.Length} posicoes!");
}

static void EncontrarIndice() {
    OperacoesArray op = new OperacoesArray();

    int[] array = new int[5] {6, 3, 8, 1, 9};

    int indice = op.EncontrarIndice(array, 1);

    if (indice > -1 ) {
        System.Console.WriteLine($"O elemento foi encontrado no índice {indice}");
    } else
    System.Console.WriteLine("Indice nao encontrado!");
}

static void Encontrar() {
    OperacoesArray op = new OperacoesArray();

    int[] array = new int[5] {6, 3, 8, 1, 9};

    int valorProcurado = 8;

    int valorAchado = op.Encontrar(array, valorProcurado);

    if (valorAchado > 0) 
    {
        System.Console.WriteLine($"O valor {valorAchado} foi encontrado no array!");
    }
     else    
    {
        System.Console.WriteLine("O valor nao foi encontrado!");
    }
}

static void TodosMaiorQue() {
    OperacoesArray op = new OperacoesArray();

    int[] array = new int[5] {6, 3, 8, 1, 9};

    int valorProcurado = 0;

    bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

    System.Console.WriteLine(todosMaiorQue);
}

static void Existe() {
    OperacoesArray op = new OperacoesArray();

    int[] array = new int[5] {6, 3, 8, 1, 9};

    System.Console.WriteLine(op.Existe(array, 3));
}

static void Copiar() {
    OperacoesArray op = new OperacoesArray();

    int[] arrayDestino = new int[10];

    int[] array = new int[5] {6, 3, 8, 1, 9};

    op.Copiar(ref array, ref arrayDestino);

    op.ImprimirArray(arrayDestino);
}

static void OrdenarBubbleShort() {
    OperacoesArray op = new OperacoesArray();

    int[] arrayDestino = new int[10];

    int[] array = new int[5] {6, 3, 8, 1, 9};

    System.Console.WriteLine("Original");
    op.ImprimirArray(array);

    op.Ordenar(array);

    System.Console.WriteLine("Ordenado");
    op.ImprimirArray(array);
}

static void ArrayMultiDimensional()
{
    int[,] matriz = new int[2,2];
    
    /* Outra forma de popular a matriz
    int[,] matriz = new int[2,2] { {1,2}, {3,4} };
    
    Adicionalmente remove as atribuições abaixo
    */
    matriz[0, 0] = 1;
    matriz[0, 1] = 2;
    matriz[1, 0] = 3;
    matriz[1, 1] = 4;
    
    System.Console.WriteLine("Percorrendo matriz multidimensional");
    
    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            Console.WriteLine(matriz[i,j]);
        }
    }
}

static void ArrayUniDimensional()
{
    int[] arrayInteiros = new int[3];

    arrayInteiros[0] = 10;
    arrayInteiros[1] = 20;
    arrayInteiros[2] = int.Parse("30");

    System.Console.WriteLine("Percorrendo via laço for");
    for (int i = 0; i < arrayInteiros.Length; i++)
    {
        Console.WriteLine(arrayInteiros[i]);
    }

    System.Console.WriteLine("Percorrendo via laço foreach");
    foreach (var item in arrayInteiros)
    {
        System.Console.WriteLine(item);
    }
}
