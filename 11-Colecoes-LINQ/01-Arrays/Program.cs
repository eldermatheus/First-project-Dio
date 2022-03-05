
 ArrayMultiDimensional();

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