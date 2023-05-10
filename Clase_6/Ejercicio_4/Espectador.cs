using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /// <summary>
    /// Un espectador tiene un nombre, un apellido, un dni y se le asigna una butaca en el espectáculo.
    /// </summary>
    public class Espectador
    {
        // Atributos 

        private string nombre;

        private string apellido;

        private int dni;

        private Butaca butaca;

        // Constructor

        public Espectador(string nombre, string apellido, int dni, Butaca butaca)
        {
            this.nombre = nombre;

            this.apellido = apellido;

            this.dni = dni;

            this.butaca = butaca;
        }

        // Getters y Setters

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }

            set { apellido = value; }
        }

        public int Dni
        {
            get { return dni; }

            set { dni = value; }
        }

        public Butaca Butaca
        {
            get { return butaca; }

            set { butaca = value; }
        }
    }
}
