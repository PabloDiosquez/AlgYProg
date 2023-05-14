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

        /// <summary>
        /// Si la colección en donde buscar se encuentra ordenada entonces es posible utilizar la búsqueda binaria
        /// que permite encontrar un elemento de forma más rápida que la secuencial.
        /// Se sitúa la lectura en el centro de la colección y se comprueba si la clave coincide con el valor del
        /// elementocentral.Si no se encuentra el valor de la clave, se sigue la búsqueda en la mitad inferior o 
        /// superior del elemento central de la colección.
        /// </summary>
        /// <param name="numeros">Array de números enteros</param>
        /// <param name="clave">Valor destino</param>
        /// <returns>Booleano</returns>
        public static bool BusquedaBinaria(int[] numeros, int clave)
        {
            int inicio = 0;

            int final = numeros.Length - 1;

            int mitad;

            while (inicio <= final)
            {
                mitad = (inicio + final) / 2;

                if (numeros[mitad] == clave)
                    return true;

                else if (numeros[mitad] < clave) 
                    inicio = mitad + 1;
                else
                    final = mitad - 1;
            }

            return false;
        }
    }
}
