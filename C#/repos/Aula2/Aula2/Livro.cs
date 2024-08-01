using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    public abstract class Livro
    {
        
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Folhas { get; set; }

        public Livro (string titulo, string autor, int folhas)
        {
            Titulo = titulo;
            Autor = autor; 
            Folhas = folhas;
        }

        public abstract void Ler();
        public abstract void Guardar();
    }
}
