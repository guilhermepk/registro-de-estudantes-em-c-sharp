public class Curso(string nome) : ICurso
{
    public string Nome { get; set; } = nome;
    public List<Aluno> Alunos { get; } = [];

    public bool CadastrarAluno(Aluno aluno)
    {
        try
        {
            Alunos.Add(aluno);
            return true;
        }
        catch (System.Exception)
        {
            
            throw new Exception("deu errado");
        }
    }

}