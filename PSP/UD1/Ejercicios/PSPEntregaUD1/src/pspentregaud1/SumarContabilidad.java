package pspentregaud1;
/*
*   Autores: Wenceslao García Chando, Mario Ortiz Jibaja | 2º DAM    
*/

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;
import java.util.ArrayList;

public class SumarContabilidad {
    static int total = 0;
    public int Sumar(String nombreFichero){
        File fichero = new File(nombreFichero);
        int total = 0;
        try {
            FileReader reader = new FileReader(fichero);
            BufferedReader lector = new BufferedReader(reader);
            String linea = "";
            while ((linea = lector.readLine()) != null) {                
                total += Integer.valueOf(linea);
            }
        } catch (FileNotFoundException ex) {
            System.out.println("No se pudo abrir o no se encontró " + nombreFichero);
        } catch (IOException ex){
            System.out.println("No hay nada en " + nombreFichero);
        } 
        return total;
    }
    
    public static void main(String[] args) {
        SumarContabilidad s = new SumarContabilidad();
        System.out.println(s.Sumar(args[0]));
    }

}
