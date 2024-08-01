using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class FormaGeometrica
{
    public abstract double CalcularArea();

    public virtual string ObterTipo()
    {
        return GetType().Name.Replace("FormaGeometrica", "");
    }
}