// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {

        //ejemploDeMetodoStatic();
        ejemploTiposPrimitivosVsObjetos();

    }

    public static void ejemploDeMetodoStatic(){
        Persona persona1 = new Persona();
        Persona persona2 = new Persona();
        Persona persona3 = new Persona();

        System.out.println(persona1.toString());
        System.out.println(persona2.toString());
        System.out.println(persona3.toString());
        System.out.println(String.format("ID: %s", Persona.getId()));
    }

    public static void ejemploTiposPrimitivosVsObjetos(){
        System.out.println("Objetos:");
        Persona persona1 = new Persona();
        Persona persona2 = new Persona();
        System.out.println(String.format("Antes: %s", persona2.toString()));

        persona2 = persona1;
        System.out.println(String.format("Después: %s", persona2.toString()));

        // --------------------------------------
        System.out.println("\nTipos primitivos:");
        int numero1 = 10;
        int numero2 = 20;
        System.out.println(String.format("Valor número 2 (antes): %s", numero2));

        numero2 = numero1;
        System.out.println(String.format("Valor actual número 2 (después): %s", numero2));

    }
}