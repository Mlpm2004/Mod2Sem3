using Classes.ListaExerciciosS3.Entidades;
namespace Classes.ListaExerciciosS3.Repositorios
{
    public class RepositorioExame
    {
        private List<Exame> _exame;

        public List<Exame> Exame { get => _exame; set => _exame = value; }
        public void AdicionarNotaExame(Exame exame)
        {
            if (_exame is null)
            {
                _exame = new List<Exame>();
            }

            _exame.Add(exame);
        }
        public void MaiorNota()
        {
            double nota = 0.00;
            string nome = "";
            foreach (var item in _exame)
            {
                if(item.Nota>nota)
                {
                    nota = item.Nota;
                    nome = item.Nome;
                }   
            }
            Console.WriteLine($" A nota mais alta foi {nota} do aluno {nome}");
        }
        public void MenorNota()
        {
            double nota = 100.00;
            string nome = "";
            foreach (var item in _exame)
            {
                if (item.Nota < nota)
                {
                    nota = item.Nota;
                    nome = item.Nome;
                }
            }
            Console.WriteLine($" A nota mais baixa foi {nota} do aluno {nome}");
        }
        public void MediaNota()
        {
            double soma = 0.00;
            foreach (var item in _exame) soma = soma + item.Nota;
            Console.WriteLine($" A média da turma foi {soma/_exame.Count}");
        }
        public int NumReprovados() => _exame.Count(nota => nota.Nota >= 70.00);
        
    }
}
