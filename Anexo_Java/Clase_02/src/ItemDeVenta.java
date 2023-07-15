import  java.util.Scanner;
public class ItemDeVenta {
    // Atributos
    private int id;

    private String descripcion;

    private int cantidad;

    private double precioUnitario;

    // Constructor
    public ItemDeVenta(int id){
        this.id = id;
    }

    // Getters y Setters

    public int getId() { return id; }
    public void setId(int id){this.id = (id > 0) ? id : 0;}
    public String getDescripcion(){
        return descripcion;
    }

    public void setDescripcion(){
        System.out.println("Descripción:");
        this.descripcion = new Scanner(System.in).next();
    }

    public int getCantidad(){
        return cantidad;
    }

    public void setCantidad(int cantidad){
        this.cantidad = (cantidad > 0) ? cantidad : -1;
    }

    public double getPrecioUnitario(){
        return precioUnitario;
    }

    public void setPrecioUnitario(double precioUnitario){
        this.precioUnitario = (precioUnitario > 0) ? precioUnitario : -1;
    }

    public double precioTotal(){
        return cantidad * precioUnitario;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Datos del item de venta:\n");
        sb.append("Identificador: " + id);
        sb.append("\nDescripción: " + descripcion);
        sb.append("\nCantidad: " + cantidad);
        sb.append("\nPrecio por unidad: " + precioUnitario);
        sb.append("\nPrecio total: " + precioTotal());

        return sb.toString();
    }
}
