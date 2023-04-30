using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duenio duenio1 = new Duenio("Juan", "Díaz");

            duenio1.Mascota = new Mascota("Coco", "Juan", 2, "Mamífero");
        }
    }
}
