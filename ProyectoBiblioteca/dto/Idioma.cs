using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.dto
{
    class Idioma
    {
        public String Nombre { get; set; }

        public Idioma(String nombre)
        {

            this.Nombre = nombre;

        }
        public override string ToString()
        {
            return Nombre + " ";
        }
    }
}
