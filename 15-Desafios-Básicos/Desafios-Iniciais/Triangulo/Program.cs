double a, b, c;
string[] valor = Console.ReadLine().Split();
a = Convert.ToDouble(valor[0]);
b = Convert.ToDouble(valor[1]);
c = Convert.ToDouble(valor[2]);

if (a + b > c && a + c > b && c + b > a)
{
    double perimetro = a + b + c;
    Console.WriteLine("Perimetro = {0:0.0}", perimetro);
}
else
{
    double area = (a + b) * c / 2;
    Console.WriteLine("Area = {0:0.0}", area);
}

/*

using System.Globalization;

double a, b, c;
string[] valor = Console.ReadLine().Split();
a = Convert.ToDouble(valor[0].Replace(".", ","));
b = Convert.ToDouble(valor[1].Replace(".", ","));
c = Convert.ToDouble(valor[2].Replace(".", ","));


if (a + b > c && a + c > b && c + b > a)
{
    double perimetro = a + b + c;
    //Console.WriteLine(perimetro.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine(perimetro);
}

else
{
    double area = (a + b) * c / 2;
    //Console.WriteLine(area.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine(area);
}
*/