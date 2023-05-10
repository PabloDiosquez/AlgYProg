using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_6
{
    /// <summary>
    /// Una cola de clientes correspondiente a un servicio de la compañía de seguros.
    /// </summary>
    public class ColaDeClientes
    {
        // Atributos

        private ArrayList clientes;

        // Constructor
        public ColaDeClientes()
        {
            clientes = new ArrayList();

        }

        /// <summary>
        /// Agrega un cliente a la cola de un determinado servicio de la compañía de seguros. Asigna además, un número de cliente
        /// al cliente, que se corresponde con su posición en la cola de clientes.
        /// </summary>
        /// <param name="cliente">El cliente que se agrega a la cola de clientes ➡ Cliente</param>
        public void Encolar(Cliente cliente)
        {
            clientes.Add(cliente);

            cliente.NumeroDeCliente = clientes.IndexOf(cliente) + 1;
        }

        /// <summary>
        /// Desencola al cliente que está al inicio de la cola de clientes.
        /// </summary>
        /// <returns>Cliente</returns>
        public Cliente Desencolar()
        {
            Cliente cliente = (Cliente)clientes[0];

            clientes.Remove(cliente);

            return cliente;
        }

        /// <summary>
        /// Indica si la cola de clientes está vacía.
        /// </summary>
        /// <returns>Booleano</returns>
        public bool esVacia()
        {
            return clientes.Count == 0;
        }

        /// <summary>
        /// Muestra al primer cliente de la cola de clientes de determinado servicio de la compañía de seguros.
        /// </summary>
        /// <returns>Cliente</returns>
        public Cliente verTope()
        {
            Cliente primerCliente = (Cliente)clientes[0];

            return primerCliente;
        }
    }
}
