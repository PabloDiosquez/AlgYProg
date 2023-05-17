using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    /// <summary>
    /// Modela una persona.
    /// Una persona tiene un DNI, un nombre y una edad.
    /// </summary>
    public class Persona
    {
        // Atributos 

        private int dni;

        private string nombre;

        private int edad;

        // Constructor
        public Persona(int dni, string nombre, int edad) 
        {
            this.dni = dni; 

            this.nombre = nombre;   

            this.edad = edad;   
        }

        // Getters y Setters
        public int Dni
        {
            get { return dni; }

            set { dni = value; }
        }

        public string Nombre 
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public int Edad 
        {
            get { return edad; }

            set { edad = value; }
        }
    }
}
