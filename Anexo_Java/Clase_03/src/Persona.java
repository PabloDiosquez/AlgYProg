public class Persona {
    private static int id = 0;

    private int idPersona;

    public Persona(){
        idPersona = generarId();
    }

    private static int generarId(){
        return ++id;
    }

    public static int getId(){
        return id;
    }

    @Override
    public String toString() {
        return String.format("Id Persona: %s", idPersona);
    }
}
