public class Aluno : IAluno
{
    public string Nome { get; }
    public int Matricula { get; }
    
    public Aluno(string nome, int matricula){
        Nome = nome;
        Matricula = matricula;
    }
}