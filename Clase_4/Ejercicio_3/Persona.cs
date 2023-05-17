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

        // Propiedades

        /// <summary>
        /// Describe y asigna el DNI de una persona.
        /// Tipo: int
        /// </summary>
        public int Dni
        {
            get { return dni; }

            set { dni = value; }
        }

        /// <summary>
        /// Describe y asigna el nombre de una persona.
        /// Tipo: string
        /// </summary>
        public string Nombre 
        {
            get { return nombre; }

            set { nombre = value; }
        }

        /// <summary>
        /// Describe y asigna la edad de una persona.
        /// Tipo: int
        /// </summary>
        public int Edad 
        {
            get { return edad; }

            set { edad = value; }
        }
    }
}
