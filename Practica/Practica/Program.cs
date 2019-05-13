using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico4
{
    class Program
    {
        static void Main(string[] args)
        {
            //hola maurito
            Pila pi = new Pila(5);
            Pila pi1 = new Pila(5);
            Pila aux = new Pila(5);

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

            for(int i = 0; i < 5; i++)
            {
                aux.Push(pi.Pop());
            }
            for(int i = 0; i < 5; i++)
            {
                pi1.Push(aux.Pop());
            }

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


//Manera de recorrer una pila con while

// while(!p.isEmpty()){
//Console.writeline("titulo" + p.pop().titulo);
//}

//Segunda manera
//while(!p.isEmpty()&&(!Q.isFull()||!R.isFull()){
//  if(p.peek().Duracion == 80){
//     Q.push(p.pop());
//  }else{R.push(p.pop());
