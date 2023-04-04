using System;

namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implemente una función que reciba una matriz(arreglo de dos dimensiones) pasada como parámetro, e imprima
            //por consola la suma de sus elementos.

            //static double sumaMatriz(double[,] matriz)


            double[,] matriz = new double[3,4];

            matriz[0, 0] = 1;
            matriz[0, 1] = 1;
            matriz[0, 2] = 1;
            matriz[0, 3] = 1;
            matriz[1, 0] = 1;
            matriz[1, 1] = 1;
            matriz[1, 2] = 1;
            matriz[1, 3] = 1;
            matriz[2, 0] = 1;
            matriz[2, 1] = 1;
            matriz[2, 2] = 1;
            matriz[2, 3] = 1;


            Console.WriteLine(SumarElementosDeLaMatriz(matriz));

        }

        public static double SumarElementosDeLaMatriz(double[,] matrizDeNumeros)
        {
            double suma = 0;

            int cantidadFilas = matrizDeNumeros.GetLength(0);

            for (int i = 0; i < matrizDeNumeros.GetLength(0); i++)
            {
                for (int j = 0; j < matrizDeNumeros.GetLength(1); j++)
                {
                    suma += matrizDeNumeros[i,j];  
                }
            }

            return suma;
        }  
    }
}
