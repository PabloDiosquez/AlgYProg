using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consola_Ejercicio_1;
using Ejercicio_2;
using System.Collections;

namespace Ejercicio_3
{
    public class Materia
    {
        private string nombre;

        private Profesor profesor;

        private ArrayList alumnos;

        // Constructor

        public Materia(string nombre, Profesor profesor)
        {
            this.nombre = nombre;

            this.profesor = profesor;

            alumnos = new ArrayList();
        }

        // Propiedades

        public string Nombre
        {
            get { return nombre; }
        }

        public string Profesor 
        {
            get { return profesor.verDatos(); }
        }

        // Métodos

        public void agregarAlumno(int legajo, string nombre, string apellido)
        {
            alumnos.Add(new Alumno(legajo, nombre, apellido));
        }
        public void verAlumnos() 
        {
            foreach (Alumno alumno in alumnos)
            {
                Console.WriteLine(((Alumno)alumno).ToString());
            }
        }
    }
}
