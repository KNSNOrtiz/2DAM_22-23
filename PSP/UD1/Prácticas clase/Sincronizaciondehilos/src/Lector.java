
import java.util.Random;

public class Lector extends Thread{
    private RecursoCompartido libro;
    
    public Lector(RecursoCompartido libro, String nombre){
        this.libro = libro;
        this.setName(nombre);
    }
    @Override
    public void run() {
         for(int i = 0; i < 6; i++) {
            Random rnd = new Random();
            int letra = libro.Leer();
            if (letra > -1) {
                System.out.println(this.getName() + " ha leído " + (char)letra);
            }
            try {
                sleep(rnd.nextInt((5 + 1 - 2) + 2) * 1000);
            } catch( InterruptedException e ) {
                
            }            
        }
    }
    

}
