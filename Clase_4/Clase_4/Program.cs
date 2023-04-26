using System;

namespace Clase_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiPrimerClase objeto1 = new MiPrimerClase();

            objeto1.Imprimir();
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
