
import java.util.logging.Level;
import java.util.logging.Logger;


public class Ejercicio1Runnable implements Runnable {
    public static void main(String[] args) {
        Ejercicio1Runnable hilo1 = new Ejercicio1Runnable();
        Ejercicio1Runnable hilo2 = new Ejercicio1Runnable();
        Ejercicio1Runnable hilo3 = new Ejercicio1Runnable();
        Ejercicio1Runnable hilo4 = new Ejercicio1Runnable();
        Ejercicio1Runnable hilo5 = new Ejercicio1Runnable();
        Ejercicio1Runnable hilo6 = new Ejercicio1Runnable();   
        
        hilo1.run();
        hilo2.run();
        hilo3.run();
        hilo4.run();
        hilo5.run();
        hilo6.run();
    }

    @Override
    public void run() {
        System.out.println("Hola mundo");
    }
 
}
