using System;
using System.Collections;

namespace Clase_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo 1: Pila de ejecución 👉🏼 Reservas de memoria consecutivas donde se almacena el estado de la función en cada

            // una de sus ejecuciones.

            // sumatoria(5) ➡ sumatoria(4) + 5 ➡ (sumatoria (3) + 4) + 5 ➡ (sumatoria(2) + 3) + 4 + 5 

            // ➡ (sumatoria(1) + 2) + 3 + 4 + 5 ➡ 1 + 2 + 3 + 4 + 5 = 15

            int suma = sumatoria(5);

            // Console.WriteLine(suma);

            // Ejemplo 2: Imprimir elementos de un arreglo.

            char[] caracteres = { 'a', 'e', 'i', 'o', 'U' };

            // imprimirArreglo_(caracteres);

            // Ejemplo 3: Cargar un vector de números.

            int[] numeros = new int[3];

            //cargarArreglo_(numeros);

            ArrayList sec = secuenciaFibonacci(10);

            foreach (var item in sec)
            {
                Console.WriteLine(item);
            }

        }

        // Ejemplo 1: Definir una función recursiva que reciba un número natural y devuelva la suma desde 1 hasta dicho número.

        // sumatoria(n) ➡  1 + 2 + 3 + ... + (n-1) + n ➡ sumatoria (n) = sumatoria (n-1) + n (Caso recursivo)

        // sumatoria (1) ➡ 1 (Caso base)

        public static int sumatoria(int numero)
        {
            if (numero == 1)
            {
                return 1;
            }

            return sumatoria(numero - 1) + numero;

        }

        // Ejemplo 2: Implementar una algoritmo recursivo que permita imprimir un arreglo de n caracteres.

        public static void imprimirArreglo_(char[] caracteres)
        {
            imprimirArreglo_Desde_Hasta_(caracteres, 0, caracteres.Length);
        }

        /// <summary>
        /// Imprime los elementos de un arreglo de caracteres desde el índice **desde** hasta el índice **hasta**.
        /// Precondiciones:
        /// ◾ **hasta** debe ser <= longitud del arreglo.
        /// ◾ **desde** <= **hasta**.
        /// </summary>
        /// <param name="caracteres">Arreglo de caracteres</param>
        /// <param name="desde">Número</param>
        /// <param name="hasta">Número</param>
        private static void imprimirArreglo_Desde_Hasta_(char[] caracteres, int desde, int hasta)
        {
            if (desde < hasta)
            {
                Console.WriteLine(caracteres[desde]);

                imprimirArreglo_Desde_Hasta_(caracteres, desde + 1, hasta);
            }
        }

        // Ejemplo 3: Implementar una función recursiva que permita cargar un arreglo de 10 elementos.

        public static void cargarArreglo_(int[] numeros)
        {
            cargarArreglo_Desde_Hasta_(numeros, 0, numeros.Length);
        }

        /// <summary>
        /// Carga números enteros en un arreglo de tamaño n, desde el índice **desde** hasta el índice **hasta**.
        /// Precondiciones:
        /// ◾ **hasta** debe ser <= longitud del arreglo.
        /// ◾ **desde** <= **hasta**.
        /// </summary>
        /// <param name="numeros">Arreglo de números</param>
        /// <param name="desde">Número</param>
        /// <param name="hasta">Número</param>
        private static void cargarArreglo_Desde_Hasta_(int[] numeros, int desde, int hasta)
        {
            if (desde < hasta) 
            {
                Console.WriteLine("Número:");

                numeros[desde] = int.Parse(Console.ReadLine());

                cargarArreglo_Desde_Hasta_(numeros, desde+1, hasta);
            }
        }


        // 🔸 EJERCICIOS.

        //1️) Implemente una función recursiva que calcule el factorial de un número n, el cual es
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
        public static string fibonacci(int numero)
        {
            if (numero == 1)
                return "1";

            return fibonacci(numero - 1) + $", {nEsimoNumeroDeFibonacci(numero)}";
        }

        /// <summary>
        /// Devuelve el nésimo número de la secuencia de Fibonacci. Esto es, devuelve el número que se encuentra en la posición 
        /// dada como parámetro.
        /// Precondición: El número dado como parámetro debe ser un entero >= 0
        /// </summary>
        /// <param name="n">Posición según la cual se describe el número de la secuencia de Fibonacci correspondiente</param>
        /// <returns>Número - Tipo: int</returns>
        private static int nEsimoNumeroDeFibonacci(int n) 
        {
            if (n <= 2)
                return 1;
            
            return nEsimoNumeroDeFibonacci(n - 1) + nEsimoNumeroDeFibonacci(n - 2);
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //3) Modifique la función anterior para, que en vez de imprimir por consola, devuelva la serie
        //en un ArrayList.

        public static ArrayList secuenciaFibonacci(int n) 
        {
            ArrayList secuencia = new ArrayList() { 1, 1};

            return secuenciaFibonacciHasta_(secuencia, n);
        }

        private static ArrayList secuenciaFibonacciHasta_(ArrayList secuencia, int n)
        {
            if (n <= 2)
            {
                return secuencia;
            }

            secuencia.Add(nEsimoNumeroDeFibonacci(n));

            return secuenciaFibonacciHasta_(secuencia, n-1);
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        //4) Escriba una función recursiva que reciba un arreglo de números y devuelva el porcentaje de elementos pares.

        /// <summary>
        /// Describe el porcentaje de números pares en el arreglo dado.
        /// </summary>
        /// <param name="numeros">Arreglo de números enteros</param>
        /// <returns>Número - Tipo: double</returns>
        public static double porcentajeDeParesDelArreglo(int[] numeros) 
        {
            return (cantidadDeParesDelArreglo_(numeros) / numeros.Length) * 100;
        }

        /// <summary>
        /// Describe la cantidad de números pares en el arreglo dado.
        /// </summary>
        /// <param name="numeros">Arreglo de números enteros</param>
        /// <returns>Número - Tipo: int</returns>
        private static int cantidadDeParesDelArreglo_(int[] numeros)
        {
            return cantidadDeParesDelArreglo_Desde_(numeros, 0);
        }

        /// <summary>
        /// Describe la cantidad de números pares en el arreglo dado desde la posición **desde** + 1.
        /// Precondición: **desde** debe ser < **numeros**.Length.
        /// </summary>
        /// <param name="numeros">Areglo de números</param>
        /// <param name="desde">Número</param>
        /// <returns>Número - Tipo: int</returns>
        private static int cantidadDeParesDelArreglo_Desde_(int[] numeros, int desde)
        {
            if (desde == numeros.Length - 1)
            {
                return unoSi_CeroSino(esPar_(numeros[desde]));
            }

            return cantidadDeParesDelArreglo_Desde_(numeros, desde + 1) + unoSi_CeroSino(esPar_(numeros[desde]));

        }

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

        // 8) Escriba una función recursiva que reciba un ArrayList de apellidos y retorne si existe o no
        // un apellido dado en la lista.

        /// <summary>
        /// Indica si el apellido dado está en la lista dada.
        /// </summary>
        /// <param name="apellido">Apellido - Tipo: string</param>
        /// <param name="apellidos">Arreglo de apellidos - Tipo: string[]</param>
        /// <returns>Booleano</returns>
        public static bool apellido_EstaEnLaLista_(string apellido, string[] apellidos)
        {
            return palabra_EstaEnElArreglo_Desde_(apellido, apellidos, 0);
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
            ArrayList copia = (ArrayList)numeros.Clone();

            if (copia.Count == 0)
                return 0;

            int ultimoElemento = (int)copia[numeros.Count-1];

            int totalParcial = unoSi_CeroSino(copia.Contains(numero));

            copia.Remove(ultimoElemento);

            return cantidadDeVecesQueAparece_EnElArreglo_(numero, copia) + totalParcial;
        }

        // ◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽◽ //

        // 🔸 FUNCIONES AUXILIARES 🥨

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

        // Función utilizada en el ejercicio 4.

        /// <summary>
        /// Indica si el número dado es par o no.
        /// </summary>
        /// <param name="numero">Número</param>
        /// <returns>Booleano</returns>
        private static bool esPar_(int numero)
        {
            return numero % 2 == 0;
        }

        // Función utilizada en el ejercicio 8.

        /// <summary>
        /// Indica si la palabra **palabra** pertenece al arreglo dado desde la posición **desde** + 1.
        /// Precondición: 
        /// ◾ **desde** debe ser >= 0.
        /// </summary>
        /// <param name="palabra">Palabra</param>
        /// <param name="palabras">Arreglo de palabras</param>
        /// <param name="desde">Número</param>
        /// <returns>Booleano</returns>
        private static bool palabra_EstaEnElArreglo_Desde_(string palabra, string[] palabras, int desde) 
        {
            if (desde < palabras.Length)
            {
                return palabra == palabras[desde] || palabra_EstaEnElArreglo_Desde_(palabra, palabras, desde+1);
            }

            return false;
        }

    }
}
