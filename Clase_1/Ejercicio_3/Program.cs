using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriba un programa de aplicación que solicite al usuario que ingrese un número de mes(1 a 12) e imprima el nombre
            //del mes correspondiente.Si el valor ingresado no está en ese rango debe imprimir “Mes inválido ” . Utilice la
            //sentencia switch.

            Console.WriteLine(mesImpreso());
        }

        /// <summary>
        /// Describe un mes del año.
        /// </summary>
        /// <returns>String</returns>
        private static string mesImpreso()
        {
            return $"Mes elegido: {mes(validarMes())}";
        }

        /// <summary>
        /// Describe un número entre 1 y 12 inclusive, que representa un mes del año.
        /// </summary>
        /// <returns>Número entre 1 y 12 inclusive</returns>
        private static int validarMes()
        {
            int nroMes;

            Console.WriteLine("Ingrese un número de mes:");

            while (!int.TryParse(Console.ReadLine(), out nroMes))
            {
                Console.WriteLine("Asegúrese de ingresar un número entero entre 1 y 12 inlusive.");

            }

            return nroMes;
        } 

        /// <summary>
        /// Describe el mes del año que corresponde al número entero dado.
        /// Precondición:
        /// * El número dado debe estar entre 1 y 12 inclusive.
        /// </summary>
        /// <param name="numeroDeMes">Mes del año</param>
        /// <returns>String</returns>
        private static string mes(int numeroDeMes)
        {
            string mes;

            switch (numeroDeMes)
            {
                case 1:
                    mes = "Enero";
                    break;

                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;

                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;

                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;

                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;

                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;

                default:
                    mes = "Diciembre";
                    break;
            }

            return mes;
        }
    }
}
