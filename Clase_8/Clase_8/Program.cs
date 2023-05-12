using System;
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

        public static int fibo(int numero) 
        {
            if (numero <= 2)
                return 1;
            
            return fibo(numero - 1) + fibo(numero - 2);
        }


        public static string fibonacciV1(int numero)
        {
            if (numero == 1)
                return "1";

            return fibonacciV1(numero - 1) + $", {fibo(numero)}";
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //3) Modifique la función anterior para, que en vez de imprimir por consola, devuelva la serie
        //en un ArrayList.


        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //5) Escriba una función recursiva que reciba un string y retorne la cantidad de vocales que
        //contiene.

        public static int unoSiEsVocalCeroSino(string letra)
        {
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                return 1;
            }

            return 0;
        }

        public static int cantidadDeVocales(string palabra)
        {
            if (palabra == string.Empty)
                return 0;

            string ultimaLetra = palabra.Substring(palabra.Length - 1);

            return cantidadDeVocales(palabra.Remove(palabra.Length - 1)) + unoSiEsVocalCeroSino(ultimaLetra);
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //7) Escriba una función recursiva que reciba un string como parámetro y devuelva si es o
        //no palíndromo.

        public static bool esPalindromoDesde_(string str, int indice)
        {
            if (indice > str.Length/2)
                return true;

            return esPalindromoDesde_(str, indice + 1) && str[str.Length - indice - 1] == str[indice];
        }

        public static bool esPalindromo(string str)
        {
            return esPalindromoDesde_(str,0);
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //9) Escriba una función recursiva que reciba un número y un arreglo de números y retorne
        //la cantidad de veces que dicho número aparece en el arreglo.

        /// <summary>
        /// Describe uno si se cumple la condición dada; describe cero en caso de no cumplirse.
        /// </summary>
        /// <param name="condicion">Booleano</param>
        /// <returns></returns>
        public static int unoSi_CeroSino(bool condicion)
        {
            if (condicion)
                return 1;

            return 0;
        }

        public static bool elNro_EstaEnElArreglo(int numero, ArrayList numeros)
        {
            if (numeros.Count == 0)
                return false;

            else if((int)numeros[numeros.Count - 1] == numero)
                return true;

            numeros.RemoveAt(numeros.Count - 1);

            return elNro_EstaEnElArreglo(numero, numeros);
        }

        public static int cantidadDeVecesQueAparece_EnElArreglo_(int numero, ArrayList numeros)
        {
            if (numeros.Count == 0)
                return 0;

            int ultimoElemento = (int)numeros[numeros.Count-1];

            int totalParcial = unoSi_CeroSino(elNro_EstaEnElArreglo(numero, numeros));

            numeros.Remove(ultimoElemento);

            return cantidadDeVecesQueAparece_EnElArreglo_(numero, numeros) + totalParcial;
        }
    }
}
