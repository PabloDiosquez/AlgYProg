import java.awt.*;

public class Persona {
    // Atributos

    private String nombre; // Atributo privado 👉🏼 Sólo se puede acceder dentro de la clase.
    private Integer edad;
    private Integer dni;

    // Constructor
    public Persona(String nombre,Integer dni){
        this.nombre = nombre;
        this.dni = dni;
    }
    public Persona(){} // Constructor vacío.

    // GETTERS Y SETTERS
    public String getNombre(){
        return nombre;
    }
    public void setNombre(String nombre){
        this.nombre = nombre;
    }
    public Integer getEdad(){
        return edad;
    }
    public void setEdad(Integer edad){
        if (edad > 0){
            this.edad = edad;
        }else{
            System.out.println("La edad de una persona debe ser > a 0");
            this.edad = 0;
        }
    }
    public Integer getDni(){
        return dni;
    }
    public void setDni(Integer dni){
        this.dni = dni;
    }

    // Sobrecarga de métodos
    public void Presentarse(){
        System.out.println(String.format("Hola! Soy %s y tengo %s años.", nombre, edad));
    }
    public void Presentarse(String nombre){
        System.out.println(String.format("Hola %s! Soy %s y tengo %s años.", nombre, this.nombre, edad));
    }

    @Override
    public String toString() {
        return String.format("Nombre: %s -- Edad: %s -- DNI: %s", nombre, edad, dni);
    }
}
