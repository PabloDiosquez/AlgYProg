using System;

namespace Clase_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiPrimerClase objeto1 = new MiPrimerClase();

            objeto1.Imprimir();

            // ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ //

            // Clase Auto

            Auto auto1;

            Auto auto2;

            auto1 = new Auto("Fiat", 2000);

            auto2 = new Auto("Peugeot", 2010);

            Console.WriteLine(auto1.ImprimirDatos()); 

            Console.WriteLine(auto2.ImprimirDatos());

            // ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ //

            auto1.Acelerar();

            auto1.Acelerar(12);

            auto1.Acelerar(1.3);

            Console.WriteLine($"Velocidad actual: {auto1.GetVelocidad()} km/h");
        }

        public class MiPrimerClase
        {
            public void Imprimir()
            {
                Console.WriteLine("¡Perfecto, funcionó!");
            }
        }
    }
}
