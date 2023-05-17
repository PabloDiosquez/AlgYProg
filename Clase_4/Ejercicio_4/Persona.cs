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

            edad = calcularEdad(vectorDeDatos[2]);
        }

        /// <summary>
        /// Describe la edad de una persona.
        /// </summary>
        /// <param name="datosEdad">String</param>
        /// <returns>int</returns>
        private int calcularEdad(string datosEdad)
        {
            int edad;

            if (!datosEdad.Contains("/"))
            {
                edad = int.Parse(datosEdad);
            }
            else 
            {
                string[] fechaDeNacimiento = datosEdad.Split("/");

                int dia, mes, anio;

                dia = int.Parse(fechaDeNacimiento[0]);

                mes = int.Parse(fechaDeNacimiento[1]);

                anio = int.Parse(fechaDeNacimiento[2]);

                DateTime fechaDeNacimiento_ = new DateTime(anio, mes, dia);

                edad = DateTime.Now.Year - fechaDeNacimiento_.Year;
            }


            return edad;
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
