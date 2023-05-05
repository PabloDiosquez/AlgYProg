using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio_5
{
    public class PilaDeExpedientes
    {
        private ArrayList expedientes;

        public PilaDeExpedientes()
        {
            expedientes = new ArrayList();
        }

        // Métodos

        public void ApilarExpediente(Expediente expediente)
        {
            expedientes.Add(expediente);
        }

        public Expediente DesapilarExpediente()
        {
            int ultimaPosicion = expedientes.Count - 1;

            Expediente expediente = (Expediente)expedientes[ultimaPosicion];

            expedientes.Remove(expediente);

            return expediente;
        }

        public bool estaVacia()
        {
            return expedientes.Count == 0;
        }

        public Expediente VerTope()
        {
            return (Expediente)expedientes[0];
        }
    }
}
