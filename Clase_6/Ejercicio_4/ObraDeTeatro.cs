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

        // Constructor

        public ObraDeTeatro(Espectaculo espectaculo, string titulo, double precio): base(espectaculo.Sala, espectaculo.Capacidad)
        {
            this.titulo = titulo;

            this.precio = precio;   
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
    }
}
