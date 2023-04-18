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
                        InscribirAlumno(ref alumnos);
                        break;
                    case "B":
                        ArrayList alumno = new ArrayList();
                        BorrarAlumno(alumno, ref alumnos);
                        break;
                    case "C":
                        Console.WriteLine($"Total alumnos inscriptos: {alumnos.Count}");
                        break;
                    case "D":
                        Console.WriteLine($"Total de escuelas con al menos un alumno inscripto: {ContarEscuelasInscriptas(alumnos)}");
                        break;
                    case "E":
                        ImprimirListadoDeEscuelas(alumnos);
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

        public static bool BorrarAlumno(ArrayList alumnoABorrar, ref ArrayList alumnos) 
        {
            foreach (ArrayList alumno in alumnos)
            {
                if (alumno[0] == alumnoABorrar[0])
                {
                    alumnos.Remove(alumno);

                    return true;
                }
            }

            return false;
        }

        public static int ContarEscuelasInscriptas(ArrayList alumnos)
        {
            ArrayList escuelas = new ArrayList();

            string escuela;

            foreach (ArrayList alumno in alumnos)
            {
                escuela = (string)alumno[2];

                if (!estaEn(escuela, escuelas))
                {
                    escuelas.Add(escuela);
                }

            }
            
            return escuelas.Count;    
        }

        public static void ImprimirListadoDeEscuelas(ArrayList alumnos)
        {
            string escuela;

            ArrayList escuelas = new ArrayList();   

            foreach (ArrayList alumno in alumnos)
            {
                escuela = (string)alumno[2];

                if (!estaEn(escuela, escuelas)) 
                {
                    escuelas.Add(escuela);
                }
            }

            escuelas.Sort();

            foreach (string escuelaInscripta in escuelas)
            {
                Console.WriteLine($"Escuela: {escuelaInscripta}");
            }
        }

        public static bool estaEn(string palabraABuscar, ArrayList palabras)
        {
            foreach (string palabra in palabras)
            {
                if (palabra == palabraABuscar)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
