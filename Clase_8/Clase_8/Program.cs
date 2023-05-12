using System;
using System.Collections;

namespace Clase_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacciV1(8));
        }

        // 🔸 Ejercicios.

        //1) Implemente una función recursiva que calcule el factorial de un número n, el cual es
        //pasado por parámetro.

        public static int factorial(int numero)
        {
            if (numero == 0)
                return 1;

            return factorial(numero - 1)*numero;
        }

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

        //3) Modifique la función anterior para, que en vez de imprimir por consola, devuelva la serie
        //en un ArrayList.

        public static ArrayList fibonacciV2(int numero) 
        {
            ArrayList fibo = new ArrayList();



            return fibo;
        }





    }
}
