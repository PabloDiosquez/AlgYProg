using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Persona
    {
        private string nombre;

        private int dni;

        private int edad;

        private DateTime fechaDeNacimiento;

        public Persona(string datos)
        {
            string[] vectorDeDatos = datos.Split(" ");

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
        public string MostrarDatos()
        {
            return $"{nombre} ({edad}) {dni}";
        }

        public bool esMayorQue(Persona persona)
        {
            return edad > persona.edad;
        }

    }
}
