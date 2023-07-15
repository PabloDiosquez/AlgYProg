import java.util.Arrays;
import java.util.Scanner;
import FuncionesAuxiliares.FuncionesAuxilares;

public class Main {
    public static void main(String[] args) {
        // Arreglo de números enteros
        int[] numeros = new int[6];
        FuncionesAuxilares.cargarNumeros(numeros);
        FuncionesAuxilares.imprimirNumeros(numeros);
        System.out.println(FuncionesAuxilares.minimo(numeros));
    }
}