using System;
using System.Collections;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que reciba una lista de palabras e informe cuáles son palíndromos
            //usando una función.En el programa principal, al ingresar las palabras resuelva el ejercicio:

            //i.A) utilizando la sentencia while
            //ii.B) utilizando la sentencia for
            //iii.C) utilizando la sentencia foreach

        }

        public static void ContarPalindromosIII(ArrayList palabras)
        {
            int indice = 0;

            while (indice < palabras.Count)
            {
                if(esPalindromo((string)palabras[indice]))

                    Console.WriteLine(palabras[indice]);
            }   
        }

        public static void ContarPalindromosII(ArrayList palabras)
        {
            for (int i = 0; i < palabras.Count; i++)
            {
                if (esPalindromo((string)palabras[i]))
                {
                    Console.WriteLine(palabras[i]);
                }
            }
        }

        public static void ContarPalindromosI(ArrayList palabras)
        { 
            foreach (string palabra in palabras)
            {
                if (esPalindromo(palabra))
                {
                    Console.WriteLine(palabra); 
                }
            }
        }

        public static bool esPalindromo(string palabra)
        {
            string palabraInvertida = InvertirPalabra(palabra);

            return palabra == palabraInvertida;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="palabra"></param>
        /// <returns></returns>
        public static string InvertirPalabra(string palabra)
        {
            string palabraInvertida = string.Empty;

            for (int i = palabra.Length - 1; i > -1; i--)
            {
                palabraInvertida += palabra[i]; 
            }

            return palabraInvertida;
        }
    }
}
