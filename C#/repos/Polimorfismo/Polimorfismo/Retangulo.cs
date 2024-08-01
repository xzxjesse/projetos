using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Retangulo : FormaGeometrica
    {
        private double baseRetangulo;
        private double alturaRetangulo;

        public Retangulo(double baseRetangulo, double alturaRetangulo)
        {
            this.baseRetangulo = baseRetangulo;
            this.alturaRetangulo = alturaRetangulo;
        }

        public override double CalcularArea()
        {
            return baseRetangulo * alturaRetangulo;
        }
    }
}