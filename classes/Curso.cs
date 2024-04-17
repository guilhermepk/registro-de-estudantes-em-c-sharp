public class Curso : ICurso
{
    public string Nome { get; set; }
    public List<Aluno> Alunos { get; }

    public Curso(string nome){
        Nome = nome;
        Alunos = new List<Aluno>();
    }
    public void CadastrarAluno(Aluno aluno){
            Alunos.Add(aluno);
    }

    public bool ValidarAlunoParaCadastro(Aluno aluno){
        return false;
    }

}