using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Mascota
    {
        // Atributos

        private string nombre;

        private string nombreDelDueño;

        private string especie;

        private string diagnostico;

        private int edad;

        // Constructores
        public Mascota() { }

        public Mascota(string nombre, string nombreDelDueño, int edad, string especie)
        {
            this.nombre = nombre;

            this.nombreDelDueño = nombreDelDueño;

            this.edad = edad;

            this.especie = especie;

            diagnostico = string.Empty;
        }

        // Propiedades 

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public string NombreDelDueño
        {
            get { return nombreDelDueño; }

            set { nombreDelDueño = value; }
        }

        public int Edad
        {
            get { return edad; }

            set { edad = value; }
        }

        public string Especie 
        {
            get { return especie; }

            set { especie = value; }
        }

        public string Diagnostico 
        {
            get { return diagnostico; }

            set { diagnostico = value; }
        }

        // Métodos

        public string verDatosMascota()
        {
            return $"Nombre: {nombre} - Dueño: {nombreDelDueño} - Edad: {edad} - Especie: {especie} - Diagnóstico: {diagnostico}";
        }

    }
}
