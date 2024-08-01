using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    public class Romance : Livro
    {
        public Romance(string titulo, string autor, int folhas) : base(titulo, autor, folhas)
        {
        }

        public override void Ler()
        {
            Console.WriteLine("Silencio! Estamos lendo e está fofinho...");
        }

        public override void Guardar()
        {
            Console.WriteLine("Guarda y Guarda");
        }
    }
}
