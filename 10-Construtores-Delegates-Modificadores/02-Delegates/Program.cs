using Delegates.src;

Matematica m = new Matematica(10,20);
m.Somar();



/* Delegate

    Operacao op = new Operacao(Calculadora.Somar);
    //Sintaxe alternativa: Operacao op = Calculadora.Somar;

    op += Calculadora.Subtrair; // += representa o multi cast de métodos. Chama o Somar e depois o subtrair
    
    op.Invoke(10,10);
    //Sintaxe alternativa: op(10,10);

    public delegate void Operacao(int x, int y);
*/