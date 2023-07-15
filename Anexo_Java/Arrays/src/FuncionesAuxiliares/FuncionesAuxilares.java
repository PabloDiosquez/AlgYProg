package FuncionesAuxiliares;

import java.util.Arrays;
import java.util.Scanner;

public class FuncionesAuxilares {
    public static int pedirNumero(){
        System.out.println("Número:");
        return new Scanner(System.in).nextInt();
    }

    public static String imprimirNumero(int numero){
        return String.format("%s", numero);
    }
    public static void cargarNumeros(int[] numeros){
        for (int i = 0; i < numeros.length; i++){
            numeros[i] = pedirNumero();
        }
    }
    public static void imprimirNumeros(int[] numeros){
        /*for (int i = 0; i < numeros.length; i++) {
            System.out.println(imprimirNumero(numeros[i]));
        }*/

        Arrays.stream(numeros).forEach(numero -> imprimirNumero(numero));
    }

    public static int minimo(int[] numeros){
        // Describe el menor número del arreglo.
        // Pre: El arreglo dado no debe ser vacío.

        int minimoAlMomento = numeros[0];
        for (int i = 0; i < numeros.length; i++){
            minimoAlMomento = minimoEntre(numeros[i], minimoAlMomento);
        }
        return minimoAlMomento;
    }

    public static int minimoEntre(int numero1, int numero2){
        // Describe el menor de los dos números enteros dados.
        if(numero1 < numero2){
            return numero1;
        }
        return numero2;
    }
}
