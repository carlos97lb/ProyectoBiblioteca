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
    /// Lógica de interacción para MisLibros.xaml
    /// </summary>
    public partial class MisLibros : Window
    {
        private LogicaNegocio.Bibliotecapropia bibliotecapropia;
        
        public MisLibros()
        {
            InitializeComponent();
          bibliotecapropia = new LogicaNegocio.Bibliotecapropia();
          datagridLibros.DataContext = bibliotecapropia;
        }

        private void ButtonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DialogoMislibros dialogoLibro = new DialogoMislibros(bibliotecapropia);
            dialogoLibro.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BotonModificar_Click(object sender, RoutedEventArgs e)
        {
           if (datagridLibros.SelectedIndex != -1) {
                Libro libro = (Libro) datagridLibros.SelectedItem;
                DialogoMislibros dialogolibro = new DialogoMislibros(bibliotecapropia, (Libro)libro.Clone(), datagridLibros.SelectedIndex);
                dialogolibro.Show();
            }
            
        }
    }
}
