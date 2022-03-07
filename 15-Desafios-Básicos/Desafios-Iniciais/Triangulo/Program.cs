double a, b, c;
string[] valor = Console.ReadLine().Split();
a = Convert.ToDouble(valor[0]);
b = Convert.ToDouble(valor[1]);
c = Convert.ToDouble(valor[2]);


if (a + b > c && a + c > b && c + b > a)
{
    Console.WriteLine($"Perimetro = {a + b + c}");
}
else
{
    Console.WriteLine($"Area = {((a + b) * c) / 2}");
}



