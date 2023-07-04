using System;
using System.Collections;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que lea por teclado una secuencia de números y que imprima el valor máximo, el
            //valor mínimo de dicho conjunto y el valor promedio.

            maximoMinimoYPromedio();
        }

        private static void maximoMinimoYPromedio()
        {
            ArrayList numeros = cargarNumeros();

            leerNumeros(numeros);

            Console.WriteLine($"Máximo: {maximo(numeros)}");

            Console.WriteLine($"Mínimo: {minimo(numeros)}");

            Console.WriteLine($"Promedio: {sumatoria(numeros) / numeros.Count}");
        }

        /// <summary>
        /// Describe un array dinámico de números enteros leídos por consola.
        /// </summary>
        /// <returns>ArrayList de núemros enteros.</returns>
        public static ArrayList cargarNumeros()
        {
            ArrayList numeros = new ArrayList(); 
            do
            {
                numeros.Add(validarNumero());

                Console.WriteLine("¿Desea continuar? (S/N)");

            } while (Console.ReadLine().ToUpper() == "S");

            return numeros;
        }

        /// <summary>
        /// Muestra por consola los números enteros que pertenecen al array de números dado.
        /// </summary>
        /// <param name="numeros">ArrayList de números enteros.</param>
        private static void leerNumeros(ArrayList numeros)
        {
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }

        /// <summary>
        /// Describe el número más grande del array de números dado
        /// Precondiciones:
        /// * El arrayList dado no debe ser vacío.
        /// </summary>
        /// <param name="numeros">ArrayList de números enteros.</param>
        /// <returns>Número entero</returns>
        private static int maximo(ArrayList numeros)
        {
            int maximoAlMomento = (int)numeros[0];

            foreach (int numero in numeros)
            {
                maximoAlMomento = maximoEntre(maximoAlMomento, numero);
            }
            return maximoAlMomento;
        }

        /// <summary>
        /// Describe el número más chico del array de números dado.
        /// Precondiciones:
        /// * El arrayList dado no debe ser vacío.
        /// </summary>
        /// <param name="numeros">ArrayList de números enteros.</param>
        /// <returns>Número entero</returns>
        private static int minimo(ArrayList numeros)
        {
            int minimoAlMomento = (int)numeros[0];

            foreach (int numero in numeros)
            {
                minimoAlMomento = minimoEntre(minimoAlMomento, numero);
            }
            return minimoAlMomento;
        }

        /// <summary>
        /// Describe la suma de los números pertenecientes al array dado.
        /// </summary>
        /// <param name="numeros">ArrayList de números</param>
        /// <returns>Número entero</returns>
        private static int sumatoria(ArrayList numeros)
        {
            int sumaAlMomento = 0;

            foreach (int numero in numeros)
            {
                sumaAlMomento += numero;
            }
            return sumaAlMomento;
        }

        /// <summary>
        /// Describe un número entero leído por consola.
        /// </summary>
        /// <returns>Número</returns>
        private static int validarNumero()
        {
            int numero;

            Console.WriteLine("Ingrese un número:");

            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingresar un número. Intente de nuevo.");
            }

            return numero;
        }

        /// <summary>
        /// Describe el número más grande entre los dos números dados.
        /// </summary>
        /// <param name="numero1">Número entero</param>
        /// <param name="numero2">Número entero</param>
        /// <returns>Número entero</returns>
        private static int maximoEntre(int numero1, int numero2)
        {
            if (numero1 >= numero2)
            {
                return numero1;
            }
            return numero2;
        }

        /// <summary>
        /// Describe el número más chico entre los dos números dados.
        /// </summary>
        /// <param name="numero1">Número entero</param>
        /// <param name="numero2">Número entero</param>
        /// <returns>Número entero</returns>
        private static int minimoEntre(int numero1, int numero2)
        {
            if (numero1 <= numero2)
            {
                return numero1;
            }
            return numero2;
        }

        // Función general ⛷ 

        public static void maximoMinimoPromedio()
        {
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
