using System;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operacion op = new Operacion(5,4,"+");

            string resultado = op.evaluar();

            Console.WriteLine(resultado);
        }
    }
}
