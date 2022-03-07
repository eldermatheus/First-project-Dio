using Exceptions.Src;

int a = 100, b = 0;

double result = 0;

try
{
    System.Console.WriteLine(result = Dividir(a, b));
}

catch (DivideByZeroException divZero)
{
    System.Console.WriteLine(divZero.Message);
}

catch (System.Exception e)
{    
    System.Console.WriteLine(e.Message);
}

finally 
{
    System.Console.WriteLine("A divisao precisa ser refeita");
}


double Dividir(int a, int b)
{
    if (b == 0)
    {
        throw new MyClassException("Mensagem customizada");
    }

    return a / b;
}