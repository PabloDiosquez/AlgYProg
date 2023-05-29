using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    /// <summary>
    /// Modela una alumno de la universidad. Un alumno tiene un legajo, un nombre y un apellido y también cuenta con una lista
    /// de horarios de cursada.
    /// * Inv. de Rep.:
    /// **nombre** no debe ser vacío.
    /// **apellido** no debe ser vacío.
    /// </summary>
    public class Alumno
    {
        // Atributos

        private int legajo;

        private string nombre;

        private string apellido;

        private ArrayList horariosDeCursadas;

        // Constructor
        public Alumno(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;

            this.nombre = nombre;

            this.apellido = apellido;

            horariosDeCursadas = new ArrayList();
        }

        // Propiedades (sólo lectura)

        /// <summary>
        /// Describe el legajo del alumno.
        /// Tipo: int 
        /// </summary>
        public int Legajo
        {
            get { return legajo; }
        }

        /// <summary>
        /// Describe el nombre del alumno.
        /// Tipo: string
        /// </summary>
        public string Nombre 
        {
            get { return nombre; }
        }

        /// <summary>
        /// Describe el apellido del alumno.
        /// Tipo: string
        /// </summary>
        public string Apellido 
        {
            get { return apellido; }
        }

        /// <summary>
        /// Inscribe al alumno a la cursada de la materia dada, en el día y horarios dados. En caso de que el horario esté ocupado,
        /// no inscribe al alumno a la cursada.
        /// </summary>
        /// <param name="dia">Día de cursada - Tipo: string</param>
        /// <param name="hora">Hora de cursada - Tipo: int</param>
        /// <param name="materia">Materia a cursar - Tipo: string</param>
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

        /// <summary>
        /// Describe el listado de materias en las cuales el alumno está inscripto.
        /// </summary>
        /// <returns>String</returns>
        public string VerListadoDeMaterias()
        {
            ArrayList materias = new ArrayList();

            foreach (HorarioDeCursada horarios in horariosDeCursadas)
            {
                if (!materias.Contains(horarios.Materia))
                {
                    materias.Add(horarios.Materia);
                }
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("▪ Materias ▪");

            foreach (string materia in materias)
            {
                sb.AppendLine((string)materia);
            }

            return sb.ToString();

        }

        public void VerHorariosDeCursada()
        {
            foreach (HorarioDeCursada horario in horariosDeCursadas)
            {
                Console.WriteLine(horario.ToString());
            }
        }

        public override string ToString()
        {
            return $"Legajo: {legajo} - Nombre: {nombre} - Apellido: {apellido}";
        }

    }
}
