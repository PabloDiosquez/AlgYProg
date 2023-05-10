using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /// <summary>
    /// Define una obra de teatro, que es un espectáculo que tiene un título descriptivo y un precio. 
    /// </summary>
    public class ObraDeTeatro : Espectaculo
    {
        // Atributos

        private string titulo;

        private double precio;

        private Butaca[] butacas;

        private int numeroDeButacasLibres;

        // Constructor

        public ObraDeTeatro(Espectaculo espectaculo, string titulo, double precio) : base(espectaculo.Sala, espectaculo.Capacidad)
        {
            this.titulo = titulo;

            this.precio = precio;

            butacas = new Butaca[espectaculo.Capacidad];

            VaciarButacas();

            numeroDeButacasLibres = espectaculo.Capacidad;
        }

        /// <summary>
        /// Vacía todas las butacas de la obra para comenzar la venta de entradas.
        /// </summary>
        private void VaciarButacas()
        {
            foreach (Butaca butaca in butacas)
            {
                butaca.EstaLibre = true;
            }
        }

        // Getters y Setters

        /// <summary>
        /// Describe el título de la obra de teatro.
        /// </summary>
        public string Titulo
        {
            get { return titulo; }
        }

        /// <summary>
        /// Describe el precio de la obra de teatro. Además, permite asignar dicho precio.
        /// </summary>
        public double Precio
        {
            get { return precio; }

            set { precio = value; }
        }

        //el método venderEntrada(Espectador unEsp) que le asigna una butaca libre al
        //espectador y modifica la información correspondiente a la obra de teatro(cantidad de butacas libres y
        //la ocupación de la butaca). 

        /// <summary>
        /// Indica si al espectador dado se le puede vender una entrada; si es así, asigna una butaca libre al espectador
        /// **espectador** y modifica la información correspondiente a la obra de teatro (cantidad de bustacas libres y la ocupación de una butaca).
        /// </summary>
        /// <param name="espectador">Es el espectador al cual se le vende una entrada ➡ Espectador</param>
        public bool venderEntrada(Espectador espectador)
        {
            foreach (Butaca butaca in butacas)
            {
                if (butaca.EstaLibre)
                {
                    espectador.Butaca = butaca;

                    numeroDeButacasLibres--;

                    return true;
                }
            }

            return false;
        }

    }
}
