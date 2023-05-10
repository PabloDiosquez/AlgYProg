using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class ClaseB : ClaseA
    {
        /// <summary>
        /// Método de instancia que describe la jerarquía desde la claseA hasta aquella a la él pertenece en forma invertida.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return $"Clase B {base.ToString()}";
        }
    }
}
