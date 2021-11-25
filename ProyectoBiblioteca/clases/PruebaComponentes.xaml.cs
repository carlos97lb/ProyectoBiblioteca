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
    /// Lógica de interacción para PruebaComponentes.xaml
    /// </summary>
    public partial class PruebaComponentes : Window
    {
        public PruebaComponentes()
        {
            InitializeComponent();
        }

        private void botonprueba_MouseEnter(object sender, MouseEventArgs e)
        {
            botonprueba.IsEnabled = false;
        }

        private void BotonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
