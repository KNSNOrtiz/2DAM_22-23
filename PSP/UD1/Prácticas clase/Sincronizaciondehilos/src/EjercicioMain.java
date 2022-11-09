public class EjercicioMain {
    public static RecursoCompartido libro = new RecursoCompartido();
    
    public static void main(String[] args) {
        Lector lector1 = new Lector(libro, "Lector 1");
        Lector lector2 = new Lector(libro, "Lector 2");
        Lector lector3 = new Lector(libro, "Lector 3");
        Lector lector4 = new Lector(libro, "Lector 4");
        Escritor escritor1 = new Escritor(libro, "Escritor 1");
        Escritor escritor2 = new Escritor(libro, "Escritor 2");
        Escritor escritor3 = new Escritor(libro, "Escritor 3");
        escritor1.setPriority(1);
        escritor2.setPriority(1);
        lector1.setPriority(10);
        lector2.setPriority(10);
        lector3.setPriority(10);
        lector4.setPriority(10);
        escritor1.start();
        escritor2.start();
        escritor3.start();
        lector1.start();
        lector2.start();
        lector3.start();
        lector4.start();
    }
    
}