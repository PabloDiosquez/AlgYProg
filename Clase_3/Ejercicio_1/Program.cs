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

        public static int ContarPalindromosIII(ArrayList palabras)
        {
            int totalPalindromos = 0;

            int indice = 0;

            while (indice < palabras.Count)
            {
                if(esPalindromo((string)palabras[indice]))

                indice++;
            }

            return totalPalindromos;    
        }

        public static int ContarPalindromosII(ArrayList palabras)
        {
            int totalPalindromos = 0;

            for (int i = 0; i < palabras.Count; i++)
            {
                if (esPalindromo((string)palabras[i]))
                {
                    totalPalindromos++;
                }
            }

            return totalPalindromos;
        }

        public static int ContarPalindromosI(ArrayList palabras)
        {
            int totalPalindromos = 0;

            foreach (string palabra in palabras)
            {
                if (esPalindromo(palabra))
                {
                    totalPalindromos++; 
                }
            }

            return totalPalindromos;
        }

        public static bool esPalindromo(string palabra)
        {
            string palabraInvertida = InvertirPalabra(palabra);

            return palabra == palabraInvertida;
        }

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
