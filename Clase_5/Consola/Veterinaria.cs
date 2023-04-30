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

        // Propiedades 

        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        // Métodos

        public void agregarMascota(Mascota mascota)
        {
            listaDeMascotas[cantidadDeMascotas] = mascota;

            cantidadDeMascotas++;
        }

        public void atenderMascota(string nombre, string nombreDelDuenio, string nuevoDiagnostico)
        {
            foreach (Mascota mascota in listaDeMascotas)
            {
                if (mascota.Nombre == nombre && mascota.NombreDelDueño == nombreDelDuenio)
                {
                    mascota.Diagnostico = nuevoDiagnostico;

                    break;
                }
            } 

        }

        public string verDatosDeMascota(int indice)
        {
            return listaDeMascotas[indice].verDatosMascota();
        }

        public bool estaEnLaLista(Mascota mascota, Mascota[] listaDeMascotas)
        {
            foreach (Mascota mascota_ in listaDeMascotas)
            {
                if (mascota_.Nombre == mascota.Nombre && mascota_.NombreDelDueño == mascota.NombreDelDueño) 
                {
                    return true;
                }
            }

            return false;
        }

        public string eliminarMascota(Mascota mascota)
        {
            if (estaEnLaLista(mascota, listaDeMascotas))
            {
                int indice = Array.IndexOf(listaDeMascotas, mascota);

                Mascota mascotaEliminada = listaDeMascotas[indice];

                listaDeMascotas[indice] = null;

                cantidadDeMascotas--;

                return mascotaEliminada.verDatosMascota();
            }

            return "La mascota a eliminar no estaba en la lista";
        }

        public int totalDeMascotas()
        {
            return cantidadDeMascotas;
        }
    }
}
