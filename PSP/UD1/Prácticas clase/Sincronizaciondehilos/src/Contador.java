
public class Contador {
    private int contador = 0;
    
    public synchronized int getContador(){
        return contador;
    }
    
    public synchronized void Incrementar(){
        contador++;
    }        
}
