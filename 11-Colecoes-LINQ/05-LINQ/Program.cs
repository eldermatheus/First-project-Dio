using System.Linq;

SumDistinct();

//Select usando LINQ
static void Select() {

    int[] arrayNumeros = new int[] {1, 4, 8, 15, 19};

    //1º modelo de LINQ
    var numerosParesQuery =
        from num in arrayNumeros
        where num % 2 == 0
        orderby num
        select num;

    //2º modelo de LINQ
    var numerosImparesQuery = arrayNumeros.Where(x => x % 2 == 1).OrderBy(x => x).ToList();

    System.Console.WriteLine($"Numeros pares: {string.Join(',',numerosParesQuery)}");
    System.Console.WriteLine($"Numeros ímpares: {string.Join(',',numerosImparesQuery)}");
}

//Valor mínimo, máximo e médio
static void MaximoMinimo() {
    int[] arrayNumeros = new int[] {4, 19, 1, 4, 8, 15, 19};
    
    var maximo = arrayNumeros.Max();
    var minimo = arrayNumeros.Min();
    var medio = arrayNumeros.Average();

    System.Console.WriteLine($"Máximo: {maximo}");
    System.Console.WriteLine($"Mínimo: {minimo}");
    System.Console.WriteLine($"Médio: {medio}");
}

//Somatório e distinct
static void SumDistinct() {
    int[] arrayNumeros = new int[] {1, 4, 8, 15, 19};
    
    var soma = arrayNumeros.Sum();
    var distinct = arrayNumeros.Distinct();    

    System.Console.WriteLine($"Somatório: {soma}");    
    System.Console.WriteLine($"Elementos distintos: {string.Join(',',distinct)}");
}
