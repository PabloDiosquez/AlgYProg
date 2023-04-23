using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Operacion
    {
        private double operando1;

        private double operando2;

        private string operador;

        public Operacion(double operando1, double operando2, string operador)
        {
            this.operando1 = operando1;

            this.operando2 = operando2; 

            this.operador = operador;
        }

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
