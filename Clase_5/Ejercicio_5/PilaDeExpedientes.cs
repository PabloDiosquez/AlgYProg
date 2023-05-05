﻿using System;
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

        public void ApilarExpediente(int numero, string titular, string tramite, DateTime fechaDePresentacion) 
        {
            Expediente nuevoExpediente = new Expediente(numero, titular, tramite, fechaDePresentacion);

            expedientes.Add(nuevoExpediente);   
        }
    }
}
