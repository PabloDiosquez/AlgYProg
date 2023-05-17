using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_4_5_6
{
    /// <summary>
    /// Modela una persona. Una persona tiene un nombre, un DNI, una edad y una fecha de nacimiento.
    /// </summary>
    public class Persona
    {
        // Atributos 

        private string nombre;

        private int dni;

        private int edad;

        private DateTime fechaDeNacimiento;

        // Constructores
        public Persona(string datos)
        {
            string[] vectorDeDatos = datos.Split("\t");

            nombre = vectorDeDatos[0];

            dni = int.Parse(vectorDeDatos[1]);

            edad = int.Parse(vectorDeDatos[2]);
        }

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;   

            this.fechaDeNacimiento = fechaDeNacimiento;

            this.dni = dni;

            edad = DateTime.Now.Year - fechaDeNacimiento.Year;
        }

        /// <summary>
        /// Describe los datos de una persona.
        /// </summary>
        /// <returns>String</returns>
        public string MostrarDatos()
        {
            return $"{nombre} ({edad}) {dni}";
        }

        /// <summary>
        /// Indica si la persona que recibe el mensaje (this) es más grande que la persona recibida como parámetro.
        /// </summary>
        /// <param name="persona">Es la persona cuya edad se quiere comparar con la persona que recibe el mensaje ➡ Persona</param>
        /// <returns>Booleano</returns>
        public bool esMayorQue(Persona persona)
        {
            return edad > persona.edad;
        }

    }
}
