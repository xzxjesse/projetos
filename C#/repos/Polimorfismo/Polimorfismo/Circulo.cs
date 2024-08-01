using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public class Circulo : FormaGeometrica
    {
        private double raioCirculo;

        public Circulo(double raioCirculo)
        {
            this.raioCirculo = raioCirculo;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(raioCirculo, 2);
        }
    }
}
