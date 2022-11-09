
import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;


public class RecursoCompartido {
    File fichero;
    FileReader fr;
    BufferedReader br;
    FileWriter fw;
    int lectores = 0;
    int escritores = 0;
    
    public RecursoCompartido(){
        fichero = new File("libro.txt");
        try {
            fichero.createNewFile();
        } catch (IOException ex) {
            System.out.println("No se ha podido crear el fichero");
        }
        try {
            fw = new FileWriter(fichero);   //  Vacía el fichero cada vez que se ejecuta el programa.
            fw.write(" ");
        } catch (IOException ex) {
            
        }
        try {
            fr = new FileReader(fichero);
            br = new BufferedReader(fr);
        } catch (FileNotFoundException ex) {
            
        }

    }
    
    public synchronized int Leer(){
        int letra = 0;
        if (lectores < 2) {
            lectores++;
            try {
                letra = br.read();
            } catch (IOException ex) {
                System.out.println("No se ha podido leer en el fichero.");
            }
            lectores--;
        }
        System.out.println("Ya hay dos lectores leyendo. Espera a que terminen.");
        return letra;   
    }
    
    public synchronized void Escribir(char letra){
        if (escritores < 1) {                  
            try {
                escritores++;
                fw = new FileWriter(fichero,true);
                fw.write(letra);          
            } catch (IOException ex) {
                System.out.println("El escritor no ha podido escribir en el fichero");
            }
            escritores--;
        }
        else{
            System.out.println("Hay un escritor escribiendo. Espera a que termine.");
        }
    }
}
