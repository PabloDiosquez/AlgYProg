using System;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defina una función que reciba una palabra y retorne en un vector la cantidad de cada una de las vocales que
            //contiene.

            Console.WriteLine("Palabra: ");

            foreach (string st in ContarVocalesDeLaPalabra(Console.ReadLine()))
            {
                Console.WriteLine(st);
            }

        }

        public static string[] ContarVocalesDeLaPalabra(string palabra)
        {
            int cantidadLetraA=0, cantidadLetraE=0, cantidadLetraI=0, cantidadLetraO=0, cantidadLetraU=0;

            string[] vocales = new string[5];

            foreach (char caracter in palabra.ToLower())
            {
                switch (caracter)
                {
                    case 'a':
                        cantidadLetraA++;
                        break;
                    case 'e':
                        cantidadLetraE++;
                        break;
                    case 'i':
                        cantidadLetraI++;
                        break;
                    case 'o':
                        cantidadLetraO++;
                        break;
                    case 'u':
                        cantidadLetraU++;
                        break;   
                }
            }

            vocales[0] = $"a: {cantidadLetraA}";
            vocales[1] = $"e: {cantidadLetraE}";
            vocales[2] = $"i: {cantidadLetraI}";
            vocales[3] = $"o: {cantidadLetraO}";
            vocales[4] = $"u: {cantidadLetraU}";

            return vocales;
        }
    }
}
