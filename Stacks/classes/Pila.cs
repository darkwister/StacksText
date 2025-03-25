using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stacks.classes
{
    public class Pila
    {
        public Nodo? Tope { get; set; }
        public Pila(){
            Tope = null;
        }

        public void Push(char Value){
            Nodo aux = new();
            aux.Dato = Value;
            if(Tope == null){
                Tope = aux;
                aux.Siguiente = null;
            }else{
                aux.Siguiente = Tope;
                Tope = aux;
            }
        }
        public void Mostrar(){
            Nodo puntero; 
            puntero = Tope;
            Console.WriteLine("{0}",puntero.Dato);
            while(puntero.Siguiente != null){
                puntero = puntero.Siguiente;
                Console.WriteLine("{0}",puntero.Dato);
            }
        }
        public char Pop(){
            char Value = ' ';
            if (Tope == null)
                Console.WriteLine("Pila vacia");
            else{
                Value = Tope.Dato;
                Tope = Tope.Siguiente;
            }
            return Value;
        }
    }
}