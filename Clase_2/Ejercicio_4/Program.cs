using System;
using System.Collections;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Haga un programa de aplicación que lea por consola una sucesión de palabras que termina con la palabra vacía.
            //Imprima el porcentaje de palabras que comienzan con ‘s’, la longitud de cada palabra leída y el promedio de
            //caracteres por palabra.

            CargarYProcesarArrayDePalabras();
        }

        public static void CargarYProcesarArrayDePalabras()
        {
            ArrayList palabras = CargarPalabras();

            Console.WriteLine($"Porcentaje de palabras que comienzan con 's': {ObtenerPorcentajeDePalabrasQueComienzanCon_(palabras, 'S').ToString("0.00")}%");

            ImprimirLongitudDeCadaPalabraLeida(palabras);

            Console.WriteLine($"Promedio de caracteres por palabra: {ObtenerPromedioDeCaracteresPorPalabraEnElArray(palabras)}");
        }

        /// <summary>
        /// Describe un arrayList de palabras cargadas por teclado.
        /// </summary>
        /// <returns>ArrayList de palabras</returns>
        private static ArrayList CargarPalabras()
        {
            ArrayList palabras = new ArrayList();

            string palabra;

            while (true)
            {
                Console.WriteLine("Palabra: ");

                palabra = Console.ReadLine();

                if (palabra == string.Empty) break;
               
                palabras.Add(palabra);

            }

            return palabras;
        }

        /// <summary>
        /// Describe el porcentaje de palabras del arrayList dado que comienzan con el caracter dado.
        /// Precondición:
        /// * El arrayList no debe contener palabras nulas ni vacías.
        /// </summary>
        /// <param name="palabras">ArrayList de palabras</param>
        /// <param name="letra">Caracter - Char</param>
        /// <returns>Double</returns>
        private static double ObtenerPorcentajeDePalabrasQueComienzanCon_(ArrayList palabras, char letra)
        {
            if (palabras.Count == 0) return 0;
            
            int contador = 0;

            foreach (string palabra in palabras)
            {
                if (Palabra_ComienzaCon_(palabra, letra)) contador++;
            }

            return (contador / (double)palabras.Count) * 100;
        }

        /// <summary>
        /// Imprime por consola la longitud de cada palabra del arrayList de palabras dado.
        /// </summary>
        /// <param name="palabras">ArrayList de palabras - [String]</param>
        private static void ImprimirLongitudDeCadaPalabraLeida(ArrayList palabras)
        {
            foreach (string palabra in palabras)
            {
                Console.WriteLine($"Palabra: {palabra} -- Longitud: {palabra.Length}");
            }
        }

        /// <summary>
        /// Describe el promedio de caracteres por palabra en el arrayList de palabras dado.
        /// Precondiciones:
        /// * El arrayList no debe contener palabras nulas ni vacías.
        /// </summary>
        /// <param name="palabras">ArrayList de palabras</param>
        /// <returns>Promedio - Double</returns>
        private static double ObtenerPromedioDeCaracteresPorPalabraEnElArray(ArrayList palabras) 
        {
            int longitudDelArray = palabras.Count;

            if (longitudDelArray == 0) return 0;
            
            int sumador = 0;

            foreach (string palabra in palabras)
            {
                sumador += palabra.Length;
            }

            return sumador / longitudDelArray;
        }

        /// <summary>
        /// Indica si la palabra dada comienza con el caracter dado.
        /// Precondición:
        /// * La palabra dada no debe ser nula ni vacía.
        /// </summary>
        /// <param name="palabra">Palabra - String</param>
        /// <param name="letra">Caracter - Char</param>
        /// <returns>Bool</returns>
        private static bool Palabra_ComienzaCon_(string palabra, char letra)
        {
            return palabra.ToUpper()[0] == letra || palabra.ToLower()[0] == letra;
        }
    }
}
