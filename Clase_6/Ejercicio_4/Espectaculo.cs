using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    /// <summary>
    /// Define un espectáculo, el cual se realiza en una sala con una capacidad determinada de butacas.
    /// </summary>
    public class Espectaculo
    {
        // Atributos

        private string sala;

        private int capacidad;

        // Constructor
        public Espectaculo(string sala, int capacidad)
        {
            this.sala = sala;

            this.capacidad = capacidad;
        }

        // Getters - Sólo lectura

        /// <summary>
        /// Describe el nombre de la sala donde el espectáculo tiene lugar.
        /// </summary>
        public string Sala
        {
            get { return sala; }
        }

        /// <summary>
        /// Describe la cantidad de butacas que definen la capacidad de la sala.
        /// </summary>
        public int Capacidad
        {
            get { return capacidad; }
        }

    }

}
