using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que imprima en la consola todos los números pares que además sean múltiplos
            //de 5 y estén comprendidos entre 250 y 900.

            // ImprimirNumerosParesYMultiplosDe5Desde_Hasta_(250, 900);

            multiplosDe_Y_Desde_Hasta_(2, 5, 290, 900);
        }

        public static void ImprimirNumerosParesYMultiplosDe5Desde_Hasta_(int desde, int hasta)
        {
            if (!esPar(desde)) desde++;

            for (int numero = desde; numero <= hasta; numero += 2)
            {
                if (es_MultiploDe_(numero, 5))
                {
                    Console.WriteLine(numero);
                }
            }

        }

        /// <summary>
        /// Indica si e número dado es múltiplo de 2.
        /// </summary>
        /// <param name="numero">Número</param>
        /// <returns>Bool</returns>
        private static bool esPar(int numero)
        {
            return es_MultiploDe_(numero, 2);
        }

        /// <summary>
        /// Indica si el primer número dado es múltiplo del segundo número dado.
        /// Precondiciones:
        /// * El segundo número dado debe ser distinto de 0.
        /// </summary>
        /// <param name="primerNumero">Número</param>
        /// <param name="segundoNumero">Número</param>
        /// <returns>Bool</returns>
        private static bool es_MultiploDe_(int primerNumero, int segundoNumero)
        {
            return primerNumero % segundoNumero == 0;
        }

        /// <summary>
        /// Imprime todos los números desde **desde** y hasta **hasta** si son múltiplos de **primerNumero** y de 
        /// **segundoNumero**.
        /// Precondición:
        /// * **primerNumero** y **segundoNumero** deben ser distintos de 0.
        /// * **desde** debe ser <= **hasta**.
        /// </summary>
        /// <param name="primerNumero">Numero</param>
        /// <param name="segundoNumero">Numero</param>
        /// <param name="desde">Numero</param>
        /// <param name="hasta">Numero</param>
        private static void multiplosDe_Y_Desde_Hasta_(int primerNumero, int segundoNumero, int desde, int hasta)
        {
            for (int numero = desde; numero < hasta; numero++)
            {
                imprimirNumero_Si_(numero, es_MultiploDe_(numero, 2) && es_MultiploDe_(numero, 5));
            }
        }

        /// <summary>
        /// Imprime por consola el número dado si se cumple la condición dada.
        /// </summary>
        /// <param name="numero">Número</param>
        /// <param name="condicion">Bool</param>
        private static void imprimirNumero_Si_(int numero, bool condicion)
        {
            if (condicion) Console.WriteLine(numero);
        }
    }
}
