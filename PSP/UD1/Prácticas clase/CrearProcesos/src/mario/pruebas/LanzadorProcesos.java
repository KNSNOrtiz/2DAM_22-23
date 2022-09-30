package mario.pruebas;

public class LanzadorProcesos {
    
    public void Ejecutar(String ruta){
        ProcessBuilder pb;
        try {
              pb = new ProcessBuilder(ruta);
              pb.start();
        } catch (Exception e) {
            e.printStackTrace();
        }
        
    }
    public static void main(String[] args){
        String ruta = "C:\\Program Files\\Adobe\\Acrobat DC\\Acrobat\\Acrobat.exe";
        LanzadorProcesos lp = new LanzadorProcesos();
        lp.Ejecutar(ruta);
        System.out.println("Finalizado");
    
    }
}
