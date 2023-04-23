using System;
using System.Collections;

namespace Ejercicio_4
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
                Console.WriteLine($"{indice} {persona.MostrarDatos()}");

                indice++;
            }
        }
    }
}
