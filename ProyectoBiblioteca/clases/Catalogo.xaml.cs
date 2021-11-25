using ProyectoBiblioteca.dto;
using ProyectoBiblioteca.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para Catalogo.xaml
    /// </summary>
    public partial class Catalogo : Window
    {

       public Biblioteca bibliotecalib; 
        public Catalogo()
        {
            InitializeComponent();
            bibliotecalib = new Biblioteca();
            Datagridcatalogo.DataContext = bibliotecalib;

        }

        private void ButtonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ButtonPedir_Click(object sender, RoutedEventArgs e)
        {
            DialogoCatalogo dialogoCatalogo = new DialogoCatalogo(bibliotecalib);
            dialogoCatalogo.Show();
        }
    }
}
