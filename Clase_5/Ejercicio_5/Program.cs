using System;

namespace Ejercicio_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CONSIGNA:

            //Implemente la clase Pila de expedientes(usando la interfaz vista en la teoría). Luego resuelva el siguiente
            //problema: En una oficina un abogado debe clasificar una pila de expedientes.Cada expediente cuenta con
            //un número, titular, trámite y fecha de presentación. Se desea:
            //a) Generar otra pila con los expedientes correspondientes al mes de febrero.
            //b) Verificar si la señora Gabriela Turco tuvo una audiencia en el mes de marzo. Si es así, imprimir todos los
            //trámites realizados por ella en el mes de febrero.


            PilaDeExpedientes expedientes = new PilaDeExpedientes();

            // Carga expedientes en la pila...

            // a) 

            // Llamada al método estático ApilarExpedientesDelMes_(PilaDeExpedientes expedientes, int mes) 
            // Mes 2 ➡ Febrero.

            PilaDeExpedientes pilaDelMesDeFebrero = ApilarExpedientesDelMes_(expedientes, 2);

            // Mostrar los datos de los expedientes filtrados por mes de Febrero.

            pilaDelMesDeFebrero.MostrarDatosDeLosExpedientesEnLaPila();

            // ▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪▪

            // b) 

            while (!expedientes.estaVacia())
            {
                Expediente expediente = expedientes.DesapilarExpediente();

                if (expediente.Titular == "Gabriela Turco" && expediente.FechaDePresentacion.Month == 3)
                {
                    Console.WriteLine(expediente.ToString());
                }
            }


        }

        // 🔹 Funciones auxiliares 

        /// <summary>
        /// Apila expedientes correspondiente al mes número **mes**, de un pila de expedientes dada.
        /// </summary>
        /// <param name="expedientes">Pila de expedientes ➡ Tipo: PilaDeExpedientes</param>
        /// <param name="mes">Número del mes ➡ Tipo: int</param>
        /// <returns>PilaDeExpedientes</returns>
        public static PilaDeExpedientes ApilarExpedientesDelMes_(PilaDeExpedientes expedientes, int mes) 
        {
            PilaDeExpedientes pilaNueva = new PilaDeExpedientes();

            Expediente expediente;

            while (!expedientes.estaVacia())
            {
                expediente = expedientes.DesapilarExpediente();

                if (expediente.FechaDePresentacion.Month == mes)
                {
                    pilaNueva.ApilarExpediente(expediente);
                }
            }

            return pilaNueva;
        }
    }
}
