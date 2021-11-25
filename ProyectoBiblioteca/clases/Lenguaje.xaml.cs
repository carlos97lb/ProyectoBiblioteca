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
    /// Lógica de interacción para Lenguaje.xaml
    /// </summary>
    public partial class Lenguaje : Window
    {
        //aqui tenemos el list y el binding entre lista y componente
        public Lenguaje()
        {
            InitializeComponent();
            List<Idioma> listaIdioma = new List<Idioma>();
            listaIdioma.Add(new Idioma("Español"));
            listaIdioma.Add(new Idioma("Frances"));
            listaIdioma.Add(new Idioma("Italiano"));
            foreach (Idioma idioma in listaIdioma)
            {

                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Content = idioma;
                comboboxidioma.Items.Add(cbi);
            }
        }

        private void ButtonVolver_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void comboboxidioma_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
