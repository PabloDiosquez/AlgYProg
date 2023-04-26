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
