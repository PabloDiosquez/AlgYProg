// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {
        Persona persona = new Persona("Luis", 12345678);
        //persona.Presentarse();
        //persona.Presentarse("Paco");

        //persona.setEdad(21);
        //System.out.println(persona);

        // Ejercicio 1
        //a.
        Rectangulo rectangulo = new Rectangulo();

        rectangulo.setAlto(2);
        rectangulo.setAncho(2);

        //b.
        System.out.println(String.format("Alto: %s", rectangulo.getAlto()));
        System.out.println(String.format("Ancho: %s", rectangulo.getAncho()));

        //c. (Área y perímetro)
        System.out.println(String.format("Área: %s", rectangulo.area()));
        System.out.println(String.format("Perímetro: %s", rectangulo.perimetro()));

        //d.
        rectangulo.setAlto(12);
        rectangulo.setAncho(10);

        //e.
        System.out.println(String.format("Área: %s", rectangulo.area()));
        System.out.println(String.format("Perímetro: %s", rectangulo.perimetro()));

        //f.
        Rectangulo rectangulo1 = new Rectangulo();

        System.out.println("Rectángulo con valores por defecto.");
        //System.out.println(rectangulo1.area());
        //System.out.println(rectangulo1.perimetro());
        System.out.println(rectangulo1.toString());

        //Ejercicio 2
        Empleado empleado1 = new Empleado("Carlos", "Gutiérrez", "23456781");
        empleado1.setSalario(25000);
        System.out.println(empleado1.toString());

        Empleado empleado2 = new Empleado("Ana", "Sánchez", "34561287");
        empleado2.setSalario(27500);
        System.out.println(empleado2.toString());

        empleado1.aumentarSalarioEn(15);
        System.out.println(empleado1.toString());

        // Ejercicio 3
        System.out.println("-----------------------------");
        System.out.println("Item de venta --  Ejercicio 3");
        ItemDeVenta item = new ItemDeVenta(1);
        //item.setDescripcion();
        item.setCantidad(10);
        item.setPrecioUnitario(12.5);
        System.out.println(item.toString());

        // Ejercicio 4
        System.out.println("-----------------------------");
        System.out.println("Cuenta bancaria --  Ejercicio 4");
        CuentaBancaria cuenta = new CuentaBancaria(1, "Lio Messi", 15000);
        cuenta.credito(2500);
        cuenta.debito(1500);
        cuenta.debito(30000);
        System.out.println(cuenta.toString());
    }
}