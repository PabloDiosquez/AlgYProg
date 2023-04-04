using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que calcule la suma de dos números reales introducidos por teclado y muestre el
            //resultado en la consola..

            double numero1 = 0, numero2 = 0;

            Console.WriteLine("Ingrese un número:");

            AsignarValorNumerico(ref numero1);

            Console.WriteLine("Ingrese otro número:");

            AsignarValorNumerico(ref numero2);

            Console.WriteLine($"Suma: {numero1+numero2}");

        }

        public static void AsignarValorNumerico(ref double numero)
        {
            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingresar un número...\nIntente de nuevo:");
            }
        }
        
    }
}
