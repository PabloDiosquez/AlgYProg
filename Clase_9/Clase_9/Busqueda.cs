using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9
{
    public static class Busqueda
    {
        /// <summary>
        /// La búsqueda secuencial busca un elemento de una colección utilizando un valor destino llamado clave.
        /// En una búsqueda secuencial(a veces llamada búsqueda lineal), los elementos de una lista o vector se
        /// exploran (se examinan) en secuencia, uno después de otro.
        /// </summary>
        /// <param name="numeros">Array de números enteros</param>
        /// <param name="key">Valor destino</param>
        /// <returns>Booleano</returns>
        public static bool BusquedaSecuencial(int[] numeros, int clave)
        {
            foreach (int numero in numeros)
            {
                if (numero == clave)
                    return true;
            }

            return false;
        }
    }
}
