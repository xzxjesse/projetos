using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    public class Terror : Livro
    {
        public Terror(string titulo, string autor, int folhas) : base(titulo, autor, folhas)
        {
        }

        public override void Ler()
        {
            Console.WriteLine("Silencio! Estamos lendo e está assustador...");
        }

        public override void Guardar()
        {
            Console.WriteLine("Guarda y Guarda");
        }
    }
}
