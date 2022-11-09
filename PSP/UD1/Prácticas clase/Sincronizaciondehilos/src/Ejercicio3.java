
public class Ejercicio3 {
    
    public static void main(String[] args) {
        Cesta cesta;
        cesta = new Cesta();
        Productor productor = new Productor(cesta);
        Productor productor2 = new Productor(cesta);
        Consumidor consumidor = new Consumidor(cesta);  
        Consumidor consumidor2 = new Consumidor(cesta);   
        productor.start();
        consumidor.start();
    }
}
