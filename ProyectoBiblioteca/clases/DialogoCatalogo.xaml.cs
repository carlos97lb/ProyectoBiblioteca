using ProyectoBiblioteca.dto;
using ProyectoBiblioteca.LogicaNegocio;
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
    /// Lógica de interacción para DialogoCatalogo.xaml
    /// </summary>
    public partial class DialogoCatalogo : Window
    {
        public Biblioteca bibliotecalib;
        public Libro libro;
        public DialogoCatalogo(Biblioteca bibliotecalib)
        {
            InitializeComponent();
            this.bibliotecalib = bibliotecalib;
            libro = new Libro();
            this.DataContext = libro;
        
        }

        private void botonaceptar_Click(object sender, RoutedEventArgs e)
        {
            int id1 = Convert.ToInt32(Textid.Text);
            foreach (Libro libro in bibliotecalib.listalibro) {

                if (libro.Id.Equals(id1)) {
                    libro.Clone();
                    libro.Disponibilidad = "pedido";                }


            }
            this.Close();
        }

        private void botoncancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
