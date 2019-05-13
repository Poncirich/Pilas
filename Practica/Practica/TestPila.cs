﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class TestPila
    {
        static void Main(string[] args)
        {
            Pila pi = new Pila(5);
            Pila pi1 = new Pila(5);
            Pila aux = new Pila(5);

            //Creacion
            CD cd1 = new CD("pablito", "poncecito", 1000);
            pi.Push(cd1);
            CD cd2 = new CD("pablito2", "poncecito2", 1000);
            pi.Push(cd2);
            CD cd3 = new CD("pablito3", "poncecito3", 10003);
            pi.Push(cd3);
            CD cd4 = new CD("pablito4", "poncecito4", 14000);
            pi.Push(cd4);
            CD cd5 = new CD("pablito5", "poncecito5", 10050);
            pi.Push(cd5);
            

            //Pasar Discos
            for(int i = 0; i < 5; i++)
            {
                aux.Push(pi.Pop());
            }
            for(int i = 0; i < 5; i++)
            {
                pi1.Push(aux.Pop());
            }

            //Listar
            for (int i = 0; i < 5; i++)
            {
                pi1.Peek();
                Console.WriteLine(pi1.Peek().Titulo);
                pi1.Pop();
            }
            Console.ReadKey();
        }
    }
}