public class Rectangulo {
    //Atributos
    private double ancho;
    private double alto;

    // Constructor
    public Rectangulo(){
        ancho = 1.0;
        alto  = 1.0;
    }

    // GETTERS Y SETTERS
    public double getAncho(){
        return ancho;
    }
    public void setAncho(double ancho) { this.ancho = ancho >= 0 ? ancho : 0; } // if else ternario
    public double getAlto(){
        return alto;
    }
    public void setAlto(double alto){
        this.alto = alto >= 0 ? alto : 0;
    }

    // Métodos de instancia
    public double area(){
        return alto*ancho;
    }
    public double perimetro(){
        return 2*(alto+ancho);
    }

    @Override
    public String toString() {
        return String.format("Alto: %s -- Ancho: %s => [Área: %s,Perímetro: %s]", alto, ancho, area(), perimetro());
    }
}
