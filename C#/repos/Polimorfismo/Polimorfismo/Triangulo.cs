using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Triangulo : FormaGeometrica
    {
        private double baseTriangulo;
        private double alturaTriangulo;

        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
        }

        public override double CalcularArea()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
    }
}
