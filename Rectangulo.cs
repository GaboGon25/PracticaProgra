using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgra
{
    public class Rectangulo : IFigurasGeometricas
    {
        public double resultado { get ; set; }

        public void CalcularArea(double l1, double l2)
        {
            resultado = l1*l2;
        }

        public void Mostrar()
        {
            Console.WriteLine("El area del rectangulo es {0}", resultado + "Unidades cuadradas");
        }
    }
}
