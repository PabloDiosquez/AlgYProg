using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implemente un programa de aplicación que permita al usuario ingresar números por la consola. A medida que
            //se van ingresando los valores el sistema debe mostrar por la consola la suma acumulada de los mismos.El
            //proceso termina cuando se ingresa un 0.Informar al final la cantidad total de números ingresados y sumados.

            SumarYContar();
        }

        public static void SumarYContar()
        {
            int numero, contador = 0, sumador = 0;

            do
            {
                Console.WriteLine("Ingrese un número: (Termina con 0)");

                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break;
                }

                sumador += numero;

                contador++;

            } while (true);

            Console.WriteLine($"Cantidad de números: {contador}");

            Console.WriteLine($"Suma total: {sumador}");

        }
    }
}
