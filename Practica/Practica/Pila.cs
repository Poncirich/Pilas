using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class Pila
    {
        //Atributos
        protected int tope = -1;
        protected Medios[] listaDeDiscos;
         


        //Constructor
        public Pila(int tamaño)
        {
            listaDeDiscos = new Medios[tamaño];
        }       
        
        
        //Metodos
        public void Push(Medios z)
        {
            if(tope < listaDeDiscos.Length)
            {
                tope++;
                listaDeDiscos[tope] = z;
            }
        }
        public Medios Pop()
        {
            tope--;
            return listaDeDiscos[tope + 1];
        }
        public Medios Peek()
        {
            return listaDeDiscos[tope];
        }
        public bool isEmpty()
        {
            if(tope == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isFull()
        {
            if(tope == listaDeDiscos.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
