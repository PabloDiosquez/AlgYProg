using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que calcule la suma de dos números reales introducidos por teclado y muestre el
            //resultado en la consola..

            Console.WriteLine(sumaDeDos());

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static double sumaDeDos()
        {
            return asignarValorNumerico() + asignarValorNumerico();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static double asignarValorNumerico()
        {
            double numero;

            Console.WriteLine("Ingrese un número:");

            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingresar un número...\nIntente de nuevo:");
            }

            return numero;
        }
        
    }
}
