using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que imprima en la consola todos los números pares que además sean múltiplos
            //de 5 y estén comprendidos entre 250 y 900.

            ImprimirNumerosParesYMultiplosDe5Desde_Hasta_(250, 900);
        }

        public static void ImprimirNumerosParesYMultiplosDe5Desde_Hasta_(int desde, int hasta)
        {
            if (desde % 2 != 0)
            {
                desde++;
            }

            for (int i = desde; i <= hasta; i += 2)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
