namespace Classes.ListaExerciciosS3.Entidades
{
    public class Pessoa
    {
        private int _idade;
        private string _nome;

        public int Idade { get => _idade; set => _idade = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome : {_nome}");
            Console.WriteLine($"Idade : {_idade}");
        }
    }
}
