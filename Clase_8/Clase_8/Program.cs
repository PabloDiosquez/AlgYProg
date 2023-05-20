﻿using System;
using System.Collections;

namespace Clase_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(esPalindromo("anitalavalatina"));
        }

        // 🔸 Ejercicios.

        //1️⃣ Implemente una función recursiva que calcule el factorial de un número n, el cual es
        //pasado por parámetro.

        /// <summary>
        /// Devuelve el factorial del número dado.
        /// Precondición: El número dado debe ser un entero >= 0.
        /// </summary>
        /// <param name="numero">Número - Tipo: int</param>
        /// <returns>Número - Tipo: int</returns>
        public static int factorial(int numero)
        {
            if (numero == 0)
                return 1;

            return factorial(numero - 1)*numero;
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //2) Implemente una función recursiva que imprima por consola la secuencia de Fibonacci hasta
        //un número pasado por parámetro.La secuencia de Fibonacci se genera sumando dos
        //números consecutivos para obtener elsiguiente.La definición es la siguiente:
        //f1 = 1
        //f2 = 1
        //fn = fn-1 + fn–2 para n >= 3
        //La serie Fibonacci hasta el número 8→ es: 1, 1, 2, 3, 5, 8, 13, 21

        /// <summary>
        /// Imprime por consola la secuencia de Fibonacci hasta el número dado por parámetro.
        /// Precondición: El número dado debe ser un entero >= 0
        /// </summary>
        /// <param name="numero">Número - Tipo - int</param>
        /// <returns>String</returns>
        public static string fibonacciV1(int numero)
        {
            if (numero == 1)
                return "1";

            return fibonacciV1(numero - 1) + $", {fibo(numero)}";
        }

        /// <summary>
        /// Devuelve el nésimo número de la secuencia de Fibonacci. Esto es, devuelve el número que se encuentra en la posición 
        /// dada como parámetro.
        /// Precondición: El número dado como parámetro debe ser un entero >= 0
        /// </summary>
        /// <param name="n">Posición según la cual se describe el número de la secuencia de Fibonacci correspondiente</param>
        /// <returns>Número - Tipo: int</returns>
        private static int fibo(int n) 
        {
            if (n <= 2)
                return 1;
            
            return fibo(n - 1) + fibo(n - 2);
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //3) Modifique la función anterior para, que en vez de imprimir por consola, devuelva la serie
        //en un ArrayList.


        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //5) Escriba una función recursiva que reciba un string y retorne la cantidad de vocales que
        //contiene.

        /// <summary>
        /// Describe la cantidad de vocales que tiene la frase o palabra dada.
        /// </summary>
        /// <param name="palabra">Palabra según la cual se describe la cantidad de vocales - Tipo: string</param>
        /// <returns>Número - Tipo: int</returns>
        public static int cantidadDeVocales(string palabra)
        {
            if (palabra == string.Empty)
                return 0;

            string ultimaLetra = palabra.Substring(palabra.Length - 1);

            return cantidadDeVocales(palabra.Remove(palabra.Length - 1)) + unoSi_CeroSino(esVocal(ultimaLetra));
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //7) Escriba una función recursiva que reciba un string como parámetro y devuelva si es o
        //no palíndromo.

        /// <summary>
        /// Indica si la palabra o frase dada es un palíndromo.
        /// </summary>
        /// <param name="str">String</param>
        /// <returns>Booleano</returns>
        public static bool esPalindromo(string str)
        {
            return esPalindromoDesde_(str, 0);
        }

        /// <summary>
        /// Dado una palabra o frase, indica si es un palíndromo desde determinada letra (indexada por **índice**).
        /// Precondición: **índice** debe ser un entero >= 0 y <= longitud de la palabra o frase dada.
        /// </summary>
        /// <param name="str">Palabra o frase - Tipo: string</param>
        /// <param name="indice">Índice - Tipo: int</param>
        /// <returns>Booleano</returns>
        private static bool esPalindromoDesde_(string str, int indice)
        {
            if (indice > str.Length/2)
                return true;

            return esPalindromoDesde_(str, indice + 1) && str[str.Length - indice - 1] == str[indice];
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //9) Escriba una función recursiva que reciba un número y un arreglo de números y retorne
        //la cantidad de veces que dicho número aparece en el arreglo.

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="numeros"></param>
        /// <returns></returns>
        public static bool elNro_EstaEnElArreglo_(int numero, ArrayList numeros)
        {
            if (numeros.Count == 0)
                return false;

            else if((int)numeros[numeros.Count - 1] == numero)
                return true;

            numeros.RemoveAt(numeros.Count - 1);

            return elNro_EstaEnElArreglo_(numero, numeros);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numero"></param>
        /// <param name="numeros"></param>
        /// <returns></returns>
        public static int cantidadDeVecesQueAparece_EnElArreglo_(int numero, ArrayList numeros)
        {
            if (numeros.Count == 0)
                return 0;

            int ultimoElemento = (int)numeros[numeros.Count-1];

            int totalParcial = unoSi_CeroSino(elNro_EstaEnElArreglo_(numero, numeros));

            numeros.Remove(ultimoElemento);

            return cantidadDeVecesQueAparece_EnElArreglo_(numero, numeros) + totalParcial;
        }

        // 🔸 Funciones auxiliares

        /// <summary>
        /// Describe uno si se cumple la condición dada; describe cero en caso de no cumplirse.
        /// </summary>
        /// <param name="condicion">Condición según la cual se describe 0 o 1. Tipo: Booleano</param>
        /// <returns>Número - Tipo: int (0 o 1)</returns>
        private static int unoSi_CeroSino(bool condicion)
        {
            if (condicion)
                return 1;

            return 0;
        }

        // Función utilizada en el ejercicio 3.

        /// <summary>
        /// Indica si la letra dada es una vocal.
        /// </summary>
        /// <param name="letra">La letra según la cual se decribe verdadero o falso - Tipo: string</param>
        /// <returns>Booleano</returns>
        private static bool esVocal(string letra)
        {
            letra.ToLower();

            return letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u";
        }

    }
}
