using Pilares_Poo.Models;
using Pilares_Poo.Interfaces;



static void Interfaces()
{
    ICalculadora calc = new Calculadora();
    System.Console.WriteLine(calc.Somar(10,20));
    System.Console.WriteLine(calc.Subtrair(10,20));
    System.Console.WriteLine(calc.Multiplicar(10,20));
    System.Console.WriteLine(calc.Dividir(10,20));
}

static void ContaCorrente()
{
    Corrente c1 = new Corrente();
    c1.ExibirSado();
    c1.Creditar(100);
    c1.Creditar(150);
    c1.ExibirSado();
}

static void ExemploCalculadora()
{
    Calculadora cal = new Calculadora();
    System.Console.WriteLine($"Resultado da primeira soma: " + cal.Somar(10,10));
    System.Console.WriteLine($"Resultado da primeira soma: " + cal.Somar(10,10,10));

    Console.ReadKey();
}

static void ExemploProfessorAluno()
{
    Professor p1 = new Professor();
    p1.Salario = 3000;
    p1.Nome = "Joe";
    p1.Idade = 30;
    p1.Apresentar();

    Aluno a1 = new Aluno();
    a1.Nota = 9;
    a1.Nome = "Bob";
    a1.Idade = 30;
    a1.Apresentar();

    Console.ReadKey();
}

static void ExemploRetangulo()
{
    // Classe retângulo, valores válidos
    Retangulo r1 = new Retangulo();
    r1.DefinirMedidas(30,30);
    System.Console.WriteLine($"Área: {r1.ObterArea}");

    // Classe retângulo, valores inválidos
    Retangulo r2 = new Retangulo();
    r2.DefinirMedidas(0,0);
    System.Console.WriteLine($"Área: {r2.ObterArea}");
}