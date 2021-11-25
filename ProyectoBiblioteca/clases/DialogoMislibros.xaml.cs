using ProyectoBiblioteca.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoBiblioteca.clases
{
    /// <summary>
    /// Lógica de interacción para DialogoMislibros.xaml
    /// </summary>
    public partial class DialogoMislibros : Window
    {
        //aqui usamos el doble constructor , la validacion del boton y el cambio de evento.
        public LogicaNegocio.Bibliotecapropia bibliotecapropia;
        public Libro libro;
        private int posicion;
        private Boolean modificar;
        private int errores;
        public DialogoMislibros(LogicaNegocio.Bibliotecapropia bibliotecaPropia)
        {
            InitializeComponent();
            this.bibliotecapropia = bibliotecaPropia;
            libro = new Libro();
            this.DataContext = libro;
            modificar = false;
        }
        public DialogoMislibros(LogicaNegocio.Bibliotecapropia bibliotecaPropia,Libro libromodificar,int posicion)
        {
            InitializeComponent();
            this.bibliotecapropia = bibliotecaPropia;
            this.libro = libromodificar;
            this.posicion = posicion;
            this.DataContext = libro;
            modificar=true;
        }




        private void botonAceptar_Click(object sender, RoutedEventArgs e)
        {
            if (modificar)
                bibliotecapropia.modificarLibro(libro, posicion);
            else
                bibliotecapropia.añadirLibro(libro);
            bibliotecapropia.añadirLibro(libro);
                this.Close();
        }

        private void BotonCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void Validation_error(object sender, ValidationErrorEventArgs e) 
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;

            if (errores == 0)
                botonAceptar.IsEnabled = true;
            else
                botonAceptar.IsEnabled = false;
        }
    }
}
