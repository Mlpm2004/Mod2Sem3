using Classes.ListaExerciciosS3.Entidades;

namespace Classes.ListaExerciciosS3.Repositorios
{
    public class RepositorioAnimal
    {
        private List<Animal> _animal;

        public List<Animal> Animal { get => _animal; set => _animal = value; }

        public void AdicionarAnimal(Animal animal)
        {
            if (_animal is null)
            {
                _animal = new List<Animal>();
            }
            _animal.Add(animal);
        }
        public int ContaCao() => _animal.Count(cao => cao.Tipo == "Cão");
    }
}
