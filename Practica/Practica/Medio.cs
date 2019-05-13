using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class Medio
    {
        //Atributos
        protected string titulo;
        private string interprete;
        protected int duracion;

        //Constructor
        public Medio(string titulo, string interprete, int duracion)
        {
            this.titulo = titulo;
            this.interprete = interprete;
            this.duracion = duracion;
        }

        //Get Set
        public string Interprete { get => interprete; set => interprete = value; }

        //Metodos
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
