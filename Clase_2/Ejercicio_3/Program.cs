using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que lea 2 palabras y determine si son palíndromos entre ellas. (Ej: “abbccd”
            //y “dccbba” son palíndromos).

            Console.WriteLine("Primer palabra: ");

            string primerPalabra = Console.ReadLine();

            Console.WriteLine("Segunda Palabra: ");

            string segundaPalabra = Console.ReadLine();

            if (sonPalindromos(primerPalabra, segundaPalabra))
            {
                Console.WriteLine($"'{primerPalabra}' y '{segundaPalabra}' son palíndromos.");
            }
            else 
            {
                Console.WriteLine("No son palíndromos.");
            }

        }

        public static bool sonPalindromos(string primerPalabra, string segundaPalabra)
        {
            return primerPalabra.Length == segundaPalabra.Length && primerPalabra == RevertirPalabra(segundaPalabra);
        }

        public static string RevertirPalabra(string palabra)
        {
            string palabraInvertida = "";

            for (int i = palabra.Length-1; i >= 0 ; i--)
            {
                palabraInvertida += palabra[i];
            }

            return palabraInvertida;    
        }
    }
}
