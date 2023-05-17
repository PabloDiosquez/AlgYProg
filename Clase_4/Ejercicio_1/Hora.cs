using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /// <summary>
    /// Modela una hora del día.
    /// Invariante de representación:
    /// El valor del atributo <<hora>> debe estar comprendido entre 0 y 23.
    /// El valor del atributo <<minutos>> debe estar comprendido entre 0 y 60.
    /// El valor del atributo <<segundos>> debe estar comprendido entre 0 y 60.
    /// </summary>
    public class Hora
    {
        // Atributos

        private int segundos;

        private int minutos;

        private int horas;

        // Constructor
        public Hora(int horas, int minutos, int segundos)
        {
            this.segundos = segundos;

            this.minutos = minutos;

            this.horas = horas;
        }

        /// <summary>
        /// Describe los valores de horas, minutos y segundos de una hora del día. 
        /// Tipo: string.
        /// </summary>
        public void imprimirHora()
        {
            Console.WriteLine($"{horas} horas, {minutos} minutos y {segundos} segundos.");
        }
    }
}
