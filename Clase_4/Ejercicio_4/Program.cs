using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona;

            string datos;

            while (true)
            {
                Console.WriteLine("Ingrese: Nombre <TAB> Documento <TAB> Edad <ENTER>.");

                datos = Console.ReadLine();

                if (datos == string.Empty)
                {
                    break;
                }

                persona = new Persona(datos);
            }
        }
    }
}
