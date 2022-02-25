Menu();
string opcao = Console.ReadLine();
Aluno[] alunos = new Aluno[5];
int posicaoAluno = 0;




while (opcao.ToUpper() != "X") {
    
    switch (opcao) {
        
        case "1": 
            Console.WriteLine($"Informe o nome do aluno {posicaoAluno + 1}:");
            Aluno aluno = new Aluno();
            
            string nomeInformado = Console.ReadLine();

            if (nomeInformado != null) {
                aluno.Nome = nomeInformado;
            }            
            else {
                throw new Exception("O nome do aluno não pode ser vazio!");
            }
            
            Console.WriteLine($"Informe a nota do aluno {posicaoAluno + 1}:");
            
            if (decimal.TryParse(Console.ReadLine(), out decimal nota))  {                
                aluno.Nota = nota;
            }
            else {
                throw new Exception("O valor da nota deve ser decimal!");
            }   
            
            alunos[posicaoAluno] = aluno;
            posicaoAluno++;
        break;

        case "2" :
            
            foreach (var alun in alunos ) {

                if (!string.IsNullOrEmpty(alun.Nome)) {                    
                    Console.WriteLine(alun.Nome + ", " + alun.Nota);
                }                      
            }

        break;

        case "3" :
            decimal media = 0;
            decimal soma = 0;

            foreach (var i in alunos ) {
                soma =+ i.Nota;        
            }
            
            media = soma/alunos.Length;
            Console.WriteLine(soma);

        break;   
        
        case "X" :
        break;

        default: 
            throw new ArgumentOutOfRangeException("Opção fora do range");
    }
    
    Menu();
    Console.WriteLine();
    opcao = Console.ReadLine();
}




static void Menu(){

    Console.WriteLine("1 - Incluir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Calcular média geral");
    Console.WriteLine("X - Sair");
    Console.WriteLine("---------------------------");
}
