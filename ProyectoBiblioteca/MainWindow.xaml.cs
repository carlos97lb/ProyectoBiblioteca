using ProyectoBiblioteca.clases;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoBiblioteca
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void ButtonCatalogo_Click(object sender, RoutedEventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.Show();
        }

        private void ButtonMisLibros_Click(object sender, RoutedEventArgs e)
        {
            MisLibros mislibros = new MisLibros();
            mislibros.Show();
        }

        private void ButtonLenguaje_Click(object sender, RoutedEventArgs e)
        {
            Lenguaje lenguaje = new Lenguaje();
            lenguaje.Show();
        }

        private void BotonPrueba_Click(object sender, RoutedEventArgs e)
        {
            PruebaComponentes prueba = new PruebaComponentes();
            prueba.Show();
        }
    }
}
