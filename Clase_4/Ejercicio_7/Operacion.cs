using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    /// <summary>
    /// Modela una operación matemática binaria, la cual consta de dos operandos y un operador.
    /// </summary>
    public class Operacion
    {
        // Atributos

        private double operando1;

        private double operando2;

        private string operador;

        // Constructor
        public Operacion(double operando1, double operando2, string operador)
        {
            this.operando1 = operando1;

            this.operando2 = operando2; 

            this.operador = operador;
        }

        /// <summary>
        /// Describe el resultado de efectuar la operación solicitada en la instancia actual (this).
        /// </summary>
        /// <returns>String</returns>
        public string evaluar()
        {
            string res;

            switch (operador)
            {
                case "+":
                    res = $"{operando1} {operador} {operando2} = {operando1 + operando2}";
                    break;
                case "-":
                    res = $"{operando1} {operador} {operando2} = {operando1 - operando2}";
                    break;
                case "*":
                    res = $"{operando1} {operador} {operando2} = {operando1 * operando2}";
                    break;
                case "/":
                    res = $"{operando1} {operador} {operando2} = {operando1 / operando2}";
                    break;
                case "%":
                    res = $"{operando1} {operador} {operando2} = {operando1 % operando2}";
                    break;
                default:
                    res = "La operación solicitada no es válida";
                    break;
            }

            return res;
        }
    }
}
