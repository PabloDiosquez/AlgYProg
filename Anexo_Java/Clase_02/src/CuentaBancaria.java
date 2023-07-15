public class CuentaBancaria {
    // Atributos
    private int id;

    private String nombre;

    private double balance;

    // Constructor
    public CuentaBancaria(){}
    public CuentaBancaria(int id, String nombre, double montoInicial){
        this.id = id;
        this.nombre = nombre;
        balance = montoInicial;
    }

    // Getters y Setters

    public int getId(){
        return id;
    }
    public void setId(int id){
        this.id = (id > 0) ? id : -1;
    }
    public String getNombre(){
        return nombre;
    }
    public void setNombre(String nombre){
        this.nombre = (!nombre.isEmpty()) ? nombre : "NN";
    }

    // Métodos de instancia particulares

    public double credito(double deposito){
        balance += deposito;
        return balance;
    }
    public double debito(double extraccion){
        if (balance >= extraccion){
            balance -= extraccion;
        }else{
            System.out.println("Saldo insuficiente");
        }
        return  balance;
    }

    @Override
    public String toString() {
        return String.format("Id: %s -- Nombre: %s -- Balance: $ %s", id, nombre, balance);
    }
}
