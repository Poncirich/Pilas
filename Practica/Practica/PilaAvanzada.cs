using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class PilaAvanzada
    {
        //Atributos
        protected int tope = -1;
        protected CD[] listaDeDiscos;


        //Constructor
        public PilaAvanzada(int tamaño)
        {
            listaDeDiscos = new CD[tamaño];
        }


        //Metodos
        public void Push(CD z)
        {
            if (tope < listaDeDiscos.Length)
            {
                tope++;
                listaDeDiscos[tope] = z;
            }
        }
        public CD Pop()
        {
            tope--;
            return listaDeDiscos[tope + 1];
        }
        public CD Peek()
        {
            return listaDeDiscos[tope];
        }
        public bool isEmpty()
        {
            if (tope == -1)
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
            if (tope == listaDeDiscos.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Search(CD.titulo)
        {
            
        }
    }
