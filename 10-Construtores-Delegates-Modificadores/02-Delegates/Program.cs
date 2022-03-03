using Delegates.src;

//Sintaxe alternativa: Operacao op = Calculadora.Somar;
Operacao op = new Operacao(Calculadora.Somar);
op += Calculadora.Subtrair; // += representa o multi cast de métodos. Chama o Somar e depois o subtrair

//Sintaxe alternativa: op(10,10);
op.Invoke(10,10);

public delegate void Operacao(int x, int y);
