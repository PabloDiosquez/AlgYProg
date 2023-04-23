using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Hora
    {
        private int segundos;

        private int minutos;

        private int horas;

        public Hora(int horas, int minutos, int segundos)
        {
            this.segundos = segundos;

            this.minutos = minutos;

            this.horas = horas;
        }

        public void imprimir()
        {
            Console.WriteLine($"{horas} horas, {minutos} minutos y {segundos} segundos.");
        }
    }
}
