public class Aluno(string nome, int matricula) : IAluno
{
    public string Nome { get; } = nome;
    public int Matricula { get; } = matricula;
}