namespace Classes.ListaExerciciosS3.Entidades
{
    public class AreaRetangulo
    {
        private double _base;
        private double _altura;

        public double Base { get => _base; set => _base = value; }
        public double Altura { get => _altura; set => _altura = value; }

        public void CalculaAreaRetangulo()
        {
            Console.Write($"A Área é {_base * _altura}");
        }
    }
}
