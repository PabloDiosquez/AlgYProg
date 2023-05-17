using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    /// <summary>
    /// Modela una hora del día. 
    /// Invariante de representación:
    /// El valor del atributo <<hora>> debe estar comprendido entre 0 y 23.
    /// El valor del atributo <<minutos>> debe estar comprendido entre 0 y 60.
    /// El valor del atributo <<segundos>> debe estar comprendido entre 0 y 60
    /// </summary>
    public class Hora
    {
        // Atributos

        private int segundos;

        private int minutos;

        private int horas;

        // Constructores
        public Hora(int horas, int minutos, int segundos)
        {
            this.horas = horas;

            this.minutos = minutos;

            this.segundos = segundos;
        }

        public Hora(string hora)
        {
            string[] vHora = hora.Split(":");

            this.horas = int.Parse(vHora[0]);

            this.minutos = int.Parse(vHora[1]);

            this.segundos = int.Parse(vHora[2]);
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
