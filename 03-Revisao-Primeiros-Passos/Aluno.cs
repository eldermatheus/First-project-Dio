public class Aluno 

{
    public string Nome {get; set;}
    public decimal Nota {get; set;}
    public decimal Media {get; set;}

    public Aluno() {
    }

    public Aluno(string nome, decimal nota) {
        this.Nome = nome;
        this.Nota = nota;
    }

    public decimal CalcularMedia() {
        Media =  0;

        return Media;
    }

    
}