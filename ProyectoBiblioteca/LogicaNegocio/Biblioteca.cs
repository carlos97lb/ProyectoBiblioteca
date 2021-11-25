using ProyectoBiblioteca.dto;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.LogicaNegocio
{
    
    public class Biblioteca
    {
        public ObservableCollection<Libro> listalibro { get; set; }


        public Biblioteca()
        {
            listalibro = new ObservableCollection<Libro>();
            listalibro.Add(new Libro("Tolkien", "La comunidad del anillo","disponible",1));
            listalibro.Add(new Libro("Tolkien", "Las dos torres", "disponible",2));
            listalibro.Add(new Libro("Tolkien", "El retorno del rey", "disponible",3));
            listalibro.Add(new Libro("J.K.Rowling", "Harry Potter y la piedra filosofal", "disponible", 4));
            listalibro.Add(new Libro("J.K.Rowling", "Harry Potter y la camara secreta", "disponible", 5));
            listalibro.Add(new Libro("J.K.Rowling", "Harry Potter y el prisionero de azkaban", "disponible", 6));
            listalibro.Add(new Libro("J.K.Rowling", "Harry Potter y el caliz de fuego", "disponible", 7));
            listalibro.Add(new Libro("J.K.Rowling", "Harry Potter y la orden del fenix", "disponible", 8));
            listalibro.Add(new Libro("J.K.Rowling", "Harry Potter y el principe mestizo", "disponible", 9));
            listalibro.Add(new Libro("J.K.Rowling", "Harry Potter y las reliquias de la muerte", "disponible", 10));
        }
    }
}