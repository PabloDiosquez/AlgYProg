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

            Console.WriteLine("Ingrese un número de mes:");

            Console.WriteLine(DevolverMes(Console.ReadLine()));
        }

        public static string DevolverMes(string numeroDeMes)
        {
            string mes;

            switch (numeroDeMes)
            {
                case "1":
                    mes = "Enero";
                    break;

                case "2":
                    mes = "Febrero";
                    break;
                case "3":
                    mes = "Marzo";
                    break;

                case "4":
                    mes = "Abril";
                    break;
                case "5":
                    mes = "Mayo";
                    break;

                case "6":
                    mes = "Junio";
                    break;
                case "7":
                    mes = "Julio";
                    break;

                case "8":
                    mes = "Agosto";
                    break;
                case "9":
                    mes = "Septiembre";
                    break;

                case "10":
                    mes = "Octubre";
                    break;
                case "11":
                    mes = "Noviembre";
                    break;

                case "12":
                    mes = "Diciembre";
                    break;

                default:
                    return "Mes inválido";
            }

            return mes;
        }
    }
}
