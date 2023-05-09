using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    /// <summary>
    /// Representa un expediente. Cada expediente cuenta con un número, un titular, un trámite y una fecha de presentación.
    /// </summary>
    public class Expediente
    {
        // Atributos

        private int numero;

        private string titular;

        private string tramite;

        private DateTime fechaDePresentacion;

        // Constructor
        /// <summary>
        /// Toda instancia de la Clase Expediente requiere de un número de expediente, el nombre del titular, del tipo de trámite y de una fecha de presentación.
        /// </summary>
        /// <param name="numero">Número de expediente</param>
        /// <param name="titular">Nombre del titular</param>
        /// <param name="tramite">Tipo de trámite</param>
        /// <param name="fechaDePresentacion">Fecha de presentación del expediente.</param>

        public Expediente(int numero, string titular, string tramite, DateTime fechaDePresentacion)
        {
            this.numero = numero;

            this.titular = titular;

            this.tramite = tramite;

            this.fechaDePresentacion = fechaDePresentacion;
        }

        // Getters ➡ Sólo lectura.

        /// <summary>
        /// Describe el número de expediente.
        /// Tipo: int
        /// </summary>
        public int Numero
        {
            get { return numero; }
        }

        /// <summary>
        /// Describe el nombre del titular del expediente.
        /// Tipo: string
        /// </summary>
        public string Titular 
        {
            get { return titular; }
        }

        /// <summary>
        /// Describe el tipo de trámite del expediente.
        /// Tipo: string
        /// </summary>
        public string Tramite 
        {
            get { return tramite; }
        }

        /// <summary>
        /// Describe la fecha de presentación del expediente.
        /// Tipo: DateTime.
        /// </summary>
        public DateTime FechaDePresentacion
        {
            get { return fechaDePresentacion; }
        }

        /// <summary>
        /// Describe los datos del expediente.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"Número: {numero} - Titular: {titular} - Trámite: {tramite} - Fecha de presentación: {fechaDePresentacion.ToString()}";
        }
    }
}
