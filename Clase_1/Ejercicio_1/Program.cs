using System;

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

            SaludarYContarCaracteres(Console.ReadLine());

        }

        public static void SaludarYContarCaracteres(string nombreUsuario)
        {
            //int contador = 0;

            string mensaje = $"Hola {nombreUsuario}, bienvenido a la materia";

            //foreach (char caracter in mensaje)
            //{
            //    contador++;
            //}

            //Console.WriteLine($"{mensaje} ({contador})");

            Console.WriteLine($"{mensaje} ({mensaje.Length})");
        }
    }
}
