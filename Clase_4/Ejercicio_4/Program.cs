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
                Console.WriteLine("Ingrese: Nombre <TAB> Documento <TAB> Edad <ENTER>.");

                datos = Console.ReadLine();

                if (datos == string.Empty)
                {
                    break;
                }

                personas.Add(new Persona(datos));
            }

            foreach (Persona persona in personas)
            {
                Console.WriteLine($"{indice}) {persona.MostrarDatos()}");

                indice++;
            }
        }

        // 5.

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
