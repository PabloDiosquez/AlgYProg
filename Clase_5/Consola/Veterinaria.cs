using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Veterinaria
    {
        // Atributos

        string nombre;

        private Mascota[] listaDeMascotas;

        private int cantidadDeMascotas;

        // Constructor

        public Veterinaria(string nombre)
        {
            this.nombre = nombre;   

            listaDeMascotas = new Mascota[10];

            cantidadDeMascotas = 0;
        }
    }
}
