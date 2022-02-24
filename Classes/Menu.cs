
namespace Classes.ListaExerciciosS3.Entidades
{
    public class Menu
    {
        private string _nomePrato;
        private List<string> Ingredientes = new List<string>();
        private double _preco;

        public string NomePrato { get => _nomePrato; set => _nomePrato = value; }
        
        public double Preco { get => _preco; set => _preco = value; }
        public List<string> Ingredientes1 { get => Ingredientes; set => Ingredientes = value; }

        public void ImprimirIngredientes()
        {
            if (Ingredientes != null)
            {
                foreach (var ingrediente in Ingredientes) Console.WriteLine(ingrediente);
            }
            else
            {
                Console.WriteLine("Lista de Ingredientes vazia");
            }
        }
    }
}
