using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /// <summary>
    /// Una butaca consta de un número y puede estar libre u ocupada.
    /// </summary>
    public class Butaca
    {
        // Atributos

        private int numero;

        private bool estaLibre;

        // Constructor
        public Butaca(int numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Describe el número asignado a la butaca.
        /// Tipo: int
        /// </summary>
        public int NumeroDeButaca
        {
            get { return numero; }
        }

        /// <summary>
        /// Indica si la butaca está libre. Además, permite cambiar el estado de la butaca para indicar si ésta fue ocupada.
        /// </summary>
        public bool EstaLibre
        {
            get { return estaLibre; }

            set { estaLibre = value; }
        }

    }
}
