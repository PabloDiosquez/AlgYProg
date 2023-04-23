using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Hora
    {
        private int segundos;

        private int minutos;

        private int horas;

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

        public void imprimir()
        {
            Console.WriteLine($"{horas} horas, {minutos} minutos y {segundos} segundos.");
        }
    }
}
