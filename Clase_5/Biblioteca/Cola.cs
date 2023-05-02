using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Biblioteca
{
    //Implementación de la clase Cola (genérica, elementos de clase Object)
    public class Cola
    {
        private ArrayList elementos;

        public Cola()
        {
            elementos = new ArrayList();    
        }

        // Métodos

        public void encolar(object elemento) 
        {
            elementos.Add(elemento);
        }

        public object desencolar()
        {
            object elemento = elementos[0];

            elementos.RemoveAt(0);  

            return elemento;
        }

        public bool estaVacia()
        {
            return elementos.Count == 0;
        }

        public object verTope()
        {
            return elementos[0];
        }
    }
}
