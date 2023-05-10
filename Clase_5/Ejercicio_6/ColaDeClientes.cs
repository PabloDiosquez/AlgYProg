using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_6
{
    public class ColaDeClientes
    {
        private ArrayList clientes;

        public ColaDeClientes()
        {
            clientes = new ArrayList();
        }

        public void Encolar(Cliente cliente) 
        {
            clientes.Add(cliente);
        }

        public Cliente Desencolar()
        {
            Cliente cliente = (Cliente)clientes[0];

            clientes.Remove(cliente);

            return cliente;
        }

        public bool esVacia()
        {
            return clientes.Count == 0;
        }

        public Cliente verTope()
        {
            Cliente primerCliente = (Cliente)clientes[0];

            return primerCliente;
        }
    }
}
