public interface ICurso
{
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; }

    public void CadastrarAluno(Aluno aluno);

    public bool ValidarAlunoParaCadastro(Aluno aluno);

}