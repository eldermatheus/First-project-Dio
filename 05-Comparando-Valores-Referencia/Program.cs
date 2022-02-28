Numero a = new Numero(2);
Numero b = new Numero(2);

// if (a == b): comparação de referência. Instâncias diferentes, mas objetos diferentes.
// if (a.N == b.N): comparação de valor. Instâncias diferentes, mas valores de propriedades iguals.

if (a == b) {
    Console.WriteLine($"a e b são iguais");
}
else 
    Console.WriteLine($"a e b são diferentes");

class Numero {
    public int N { get; set; }

    public Numero(int numero){        
        N = numero;
    }    
}