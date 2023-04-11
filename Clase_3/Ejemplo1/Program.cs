using System;
using System.Collections;

namespace Teoría
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad;

            Console.WriteLine("Cantidad de apellidos en la lista:");

            cantidad = int.Parse(Console.ReadLine());

            string[] listaApellidos = new string[cantidad];

            AgregarApellidos(listaApellidos);

            Console.WriteLine("\nApellidos de la lista:");

            ImprimirApellidos(listaApellidos);
        }

        public static void ImprimirApellidos(string[] apellidos)
        {
            foreach (string apellido in apellidos)
            {
                Console.WriteLine(apellido);
            }
        }
        public static void AgregarApellidos(string[] apellidos)
        {
            for (int i = 0; i < apellidos.Length; i++)
            {
                Console.WriteLine("Apellido:");

                AgregarApellidoALaLista(Console.ReadLine(), i, ref apellidos);
            }
        }
        public static void AgregarApellidoALaLista(string apellido, int indice, ref string[] apellidos)
        {
            apellidos[indice] = apellido;
        }
    }    
}
