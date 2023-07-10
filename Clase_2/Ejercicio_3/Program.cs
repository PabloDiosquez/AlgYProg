using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que lea 2 palabras y determine si son palíndromos entre ellas. (Ej: “abbccd”
            //y “dccbba” son palíndromos).

            palindromos();
        }

        private static void palindromos()
        {
            Console.WriteLine("Primer palabra: ");

            string primerPalabra = Console.ReadLine();

            Console.WriteLine("Segunda Palabra: ");

            string segundaPalabra = Console.ReadLine();

            if (sonPalindromosEntre_Y_(primerPalabra, segundaPalabra))
            {
                Console.WriteLine($"'{primerPalabra}' y '{segundaPalabra}' son palíndromos.");
            }
            else
            {
                Console.WriteLine("No son palíndromos.");
            }
        }

        /// <summary>
        /// Indica si las dos palabras dadas son palíndromos entre ellas.
        /// </summary>
        /// <param name="primerPalabra">Primer palabra - String</param>
        /// <param name="segundaPalabra">Segunda palabra - String</param>
        /// <returns>Bool</returns>
        private static bool sonPalindromosEntre_Y_(string primerPalabra, string segundaPalabra)
        {
            return primerPalabra.Length == segundaPalabra.Length && primerPalabra == RevertirPalabra(segundaPalabra);
        }

        /// <summary>
        /// Revierte la palabra dada.
        /// </summary>
        /// <param name="palabra">Palabra - String</param>
        /// <returns>Palabra invertida - String</returns>
        private static string RevertirPalabra(string palabra)
        {
            string palabraInvertida = string.Empty;

            for (int i = palabra.Length-1; i >= 0 ; i--)
            {
                palabraInvertida += palabra[i];
            }

            return palabraInvertida;    
        }

        /// <summary>
        /// Indica si la palabra dada es un palíndromo.
        /// </summary>
        /// <param name="palabra">Palabra - String</param>
        /// <returns>Bool</returns>
        private static bool esPalindromo(string palabra)
        {
            return !string.IsNullOrEmpty(palabra) && palabra == RevertirPalabra(palabra);
        }
    }
}
