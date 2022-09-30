package mario.pruebas;

import java.io.File;

public class Lanzador {
    public void lanzarSumador(Integer n1, Integer n2, String fichResultado){
        String clase = "mario.pruebas.Sumador";
        ProcessBuilder pb;
        try {
            pb = new ProcessBuilder("java",clase,n1.toString(),n2.toString());
            pb.start();
            pb.redirectError(new File("errores.txt"));
            pb.redirectOutput(new File(fichResultado));
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public static void main(String[] args){
        Lanzador l = new Lanzador();
        l.lanzarSumador(1, 51,".\\result1.txt");
        l.lanzarSumador(51,100,".\\result2.txt");
        System.out.println("OK");
    }
}
