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

        public void InscribirseACursada(string dia, int hora, string materia) 
        {
            bool ocupado = false;

            foreach (HorarioDeCursada horario in horariosDeCursadas)
            {
                if (horario.Dia == dia && horario.Hora == hora) 
                {
                    ocupado = true;

                    break;
                }
            }

            if (!ocupado)
            {
                HorarioDeCursada nuevoHorario = new HorarioDeCursada(dia, hora, materia);

                horariosDeCursadas.Add(nuevoHorario);
            }
            else
            {
                Console.WriteLine($"Horario ocupado: Día: {dia} - Hora: {hora}");
            }


        }

        public void VerListadoDeMaterias()
        {
            ArrayList materias = new ArrayList();

            foreach (HorarioDeCursada horarios in horariosDeCursadas)
            {
                if (!materias.Contains(horarios.Materia))
                {
                    materias.Add(horarios.Materia);
                }
            }

            Console.WriteLine("▪ Materias ▪\n");

            foreach (String materia in materias)
            {
                Console.WriteLine(materia);
            }

        }


        public void VerHorariosDeCursada()
        {
            foreach (HorarioDeCursada horario in horariosDeCursadas)
            {
                Console.WriteLine(horario.ToString());
            }
        }

    }
}
