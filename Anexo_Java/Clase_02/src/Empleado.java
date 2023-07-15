public class Empleado {
    // Atributos
    private String nombre;
    private String apellido;
    private String dni;
    private double salario;

    // Constructor
    public Empleado(String nombre, String apellido, String dni){
        this.nombre = nombre;
        this.apellido = apellido;
        this.dni = dni;
    }

    // Getters y Setters
    public String getNombre(){
        return nombre;
    }

    public void setNombre(String nombre){
        this.nombre = nombre;
    }

    public String getApellido(){
        return apellido;
    }

    public void setApellido(String apellido){
        this.apellido = apellido;
    }

    public String getDni(){
        return dni;
    }

    public void setDni(String dni){
        this.dni = dni;
    }

    public double getSalario(){
        return salario;
    }

    public void setSalario(double salario){
        this.salario = salario;
    }

    // Métodos de instancia
    public double getSalarioAnual(){
        return salario*12;
    }

    public boolean aumentarSalarioEn(double porcentaje){
        if(porcentaje >= 0){
            this.salario = (1+(porcentaje/100))*salario;
            return true;
        }
        return false;
    }

    @Override
    public String toString() {
        return String.format("Empleado[Nombre: %s, Apellido: %s, DNI: %s, Salario: %s]", nombre, apellido, dni, salario);
    }
}
