using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Clase_9
{
    /// <summary>
    /// Modela un alumno el cual tiene un número de legajo y un promedio.
    /// </summary>
    public class Alumno: IComparable //IComparable es una interface que una clase implementa para ordenar sus
                                     //elementos que se basa en el uso de un método general de comparación.
    {
        // Atributos

        private int legajo;

        private double promedio;

        // Constructor
        public Alumno(int legajo, double promedio)
        {
            this.legajo = legajo;   

            this.promedio = promedio;
        }

        /// <summary>
        /// Describe el legajo del alumno.
        /// </summary>
        public int Legajo
        {
            get { return legajo; }  
        }

        /// <summary>
        /// Describe el promedio del alumno.
        /// </summary>
        public double Promedio
        {
            get { return promedio; }
        }

        /// <summary>
        /// Describe los datos del alumno.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"Legajo: {legajo} -- Promedio: {promedio}";
        }

        //El método CompareTo() permite realizar las comparaciones entre objetos.
        //Compara la instancia actual con otro objeto del mismo tipo y devuelve un entero que indica si la instancia
        //actual es mayor, menor o igual que el otro objeto, de acuerdo al criterio de comparación establecido.

        /// <summary>
        /// Realiza la comparación entre la instancia que recibe el mensaje (this) y la otra instancia que recibe como parámetro.
        /// Describe  1 si this es <<mayor>> que la instancia dada.
        /// Describe -1 si this es <<menor>> que la instancia dada.
        /// Describe  0 si this es <<igual>> que la instancia dada.
        /// </summary>
        /// <param name="otroAlumno">Alumno</param>
        /// <returns></returns>
        public int CompareTo(object otroAlumno)
        {
            if (promedio > ((Alumno)otroAlumno).promedio)
            {
                return 1;
            }
            else if (promedio < ((Alumno)otroAlumno).promedio)
            {
                return -1;
            }

            return 0;
        }

        //Definir nuestra función de ordenación para que ordene objetos del tipo IComparable.

        /// <summary>
        /// Ordena a los alumnos de menor a mayor de acuerdo a su promedio.
        /// </summary>
        /// <param name="alumnos">ArrayList de alumnos</param>
        public static void OrdenarAlumnosPorPromedio(ArrayList alumnos) 
        {
            for (int i = 0; i < alumnos.Count - 1; i++)
            {
                for (int j = i+1; j < alumnos.Count; j++)
                {
                    if (((Alumno)alumnos[i]).CompareTo(alumnos[j]) > 0)
                    {
                        IComparable swap = (IComparable)alumnos[i];

                        alumnos[i] = alumnos[j];

                        alumnos[j] = swap;
                    }
                }
            }
        }
    }
}
