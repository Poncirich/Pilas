using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class CD
    {
        //at
        protected string titulo;
        private string interprete;
        protected int duracion;

        //con
        public CD(string titulo, string interprete, int duracion)
        {
            this.titulo = titulo;
            this.interprete = interprete;
            this.duracion = duracion;
        }

        //G S
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
