using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblioteca.dto
{
    //aqui usamos las clases que hay implementadas con las validaciones y el clon
    public class Libro : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        private String disponibilidad;

        public event PropertyChangedEventHandler PropertyChanged;

        public String Disponibilidad
        {
            get
            {
                return disponibilidad;
            }
            set
            {
                this.disponibilidad = value;
                this.PropertyChanged(this, new PropertyChangedEventArgs("Disponibilidad"));
            }
        }

        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Autor { get; set; }

        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get 
            {
                string resul = "";
                if (columnName == "Titulo")
                {
                    if (String.IsNullOrEmpty(Titulo)) 
                    {
                        resul = "Debe introducir Titulo";                    
                    }
                }
                if (columnName == "Autor") 
                {
                    if (String.IsNullOrEmpty(Autor)) 
                    {
                        resul = "Debe introducir Autor";
                    }
                }
                return resul;   
            }
        }

        public Libro(String autor, String titulo, String disponibilidad,int id)
        {
            this.disponibilidad = disponibilidad;
            this.Autor = autor;
            this.Titulo = titulo;
            this.Id = id;
        }
        public Libro() 
        {
        }

        public override string ToString()
        {
            return Titulo + " " + Autor;
        }

        public object Clone()
        {

            return this.MemberwiseClone();
        }


    }
}
