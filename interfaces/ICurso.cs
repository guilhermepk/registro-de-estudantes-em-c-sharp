public interface ICurso
{
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; }

    public bool CadastrarAluno(Aluno aluno);

}