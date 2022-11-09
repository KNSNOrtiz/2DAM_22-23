public class Productor extends Thread {
    private Cesta cesta;
    private String alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public Productor(Cesta cesta){
        this.cesta = cesta;
    }
    @Override
    public void run() {
        for (int i = 0; i < 15; i++) {
            char letra = alfabeto.charAt((int)(Math.random()*26 ));           
            cesta.Meter(letra);
            System.out.println("Se ha metido la letra " + letra + " en la cesta.");
            try {
                sleep( (int)(Math.random() * 100 ) );
            } catch( InterruptedException e ) {
                
            }
        }
            
    }
}
    

