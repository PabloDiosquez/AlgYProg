using System;
using System.Collections;

namespace Clase_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList alumnos = new ArrayList();

            alumnos.Add(new Alumno(123,4.89));
            alumnos.Add(new Alumno(122,7.23));
            alumnos.Add(new Alumno(121,5.04));
            alumnos.Add(new Alumno(127,1.92));
            alumnos.Add(new Alumno(131,9.78));

            Alumno.OrdenarAlumnosPorPromedio(alumnos);

            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(alumno.ToString());
            }
        }
    }
}
