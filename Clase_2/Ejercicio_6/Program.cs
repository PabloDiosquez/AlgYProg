using System;
using System.Collections.Generic;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defina una función que reciba una palabra y retorne en un vector la cantidad de cada una de las vocales que
            //contiene.

            //ContarVocales();

            MostrarVector(vectorCantidadDeVocalesDe_(Console.ReadLine()));

        }

        private static void ContarVocales()
        {
            Console.WriteLine("Palabra: ");

            foreach (string st in vectorConCantidadVocalesEn_(Console.ReadLine()))
            {
                Console.WriteLine(st);
            }
        }

        /// <summary>
        /// Describe un vector con la cantidad de repeticiones de cada vocal en la palabra dada.
        /// </summary>
        /// <param name="palabra">Palabra - String</param>
        /// <returns>Vector [String] - string []</returns>
        private static string[] vectorConCantidadVocalesEn_(string palabra)
        {
            int cantidadLetraA = 0, cantidadLetraE = 0, cantidadLetraI = 0, cantidadLetraO = 0, cantidadLetraU = 0;

            string[] vocales = new string[5];

            foreach (char caracter in palabra.ToLower())
            {
                switch (caracter)
                {
                    case 'a':
                        cantidadLetraA++;
                        break;
                    case 'e':
                        cantidadLetraE++;
                        break;
                    case 'i':
                        cantidadLetraI++;
                        break;
                    case 'o':
                        cantidadLetraO++;
                        break;
                    case 'u':
                        cantidadLetraU++;
                        break;
                }
            }

            vocales[0] = $"a: {cantidadLetraA}";
            vocales[1] = $"e: {cantidadLetraE}";
            vocales[2] = $"i: {cantidadLetraI}";
            vocales[3] = $"o: {cantidadLetraO}";
            vocales[4] = $"u: {cantidadLetraU}";

            return vocales;
        }

        // ----------------------------------------------------------------------------

        /// <summary>
        /// Imprime el vector de números dado por consola.
        /// </summary>
        /// <param name="vector">Vector[Número] - int[]</param>
        private static void MostrarVector(int[] vector)
        {
            foreach (int numero in vector)
            {
                Console.WriteLine(numero);
            }
        }

        /// <summary>
        /// Describe un vector de enteros con la cantidad de repeticiones de cada vocal en la palabra dada.
        /// Observaciones:
        /// * Cada componente del vector hace referencia a una vocal en el orden esperado. Esto es, la primer componente
        /// hace referencia a las repeticiones de la "a", la segunda de la "e" y así siguiendo.
        /// </summary>
        /// <param name="palabra">String</param>
        /// <returns>Vector[Número] - int[]</returns>
        private static int[] vectorCantidadDeVocalesDe_(string palabra) 
        {
            int[] cantidadDeVocales = new int[5] { 0,0,0,0,0};

            foreach (char letra in palabra)
            {
                cantidadDeVocales = vectorDeVocales_Actualizado(cantidadDeVocales, letra);
            }

            return cantidadDeVocales;
        }

        /// <summary>
        /// Describe el vector de repeticiones de las vocales actualizado.
        /// </summary>
        /// <param name="vocales">Vector[Número] - int[]</param>
        /// <param name="letra">Letra - Char</param>
        /// <returns>Vector[Número] - int[]</returns>
        private static int[] vectorDeVocales_Actualizado(int[] vocales, char letra)
        {
            switch (letra)
            {
                case 'a':
                    vocales[0]++;
                    break;
                case 'e':
                    vocales[1]++;
                    break;
                case 'i':
                    vocales[2]++;
                    break;
                case 'o':
                    vocales[3]++;   
                    break;
                case 'u':
                    vocales[4]++;
                    break;
                default:
                    break;
            }

            return vocales;
        } 
    }
}
