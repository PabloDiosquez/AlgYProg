using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    public class Profesor
    {
        private int id;

        private string nombre;

        private string apellido;

        private ArrayList listaDeMateriasQueDicta;

        public Profesor(int id, string nombre, string apellido)
        {
            this.id = id;

            this.nombre = nombre;   

            this.apellido = apellido;   

            listaDeMateriasQueDicta = new ArrayList();
        }

        public void DictadoDeCurso(string materia) 
        {
            listaDeMateriasQueDicta.Add(materia);
        }

        public string verDatos()
        {
            return $"Id: {id} - Nombre: {nombre} - Apellido: {apellido}";
        }

    }
}
