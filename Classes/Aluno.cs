namespace Classes.ListaExerciciosS3.Entidades
{
    public class Aluno
    {
        private string _nome;
        private int _turma;

        public string Nome { get => _nome; set => _nome = value; }
        public int Turma { get => _turma; set => _turma = value; }
    }
}
