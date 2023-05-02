using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Ejercicio_1
{
    public class HorarioDeCursada
    {
        private string dia;

        private int hora;

        private string materia;

        public HorarioDeCursada(string dia, int hora, string materia)
        {
            this.dia = dia;

            this.hora = hora;   

            this.materia = materia; 
        }

        public string Dia 
        {
            get { return dia; }

            set { dia = value; }
        }

        public int Hora 
        {
            get { return hora; }

            set { hora = value; }
        }

        public string Materia 
        {
            get { return materia; }

            set { materia = value; }
        }

        public override string ToString()
        {
            return $"Materia: {materia} - Día: {dia} - Hora: {hora}";
        }
    }
}
