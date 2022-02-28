int x = int.Parse(Console.ReadLine());

while (x != 0) 
{
    int soma = 0;
    for (int i = 0; i < 5; i++) 
    {
        if (x % 2 == 0) 
        {
            soma += x + (i + 2);
        }
        else             
            soma += (x + 1) + (i + 2);
        }

        Console.WriteLine(soma);
        x = int.Parse(Console.ReadLine());
}