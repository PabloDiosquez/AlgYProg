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

        // Métodos

        public void agregarMascota()
        {

        }

        public void atenderMascota(Mascota mascota)
        {

        }

        public string verDatosDeMascota(int indice)
        {
            return string.Empty;
        }

        public string eliminarMascota(Mascota mascota)
        {
            return string.Empty;
        }

        public int totalDeMascotas()
        {
            return 0;
        }
    }
}
