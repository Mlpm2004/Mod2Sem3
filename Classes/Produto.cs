namespace Classes.ListaExerciciosS3.Entidades
{
    public class Produto
    {
        private string _nome;
        private double _valor;
        private int _desconto;

        public string Nome { get => _nome; set => _nome = value; }
        public double Valor { get => _valor; set => _valor = value; }
        public int Desconto { get => _desconto; set => _desconto = value; }

        
    }
}
