using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hora h1 = new Hora(23,15,30);

            Hora h2 = new Hora("23:15:30");

            h1.imprimir();

            h2.imprimir();
        }
    }
}
