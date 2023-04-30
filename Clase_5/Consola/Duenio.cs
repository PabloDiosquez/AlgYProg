using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Duenio
    {
        // Atributos

        private string nombre;

        private string apellido;

        private Mascota mascota;

        // Constructores 

        public Duenio(string nombre, string apellido)
        {
            this.nombre = nombre;

            this.apellido = apellido;   
        }

        public Duenio(string nombre, string apellido, Mascota mascota) : this(nombre, apellido) 
        {
            if (mascota is not null) 
            {
                this.mascota = mascota;
            }
        }

        // Propiedades 

        public string Nombre 
        {
            get { return nombre; }

            set { nombre = value; }
        }
    }
}
