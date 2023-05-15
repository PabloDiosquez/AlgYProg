using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9
{
    public class Ordenamiento
    {
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
    }
}
