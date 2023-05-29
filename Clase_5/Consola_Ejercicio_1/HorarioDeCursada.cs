using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /// <summary>
    /// Modela un horario de cursada de la universidad. Un horario de cursada tiene un día, una hora y en ese horario se 
    /// dicta una materia.
    /// * Inv. de Rep.:
    /// **dia** no debe ser vacío.
    /// **hora** debe ser un número entre 0 y 24 inclusive.
    /// **materia** no debe ser vacío.
    /// </summary>
    public class HorarioDeCursada
    {
        // Atributos 

        private string dia;

        private int hora;

        private string materia;

        // Constructor 
        public HorarioDeCursada(string dia, int hora, string materia)
        {
            this.dia = dia;

            this.hora = hora;   

            this.materia = materia; 
        }

        /// <summary>
        /// Describe y asigna el día del horario de cursada.
        /// </summary>
        public string Dia 
        {
            get { return dia; }

            set { dia = value; }
        }

        /// <summary>
        /// Describe y asigna la hora del horario de cursada.
        /// </summary>
        public int Hora 
        {
            get { return hora; }

            set { hora = value; }
        }

        /// <summary>
        /// Describe y asigna la materia dictada en el horario de cursada correspondiente.
        /// </summary>
        public string Materia 
        {
            get { return materia; }

            set { materia = value; }
        }

        /// <summary>
        /// Describe los datos del horario de cursada correspondiente. 
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return $"Materia: {materia} - Día: {dia} - Hora: {hora}";
        }
    }
}
