using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9
{
    public class Ordenamiento
    {
        // 🔹 Ordenamiento por intercambio

        //Se basa en el recorrido secuencial de la colección a ordenar, comparando el elemento que se encuentra en una
        //posición fija de la colección contra todos los elementos posteriores y efectuando intercambio de elementos cuando
        //el orden resultante de la comparación no sea el correcto.

        //Este algoritmo necesita realizar n−1 pasadas para finalizar la tarea, donde n es la cantidad de elementos
        //de la colección.

        /// <summary>
        /// Ordena el array de números dado de menor a mayor.
        /// </summary>
        /// <param name="numeros">Array de números ➡ int[]</param>
        public static void OrdenarPorIntercambioDeMenorAMayor(int[] numeros) 
        {
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = i+1; j < numeros.Length; j++)
                {
                    if (numeros[i] > numeros[j]) 
                    {
                        int swap = numeros[i];

                        numeros[i] = numeros[j];

                        numeros[j] = swap;
                    }
                }
            }    
        }

        // 🔹 Ordenamiento por selección

        //Este algoritmo realiza los siguientes pasos:

        //1. Seleccionar el elemento más pequeño de la lista; intercambiarlo con el primer elemento.Ahora la entrada más
        //pequeña está en la primera posición.

        //2. Considerar las posiciones restantes de la lista y seleccionar el elemento más pequeño e intercambiarlo con el
        //segundo elemento. Ahora las dos primeras entradas están en orden.

        //3. Continuar este proceso seleccionando los elementos más pequeño de los restantes elementos de la lista e
        //intercambiándolos adecuadamente.

        /// <summary>
        /// Ordena el array de números dado de menor a mayor.
        /// </summary>
        /// <param name="numeros">Array de números ➡ int[]</param>
        public static void OrdenarPorSeleccionDeMenorAMayor(int[] numeros) 
        {
            // Buscar el mínimo elemento.

            for (int i = 0; i < numeros.Length - 1; i++)
            {
                int indiceMinimo = i;

                for (int j = i + 1; j < numeros.Length; j++)
                {
                    if (numeros[indiceMinimo] > numeros[j]) 
                    {
                        indiceMinimo = j;
                    }
                }

                // Intercambiarlo

                if (indiceMinimo != i)
                {
                    int swap = numeros[indiceMinimo];

                    numeros[indiceMinimo] = numeros[j];

                    numeros[j] = swap;
                }
            }

        }
    }
}
