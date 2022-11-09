import java.io.IOException;
import java.util.Random;

public class Escritor extends Thread {
    private RecursoCompartido libro;
    private String alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public Escritor(RecursoCompartido libro, String nombre){
        this.libro = libro;
        this.setName(nombre);
    }
    @Override
    public void run() {
        for(int i = 0; i < 6; i++) {
            Random rnd = new Random();
            char letra = alfabeto.charAt(rnd.nextInt(alfabeto.length()));           
            libro.Escribir(letra);
            System.out.println( this.getName() + " ha escrito " + letra + " en el libro.");
            try {
            libro.fw.close();
            } catch (IOException ex) {
                System.out.println("No se ha podido cerrar el flujo de escritura.");;
            }
            try {
                sleep(rnd.nextInt(4) * 1000);
            } catch( InterruptedException e ) {
                
            }
        }
        
            
    }
}
