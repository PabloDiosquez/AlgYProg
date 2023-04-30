using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola_Ejercicio_1
{
    public class Alumno
    {
        private int legajo;

        private string nombre;

        private string apellido;

        private ArrayList horariosDeCursadas;

        public Alumno(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;

            this.nombre = nombre;

            this.apellido = apellido;

            horariosDeCursadas = new ArrayList();
        }

        // Propiedades (sólo lectura)
        public int Legajo
        {
            get { return legajo; }
        }

        public string Nombre 
        {
            get { return nombre; }
        }

        public string Apellido 
        {
            get { return apellido; }
        }

        public void InscribirseACursada(HorarioDeCursada cursada) 
        {
            horariosDeCursadas.Add(cursada);

        }

    }
}
