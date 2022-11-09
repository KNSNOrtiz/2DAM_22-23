
public class Ejercicio2 extends Thread {
    
    public static Contador cont = new Contador();
            
    public static void main(String[] args) {
        Ejercicio2 hilo1 = new Ejercicio2();
        Ejercicio2 hilo2 = new Ejercicio2();
        Ejercicio2 hilo3 = new Ejercicio2();
        Ejercicio2 hilo4 = new Ejercicio2();
        
        hilo1.start();
        hilo2.start();
        hilo3.start();
        hilo4.start();
    }

    @Override
    public void run() { 
        for (int i = 0; i < 5000; i++) {
            cont.Incrementar();
        }
        System.out.println(cont.getContador());
    }
      
    
}
