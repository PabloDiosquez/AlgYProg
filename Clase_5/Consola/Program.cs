using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Duenio duenio1 = new Duenio("Juan", "Díaz");

            //duenio1.Mascota = new Mascota("Coco", "Juan", 2, "Mamífero");

            Veterinaria veterinaria = new Veterinaria("Huesitos");

            string sigue;

            Console.WriteLine("¿Desea cargar una mascota? (S/N)");

            sigue = Console.ReadLine();

            while (sigue.ToUpper() == "S")
            {
                Console.WriteLine("Nombre:");

                string nombre  = Console.ReadLine();

                Console.WriteLine("Nombre del dueño:");

                string duenio = Console.ReadLine();

                Console.WriteLine("Especie:");

                string especie = Console.ReadLine();

                Console.WriteLine("Edad:");

                int edad = int.Parse(Console.ReadLine());

                Mascota mascota = new Mascota(nombre, duenio, edad, especie);
                
                veterinaria.agregarMascota(mascota);

                Console.WriteLine("\n¿Quiere agregar otra mascota? (S/N)");

                sigue = Console.ReadLine();
            }

            // ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪ //

            int cantidadDeMascotasAtendidas = 0;

            Console.WriteLine("¿Hay alguna mascota para atender? (S/N)");

            sigue = Console.ReadLine();

            while (sigue.ToUpper() == "S")
            {

                Console.WriteLine("Nombre:");

                string nombre = Console.ReadLine();

                Console.WriteLine("Nombre del dueño:");

                string duenio = Console.ReadLine();

                Console.WriteLine("Diagnóstico:");

                string diagnostico = Console.ReadLine();

                veterinaria.atenderMascota(nombre, duenio, diagnostico);

                cantidadDeMascotasAtendidas++;

                Console.WriteLine("\n¿Quiere seguir atendiendo?");

                sigue = Console.ReadLine();
            }

            Console.WriteLine($"Total de mascotas atendidas: {cantidadDeMascotasAtendidas}");

        }

        public static void VerListadoDeMascotasEn_DeMasDe_Anios(Veterinaria veterinaria, int valor)
        {
            foreach (Mascota mascota in veterinaria.ListaDeMascotas)
            {
                if (mascota.Edad > valor)
                {
                    Console.WriteLine(mascota.verDatosMascota());
                }
            }
        }
    }
}
