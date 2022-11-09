
import java.util.logging.Level;
import java.util.logging.Logger;


public class Ejercicio1 extends Thread {
    public static void main(String[] args) {
        Ejercicio1 hilo1 = new Ejercicio1();
        Ejercicio1 hilo2 = new Ejercicio1();
        Ejercicio1 hilo3 = new Ejercicio1();
        Ejercicio1 hilo4 = new Ejercicio1();
        Ejercicio1 hilo5 = new Ejercicio1();
        Ejercicio1 hilo6 = new Ejercicio1();   
        hilo1.setName("Hilo 1");
        hilo2.setName("Hilo 2");
        hilo3.setName("Hilo 3");
        hilo4.setName("Hilo 4");
        hilo5.setName("Hilo 5");
        hilo6.setName("Hilo 6");

        
        hilo1.start();
        hilo2.start();
        hilo3.start();
        hilo4.start();
        hilo5.start();
        hilo6.start();
    }

    @Override
    public void run() {
        try {
            sleep(Integer.valueOf(this.getName().substring(this.getName().indexOf(" ")+1)) * 1000);
        } catch (InterruptedException ex) {

            System.out.println("Error al dormir el hilo.");;
        }
        System.out.println(this.getName()+ ": Hola mundo");

    }
 
}
