using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class Medios
    {
        //Atributos
        private string titulo;
        private string interprete;
        protected int duracion;

        //Constructor
        public Medios(string titulo, string interprete, int duracion)
        {
            this.titulo = titulo;
            this.interprete = interprete;
            this.duracion = duracion;
        }

        //Get Set
        private string Titulo1 { get => titulo; set => titulo = value; }
        public string Interprete { get => interprete; set => interprete = value; }
                
        public int Duracion
        {
            get
            {
                return duracion;
            }
            set
            {
                duracion = value;
            }
        }

        public string Titulo {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        
    }
}
