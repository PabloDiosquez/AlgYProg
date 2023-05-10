using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    /// <summary>
    /// Un cliente tiene un número en una cola de servicios según lo que necesite.
    /// </summary>
    public class Cliente
    {
        // Atributos

        private int numeroCliente;

        // Constructor vacío
        public Cliente()
        {
        }

        /// <summary>
        /// Describe el número asignado al cliente actual. Además, modifica el estado del cliente asignado un número de cliente.
        /// </summary>
        public int NumeroDeCliente
        {
            get { return numeroCliente; }

            set { numeroCliente = value; }
        }
    }
}
