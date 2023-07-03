using System;
using System.Text;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que solicite al usuario ingresar su nombre y apellido, e imprima en la consola un
            //saludo personalizado utilizando ese nombre e informe entre() la cantidad de letras que conforman la oración
            //impresa.Ejemplo: Hola Juan Perez, bienvenido a la materia( 40 )

            Console.WriteLine("Nombre usuario:");

            Console.WriteLine(saludarYContarCaracteres(Console.ReadLine()));

        }

        /// <summary>
        /// Describe un string con un mensaje de bienvenida para el usuario dado y la cantidad de caracteres de la oración que 
        /// lo recibe.
        /// </summary>
        /// <param name="nombreUsuario">Nombre del usuario</param>
        /// <returns>String</returns>
        public static string saludarYContarCaracteres(string nombreUsuario)
        {
            string mensajeDeBienvenida = $"Hola {nombreUsuario}, bienvenido a la materia";

            return $"{mensajeDeBienvenida} ({contadorDeCaracteres(mensajeDeBienvenida)})";
        }

        /// <summary>
        /// Describe la cantidad de caracteres de la cadena de caracteres dada.
        /// </summary>
        /// <param name="caracteres">Cadena de caracteres</param>
        /// <returns>Número</returns>
        private static int contadorDeCaracteres(string caracteres)
        {
            int contador = 0;

            foreach (char caracter in caracteres)
            {
                contador++;
            }
            return contador;
        }
    }
}
