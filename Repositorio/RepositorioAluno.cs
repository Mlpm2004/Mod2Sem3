using Classes.ListaExerciciosS3.Entidades;

namespace Classes.ListaExerciciosS3.Repositorios
{
    public class RepositorioAluno
    {
        private List<Aluno> _aluno;

        public List<Aluno> Aluno { get => _aluno; set => _aluno = value; }
        public void AdicionarAluno(Aluno aluno)
        {
            if (_aluno is null)
            {
                _aluno = new List<Aluno>();
            }

            _aluno.Add(aluno);
        }
        public void Ordena(string modo)
        {
            List<Aluno> alunosord=new List<Aluno>();
            if (modo == "ASC")
            {
                alunosord = Aluno.OrderBy(x => x.Nome).ToList();
            }
            else
            {
                alunosord = Aluno.OrderByDescending(x => x.Nome).ToList();

            }
            foreach(var item in alunosord)
            {
                Console.WriteLine($" Aluno : {item.Nome} Turma: {item.Turma}");
            }
        }
    }
}
