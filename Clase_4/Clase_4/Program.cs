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

            auto1 = new Auto();

            auto2 = new Auto();

            auto1.SetMarca("Fiat");

            auto2.SetMarca("Peugeot");

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
