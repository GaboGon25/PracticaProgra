using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgra
{
    public interface IFigurasGeometricas
    {
        double resultado { get; set; }
        void CalcularArea(double l1, double l2);
        void Mostrar();
    }
}
