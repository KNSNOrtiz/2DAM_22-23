import java.util.Random;

public class Cesta {
    char[] cesta = new char[6];
    boolean estaLlena = false;
    boolean estaVacia = false;
    int contador = 0;
    
    public synchronized char Recoger(){
        if (contador == 0) {
            estaVacia = true;
        }
        while (estaVacia) {            
            try {
                System.out.println("El consumidor está esperando.");
                wait();              
            } catch (InterruptedException ex) {
                System.out.println("La cesta está vacía. No se puede recoger nada.");;
            }
        }
        if (!estaVacia) {
          contador--;  
        } 
        estaLlena = false;
        notify();
        return cesta[contador];   
    }
    
    public synchronized void Meter(char letra){
        if (contador == cesta.length-1) {
            estaLlena = true;
        }
        while (estaLlena) {            
            try {
                System.out.println("El productor  está esperando.");
                wait();
            } catch (InterruptedException ex) {
                System.out.println("La cesta está llena. No se puede  meter nada.");;
            }
        }
        cesta[contador] = letra;
        contador++;
        if(contador > 0){
            estaVacia = false;
        }     
        notify();
    }
    
    
}
