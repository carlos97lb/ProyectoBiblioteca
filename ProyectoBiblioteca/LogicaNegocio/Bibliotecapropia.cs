using ProyectoBiblioteca.dto;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.LogicaNegocio
{
    public class Bibliotecapropia
    {
        public ObservableCollection<Libro> listademislibros { get; set; }

        public Bibliotecapropia()
        {
            listademislibros = new ObservableCollection<Libro>();
            listademislibros.Add(new Libro("titulo", "autor","disponible",1));
        }
        public void añadirLibro(Libro libro) {
            listademislibros.Add(libro);
        }
        public void modificarLibro(Libro libro, int posicion)
        {
            listademislibros[posicion] = libro;
        }
    }
}
