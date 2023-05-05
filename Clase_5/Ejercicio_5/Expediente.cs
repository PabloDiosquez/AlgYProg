using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    public class Expediente
    {
        // Atributos

        private int numero;

        private string titular;

        private string tramite;

        private DateTime fechaDePresentacion;

        // Constructor

        public Expediente(int numero, string titular, string tramite, DateTime fechaDePresentacion)
        {
            this.numero = numero;

            this.titular = titular;

            this.tramite = tramite;

            this.fechaDePresentacion = fechaDePresentacion;
        }

        // Getters
        public int Numero
        {
            get { return numero; }
        }

        public string Titular 
        {
            get { return titular; }
        }

        public string Tramite 
        {
            get { return tramite; }
        }

        public string FechaDePresentacion
        {
            get { return $"{fechaDePresentacion.Day}/{fechaDePresentacion.Month}/{fechaDePresentacion.Year}"; }
        }
    }
}
