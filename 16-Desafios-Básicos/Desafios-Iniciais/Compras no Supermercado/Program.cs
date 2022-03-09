var totalDeCasosDeTeste = int.Parse(Console.ReadLine());

List<string> listaprodutos = new List<string>();

for (int i = 0; i < totalDeCasosDeTeste; i++)
{
    string[] linha = Console.ReadLine().Split(' ');

    foreach (var produto in linha)
    {
        if(!listaprodutos.Contains(produto))
        listaprodutos.Add(produto);        
    }

    System.Console.WriteLine();
    
    listaprodutos.Sort();
    Console.WriteLine(string.Join(" ", listaprodutos));
    listaprodutos.Clear();
}

