using System;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implemente un programa de aplicación que simule el funcionamiento de una calculadora que permita al usuario
            //realizar las cuatro operaciones elementales e imprimir el resultado de la operación. Para ello el programa debe
            //mostrar un menú de opciones con cada una de las operaciones, luego de seleccionar la operación el programa
            //pide ingresar dos números, realiza la operación solicitada e imprime el resultado.Cada operación se resuelve con
            //una función.
            //El usuario debe poder realizar tantas operaciones como desee hasta seleccionar una opción de salida.


            UsarCalculadora();
        }

        public static void UsarCalculadora()
        {
            while (true) 
            {
                Console.WriteLine(" ### Calculadora 1.0 ###");

                Console.WriteLine("Menú de opciones:");

                Console.WriteLine("1 - Suma");

                Console.WriteLine("2 - Resta");

                Console.WriteLine("3 - Multiplicación");

                Console.WriteLine("4 - División");

                Console.WriteLine("Salir - 0");

                string opcion = Console.ReadLine();

                if (opcion == "0")
                {
                    Console.WriteLine("¡Gracias por usar la App!\n");
                    break;
                }
                else
                {
                    Console.WriteLine($"\nUsted ha elegido la opción {opcion}");
                }

                double numero1 = PedirNumero();

                double numero2 = PedirNumero();

                // Asignar valores

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"Suma: {Sumar(numero1, numero2)}");
                        break;
                    case "2":
                        Console.WriteLine($"Resta: {Restar(numero1, numero2)}");
                        break;
                    case "3":
                        Console.WriteLine($"Multiplicación: {Multiplicar(numero1, numero2)}");
                        break;
                    case "4":
                        Console.WriteLine($"División: {Dividir(numero1, numero2)}");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();
            }
        }

        public static double PedirNumero()
        {
            double numero;

            Console.WriteLine("Número: ");

            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingresar un número. Intente de nuevo.");
            }

            return numero;
        }

        public static double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public static double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public static double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public static double Dividir(double numero1, double numero2)
        {
            if (numero2 != 0) 
            {
                return numero1 / numero2;
            }

            return double.MaxValue;
        }
    }
}
