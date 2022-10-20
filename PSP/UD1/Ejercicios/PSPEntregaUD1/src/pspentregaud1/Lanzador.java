
package pspentregaud1;
/*
*   Autores: Wenceslao García Chando, Mario Ortiz Jibaja | 2º DAM    
*/

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.InputStreamReader;
public class Lanzador {
     static final String PREFIJO_FICHEROS = "result";
     static final int NUM_PROCESOS = 5;
     public void lanzarSumador(String fichOrigen, String fichDestino){
        String clase = "pspentregaud1.SumarContabilidad";
        ProcessBuilder pb;
        File directorio = new File(System.getProperty("java.class.path"));

        try {
            File archivoOrigen = new File(fichOrigen);
            File archivoDestino = new File(fichDestino);
            String rutaOrigen = String.valueOf(archivoOrigen.getAbsolutePath());
            pb = new ProcessBuilder("java", clase, rutaOrigen);
            pb.directory(directorio);
            pb.redirectError(new File("errores.txt"));
            pb.redirectOutput(archivoDestino);
            Process proceso = pb.start();
            proceso.waitFor();
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
            try{
               suma = Integer.valueOf(linea);             
            } catch(NumberFormatException ex){
                System.out.println("ERROR: En uno de los archivos de lectura se ha encontrado un dato erróneo.");
            }

            return suma;
        } catch (FileNotFoundException ex) {
            System.out.println("No se pudo abrir o no se encontró " + nombreFichero);
        } catch (IOException ex){
            System.out.println("No hay nada en " + nombreFichero);
        }
        return suma;
    }

    public static int getSumaTotal(int numFicheros){
        int sumaTotal = 0;
        for (int i = 1; i <= numFicheros; i++) {
            sumaTotal += getResultadoFichero(PREFIJO_FICHEROS + String.valueOf(i));
        }
        return sumaTotal;
    } 
    public static void main(String[] args) {
        Lanzador l = new Lanzador();
        String[] departamentos = new String[]{"informatica.txt", "gerencia.txt", "contabilidad.txt", "comercio.txt", "rrhh.txt"};
            for (int i = 0; i < NUM_PROCESOS; i++) {
                l.lanzarSumador(departamentos[i], PREFIJO_FICHEROS + String.valueOf(i+1));
            }
        System.out.println("El resultado final es: " + getSumaTotal(NUM_PROCESOS));
     
    }
}
