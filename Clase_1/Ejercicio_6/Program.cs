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

        private static void SumarYContar()
        {
            int numero, contador = 0, sumador = 0;

            while (true)
            {
                menuInicial();

                numero = asignarNumero();

                if (numero == 0) break;

                sumador += numero;

                contador++;

                mostrarSumaParcial(sumador);
            }

            menuFinal(contador, sumador);

        }
        private static int asignarNumero()
        {
            int numero;

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingresar un número entero. Intente de nuevo.");
            }

            return numero;
        }

        private static void menuInicial()
        {
            Console.WriteLine("Ingrese un número: (Termina con 0)");
        }

        private static void mostrarSumaParcial(int suma) 
        {
            Console.WriteLine($"Suma parcial: {suma}");
        }

        private static void menuFinal(int contador, int suma)
        {
            Console.WriteLine($"Cantidad de números: {contador}");

            Console.WriteLine($"Suma total: {suma}");
        }
    }
}
