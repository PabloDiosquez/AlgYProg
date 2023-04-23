using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Persona
    {
        private int dni;

        private string nombre;

        private int edad;

        public Persona(int dni, string nombre, int edad) 
        {
            this.dni = dni; 

            this.nombre = nombre;   

            this.edad = edad;   
        }

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
