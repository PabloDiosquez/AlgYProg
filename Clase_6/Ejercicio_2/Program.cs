using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cree una jerarquía de clases como la que se indica en el esquema y defina en todas ellas el
            //método polimórfico ToString() que escribe en la consola la jerarquía desde la claseA hasta aquella
            //a la que pertenece el objeto en forma invertida.

            //Clase A
            //| Clase B
            //| Clase C
            //| Clase D

            //Por ejemplo, si obj es una instancia de la clase D,
            //obj.ToString() deberá imprimir: Clase D Clase C Clase B Clase A

            ClaseB obj = new ClaseD();

            Console.WriteLine(obj.ToString());

        }
    }
}
