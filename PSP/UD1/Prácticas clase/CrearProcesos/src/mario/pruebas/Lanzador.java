package mario.pruebas;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;

public class Lanzador {
    
    static final int NUM_PROCESOS=4;
    static final String PREFIJO_FICHEROS="fich";
    
    public void lanzarSumador(Integer n1, Integer n2, String fichResultado){
        String clase = "mario.pruebas.Sumador";
        ProcessBuilder pb;
        File directorio = new File(System.getProperty("java.class.path"));

        try {
            File archivo = new File(fichResultado);
            pb = new ProcessBuilder("java",clase,n1.toString(),n2.toString());
            pb.directory(directorio);
            pb.redirectError(new File("errores.txt"));
            pb.redirectOutput(archivo);
            pb.start();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public static int getResultadoFichero(String nombreFichero){
        int suma = 0;
        try {
            FileInputStream fichero = new FileInputStream(nombreFichero);
            InputStreamReader lector = new InputStreamReader(fichero);
            BufferedReader br = new BufferedReader(lector);
            String linea = br.readLine();
            suma = Integer.valueOf(linea);
            return suma;
        } catch (FileNotFoundException ex) {
            System.out.println("No se pudo abrir" + nombreFichero);
        } catch (IOException ex){
            System.out.println("No hay nada en " + nombreFichero);
        }
        return suma;
    }
    public static int getSumaTotal(int numFicheros){
        int sumaTotal = 0;
        for (int i = 1; i <= NUM_PROCESOS; i++) {
            sumaTotal += getResultadoFichero(PREFIJO_FICHEROS+String.valueOf(i));
        }
        return sumaTotal;
    }
    public static void main(String[] args) throws IOException, InterruptedException{
        Lanzador l = new Lanzador();
        int n1=Integer.parseInt(args[0]);
        int n2=Integer.parseInt(args[1]);
        int salto =( n2 / NUM_PROCESOS);
        for (int i = 0; i <= NUM_PROCESOS; i++) {
            System.out.println("n1: " +n1);
            int resultadoSumaConSalto = n1+salto;
            System.out.println("n2: " + resultadoSumaConSalto);
            l.lanzarSumador(n1, n1+salto, PREFIJO_FICHEROS+String.valueOf(i));
            n1 = n1 + salto + 1;
            
        }
        Thread.sleep(2000);
        System.out.println(getSumaTotal(NUM_PROCESOS));
        System.out.println("OK");
    }
}
