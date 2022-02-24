using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.ListaExerciciosS3.Entidades
{
    public class CalculadoraBasica
    {
        private double _valor1;
        private double _valor2;
        private string _operacao;

        public double Valor1 { get => _valor1; set => _valor1 = value; }
        public double Valor2 { get => _valor2; set => _valor2 = value; }
        public string Operacao { get => _operacao; set => _operacao = value; }

        public double Calcular()
        {
            switch (_operacao)
            {
                case "*":
                    return _valor1 * _valor2;
                case "/":
                    return _valor1 / _valor2;
                case "+":
                    return _valor1 + _valor2;
                case "-":
                    return _valor1 - _valor2;
                default:
                    return 0;
            }
        }
    }
}
