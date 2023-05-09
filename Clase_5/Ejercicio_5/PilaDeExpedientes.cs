using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_5
{
    /// <summary>
    /// Representa una pila de objetos de tipo Expediente, a través de una colección LIFO
    /// (el último en entrar es el primero en salir) de tamaño variable.
    /// </summary>
    public class PilaDeExpedientes
    {
        //Atributos
        
        private ArrayList expedientes;

        /// <summary>
        /// Inicializa una nueva instancia de una colección de expedientes que está vacía y tiene capacidad de almacenamiento variable.
        /// </summary>
        public PilaDeExpedientes()
        {
            expedientes = new ArrayList();
        }

        // Métodos

        /// <summary>
        /// Apila un expediente en el tope de la pila de expedientes.
        /// </summary>
        /// <param name="expediente">Expediente</param>
        public void ApilarExpediente(Expediente expediente)
        {
            expedientes.Add(expediente);
        }

        /// <summary>
        /// Desapila un expediente, quitándolo del tope de la pila de expedientes.
        /// </summary>
        /// <returns>expediente ➡ Tipo: Expediente</returns>
        public Expediente DesapilarExpediente()
        {
            int ultimaPosicion = expedientes.Count - 1;

            Expediente expediente = (Expediente)expedientes[ultimaPosicion];

            expedientes.Remove(expediente);

            return expediente;
        }

        /// <summary>
        /// Indica si la pila de expedientes está vacía.
        /// Tipo: Booleano
        /// </summary>
        /// <returns>Booleano</returns>
        public bool estaVacia()
        {
            return expedientes.Count == 0;
        }

        /// <summary>
        /// Describe el tope de la pila de expedientes.
        /// </summary>
        /// <returns>expediente ➡ Tipo: Expediente</returns>
        public Expediente VerTope()
        {
            return (Expediente)expedientes[0];
        }

        
    }
}
