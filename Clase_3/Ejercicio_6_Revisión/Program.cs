using System;

namespace Ejercicio_6_Revisión
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;

            int[] cantidadVocales = new int[5] { 0, 0, 0, 0, 0 };

            char[] vocales = new char[5] { 'a','e','i','o','u'};

            Console.WriteLine("Ingrese una palabra:");

            palabra = Console.ReadLine();

            contarVocales(palabra, ref cantidadVocales);

            for (int i = 0; i < cantidadVocales.Length; i++)
            {
                Console.WriteLine($"Cantidad de letras {vocales[i]}: {cantidadVocales[i]}");
            }

            Console.ReadKey();
        }

        public static void contarVocales(string palabra, ref int[] cantidadVocales)
        {
            foreach (char letra in palabra)
            {
                switch (letra)
                {
                    case 'a':
                        cantidadVocales[0]++;
                        break;
                    case 'e':
                        cantidadVocales[1]++;
                        break;
                    case'i':
                        cantidadVocales[2]++;
                        break;
                    case 'o':
                        cantidadVocales[3]++;
                        break;
                    case 'u':
                        cantidadVocales[4]++;
                        break;
                }
            }
        }
    }
}
