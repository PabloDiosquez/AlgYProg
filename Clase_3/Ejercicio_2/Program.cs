using System;
using System.Collections;
using System.Text;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un programa de aplicación que simule la inscripción de participantes de distintas escuelas a una
            //competencia de matemática.De cada alumno se conoce su Dni y el nombre de la escuela a la que representa.
            //Pueden inscribirse(en forma desordenada) varios alumnos de la misma escuela. Arme un menú que permita:
            //a.Inscribir un alumno(armar una lista de alumnos inscriptos)
            //b.Borrar un alumno(eliminarlo de la lista de alumnos inscriptos)
            //c.Indicar total de alumnos inscriptos
            //d.Indicar total de escuelas que al menos tienen un alumno inscripto(armar una lista de escuelas)
            //e.Imprimir el listado de las escuelas, ordenado alfabéticamente, sin repeticiones.

            ArrayList alumnos = new ArrayList();

            CompetenciaDeMatematica(alumnos); // Mejorar el nombre.

            // Recorrer la lista para ver si funciona InscribirAlumno.

        }

        public static void ImprimirMenu() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("◾◾◾ Menú de opciones ◾◾◾");
            sb.AppendLine("a. Inscribir un alumno. (A)");
            sb.AppendLine("b. Borrar un alumno.    (B)");
            sb.AppendLine("c. Indicar total de alumnos inscriptos. (C)");
            sb.AppendLine("d. Indicar total de escuelas que al menos tienen un alumno inscripto. (D)");
            sb.AppendLine("e. Imprimir el listado de las escuelas, ordenado alfabéticamente, sin repeticiones (E)");
            sb.AppendLine("f. Salir (S)");

            Console.WriteLine(sb.ToString());
        }

        public static void CompetenciaDeMatematica(ArrayList alumnos)
        {
            string opcionElegida;

            do
            {
                ImprimirMenu();

                opcionElegida = Console.ReadLine().ToUpper();

                switch (opcionElegida)
                {
                    case "A":
                        Console.WriteLine("Inscribir alumno:");
                        InscribirAlumno(ref alumnos);
                        break;
                    case "B":
                        Console.WriteLine("Borrar alumno");
                        break;
                    case "C":
                        Console.WriteLine("Indicar total alumnos inscriptos");
                        break;
                    case "D":
                        Console.WriteLine("Indicar escuelas ...");
                        break;
                    case "E":
                        Console.WriteLine("Imprimir listado de escuelas ...");
                        break;
                    case "S":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gracias por usar la App");
                        break;
                    default:
                        Console.WriteLine("Opción NO válida. Intente de nuevo.");
                        break;
                }

            } while (opcionElegida != "S");
        }

        public static void InscribirAlumno(ref ArrayList alumnos)
        {
            ArrayList alumno = new ArrayList();

            Console.WriteLine("Dni:");
            alumno.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine("Nombre y Apellido:");
            alumno.Add(Console.ReadLine());

            Console.WriteLine("Escuela:");
            alumno.Add(Console.ReadLine());
            
            alumnos.Add(alumno);    

        }

        
    }
}
