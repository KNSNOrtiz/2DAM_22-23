public class Consumidor extends Thread {
    private Cesta cesta;
    public Consumidor(Cesta cesta){
        this.cesta = cesta;
    }

    @Override
    public void run() {
        for (int i = 0; i < 15; i++) {
            System.out.println("Se ha recogido " + cesta.Recoger());
            try {
                sleep( (int)(Math.random() * 100 ) );
            } catch( InterruptedException e ) {
                
            }            
        }
    }
    
}
