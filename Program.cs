namespace registro_de_estudantes_em_c_sharp;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        Aluno a1 = new("Guilherme", 1);
        Curso c1 = new("TADS");

        Console.WriteLine($"Lista de alunos do curso {c1.Nome}:");
        for(int x = 0; x < c1.Alunos.Count; x++){
            Console.WriteLine($"{c1.Alunos[x].Nome}");
        }
    }
}

/*
classe curso
classe aluno
*/