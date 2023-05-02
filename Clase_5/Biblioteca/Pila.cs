using System;
using System.Collections;

namespace Biblioteca
{
    //Implementación de la clase Pila (genérica, elementos de clase Object)
    public class Pila
    {
        private ArrayList elementos;

        // Constructor 

        public Pila()
        {
            elementos = new ArrayList();    
        }

        // Métodos
        public void apilar(object elemento)
        {
            elementos.Add(elemento);
        }

        public object desapilar()
        {
            object elementoEliminado = elementos[elementos.Count - 1];

            elementos.RemoveAt(elementos.Count - 1);

            return elementoEliminado;
        }

        public bool estaVacia()
        {
            return elementos.Count == 0; 
        }

        public object verTope()
        {
            return elementos[elementos.Count - 1];
        }

    }
}
