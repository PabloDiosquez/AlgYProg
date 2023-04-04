using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que lea por teclado una secuencia de números y que imprima el valor máximo, el
            //valor mínimo de dicho conjunto y el valor promedio.

            int numero, maximo = 0, minimo = 0;

            int contador = 0, sumador = 0;

            double promedio = 0;

            bool flagMaximo = true, flagMinimo = true;  

            do
            {
                Console.WriteLine("Número: ");

                numero = int.Parse(Console.ReadLine());

                // Cálculo del máximo ✌

                if (flagMaximo)
                {
                    maximo = numero;

                    flagMaximo = false;
                }
                else 
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                }

                // Cálculo del mínimo 👌🏼

                if (flagMinimo)
                {
                    minimo = numero;

                    flagMinimo = false;
                }
                else 
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                }

                contador++;

                sumador += numero;

                Console.WriteLine("¿Desea seguir cargando números? (S/N)");      

            } while (Console.ReadLine().ToUpper() == "S");

            Console.WriteLine($"Máximo: {maximo}");

            Console.WriteLine($"Mínimo: {minimo}");

            promedio = sumador / contador;

            Console.WriteLine($"Promedio: {promedio.ToString("0.00")}");

        }

    }
}
