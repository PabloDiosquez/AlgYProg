using System;

namespace Clase_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            Console.WriteLine(Busqueda.BusquedaBinaria(numeros, 23));
        }
    }
}
