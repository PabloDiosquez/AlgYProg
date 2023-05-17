using System;
using System.Collections;

namespace Ejercicios_4_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList personas = new ArrayList();   

            string datos;

            int indice = 1;

            while (true)
            {
                if (datosIngresados() == string.Empty)
                {
                    break;
                }

                personas.Add(new Persona(datosIngresados()));
            }

            foreach (Persona persona in personas)
            {
                Console.WriteLine($"{indice}) {persona.MostrarDatos()}");

                indice++;
            }
        }

        // 5.
        /// <summary>
        /// Describe el ingreso de datos por parte del usuario de la App.
        /// </summary>
        /// <returns>String</returns>
        public static string datosIngresados()
        {
            Console.WriteLine("Ingrese datos de la persona. Puede elegir entre dos formatos:");

            Console.WriteLine("Ingrese: Nombre <TAB> Documento <TAB> Edad <ENTER>.");

            Console.WriteLine("Ingrese: Nombre <TAB> Documento <TAB> Fecha de Nacimiento (día/mes/año) <ENTER>");

            return Console.ReadLine();

        }

        // 6.

        /// <summary>
        /// Dado un grupo de personas, describe la persona de mayor edad.
        /// Precondición: El grupo de personas dado no debe estar vacío.
        /// </summary>
        /// <param name="personas"></param>
        /// <returns></returns>
        public static Persona personaDeMayorEdadDe_(ArrayList personas)
        {
            Persona personaDeMayorEdad = (Persona)personas[0];

            foreach (Persona persona in personas)
            {
                if (persona.esMayorQue(personaDeMayorEdad))
                {
                    personaDeMayorEdad = (Persona)persona;
                }
            }

            return personaDeMayorEdad;
        } 
    }
}
