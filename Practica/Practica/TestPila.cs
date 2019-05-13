using System;
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
            Medios cd1 = new Medios("pablito", "poncecito", 1000);
            pi.Push(cd1);
            Medios cd2 = new Medios("pablito2", "poncecito2", 1000);
            pi.Push(cd2);
            Medios cd3 = new Medios("pablito3", "poncecito3", 10003);
            pi.Push(cd3);
            Medios cd4 = new Medios("pablito4", "poncecito4", 14000);
            pi.Push(cd4);
            Medios cd5 = new Medios("pablito5", "poncecito5", 10050);
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
            //Hola
        }
    }
}


//Manera de recorrer una pila con while

// while(!p.isEmpty()){
//Console.writeline("titulo" + p.pop().titulo);
//}

//Segunda manera
//while(!p.isEmpty()&&(!Q.isFull()||!R.isFull()){
//  if(p.peek().Duracion == 80){
//     Q.push(p.pop());
//  }else{R.push(p.pop());
//Hola giannn
