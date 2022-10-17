
/*
*   Autores: Wenceslao García Chando, Mario Ortiz Jibaja | 2º DAM    
*/

import java.io.*;
import java.nio.file.Files;
import java.util.ArrayList;

public class SumarContabilidad {
    public static int Sumar(<ArrayList><int> numeros){
        int total = 0;
        for (int i = 0; i < numeros.length; i++) {
            total += numeros[i];
        }
        return total;
    }
    public static int LeerFicheros(String nombreFichero){
        int suma = 0;
        try {
            FileInputStream lector = new FileInputStream(nombreFichero);
            ArrayList<String> lineas = new ArrayList<>(); 
            ArrayList<int> numeros = new ArrayList<>();
            lineas = Files.readAllLines(nombreFichero);
            for (int i = 0; i < lineas.size(); i++) {
                numeros.add(Integer.parseInt(lineas[i]));
            }
            return Sumar(numeros);
        } catch (FileNotFoundException ex) {
            System.out.println("No se pudo abrir" + nombreFichero);
        } catch (IOException ex){
            System.out.println("No hay nada en " + nombreFichero);
        } catch (NumberFormatExcepcion ex){
            System.out.println("En el fichero hay información no numérica.");
        }
        return suma;
    }
    
    public static void main(String[] args) {
        // TODO code application logic here
    }

}
