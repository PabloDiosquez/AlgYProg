using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_9
{
    public class Alumno: IComparable
    {
        private int legajo;

        private double promedio;

        public Alumno(int legajo, double promedio)
        {
            this.legajo = legajo;   

            this.promedio = promedio;
        }

        public int Legajo
        {
            get { return legajo; }  
        }

        public double Promedio
        {
            get { return promedio; }
        }

        public int CompareTo(object otroAlumno)
        {
            if (promedio > ((Alumno)otroAlumno).promedio)
            {
                return 1;
            }
            else if (promedio < ((Alumno)otroAlumno).promedio)
            {
                return -1;
            }

            return 0;
        }

        //Definir nuestra función de ordenación para que ordene objetos del tipo IComparable.
    }
}
